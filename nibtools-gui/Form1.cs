///
/// 
/// This software is designed to aid in the ease of use of Nibread, Nibwrite and Nibconv by Pete Rittwage.
/// This is ONLY a GUI for these programs and they are NOT included in this repository.
/// Nibtools can be located on the c64preservation project website
/// 
/// https://c64preservation.com/dp.php?pg=nibtools
/// 
/// This will allow for batch-conversion of NIB/NBZ/G64/D64 files, reading and writing of NIB's from actual disks
/// 
/// This software is free and shall not ever be sold or monetized in any way, shape or form.
/// You may make modifications to the program as you wish, but this program must remain free
///
/// This program is built on Dot-Net 3.5 for Windows XP compatibility.
/// Nu-get packages used are as follows
///
/// System.Threading.Tasks.Unofficial           (to provide extended threading functionality not available in .net 3.5)
/// WindowsAPICodePack-Core
/// Costura.Fody (1.6.0)                        (embeds external resources into executable to make the exe a stand-alone file)
///
///
/// Current functionality : Convert and Read (only) Write is not yet implemented
/// 
/// Known bugs..
/// 
/// on the Convert tab, DO NOT drag multiple (FOLDERS) into the window. Program WILL crash when processing the file list.
/// I know exactly what the issue is and still working on a suitable solution.  For now, if dragging folders into the window, 
/// only drag one (1) folder.  All subfolders in that folder will process fine.  Dragging one (1) folder along with multiple file(s)
/// is also acceptable and will not crash the program.


/////////////////////////////////////////////////////////////
//     Nibtools-GUI by Daryl Krans                         //
//     Nov 17 2023 - Nov 24 2023                           //
//     Version 0.3.1.0 (alpha)                             //
/////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nibtools_gui
{
    public partial class GUI : Form
    {
        readonly Microsoft.Win32.RegistryKey ntkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Nibtools-GUI\");
        readonly string title = "Nibtools-GUI v0.3.1.0";
        readonly string SupFmt = ".NIB,.nib,.NBZ,.nbz,.G64,.g64,.D64,.d64";
        readonly string exe_path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        readonly string[] ProHand = { "V-Max! (v3)", "V-Max! (v2) Cinemaware", "GMA/Secruispeed (T38/T39)", "Rainbow Arts/Magic Bytes (T36)", "Rapidlok", "Vorpal (newer) EPYX" };
        readonly string[] trk_aln = { "Automatic", "Longest run of unformatted data", "Longest gap", "Longest sync", "Sector 0", "Raw Data" };
        readonly string n_conv = "nibconv.exe";
        readonly string n_read = "nibread.exe";
        readonly string n_writ = "nibwrite.exe";
        readonly string[] nmf = { "No Matching Files" };
        readonly ToolTip toolTip1 = new ToolTip();
        static bool conv_tab = false;
        static bool read_tab = false;
        static bool writ_tab = false;
        static bool working = false;
        static bool cancel = false;
        static bool overwrite = false;
        // nibconv variables
        static string out_path = "";
        static string[] Droplist = new string[0];
        static string[] DoList = new string[0];
        static string ext = "";
        static string oxt = "";
        // nibread variables
        static string read_path = "";
        static string read_name = "";
        static string rext = "";
        static string num_seq = "";
        // -------------
        static string main_path;
        static string root_path;
        // Limit # of threads for the asynchronous for-loop to prevent loading the system with THOUSANDS of threads rendering program non-responsive
        readonly Semaphore sem = new Semaphore(3, 3);

        public GUI()
        {
            InitializeComponent();
            Init_Program();
        }
        void MessageForYouSir(string t, string m)
        {
            MessageBoxButtons b = MessageBoxButtons.OK;
            MessageBox.Show(m, t, b, MessageBoxIcon.Warning);
        }

        public IEnumerable<string> Get(string path)
        {
            IEnumerable<string> files = Enumerable.Empty<string>();
            IEnumerable<string> directories = Enumerable.Empty<string>();
            try
            {
                files = Directory.GetFiles(path);
                directories = Directory.GetDirectories(path);
            }
            catch
            {
                path = null;
            }

            if (path != null)
            {
                yield return path;
            }

            foreach (var file in files)
            {
                yield return file;
            }
            var subdirectoryItems = directories.SelectMany(Get);
            foreach (var result in subdirectoryItems)
            {
                yield return result;
            }
        }

        private static string Trunc(bool r, string value, int maxChars)
        {
            if (r) return value.Length <= maxChars ? value : $"{System.IO.Path.GetPathRoot(value)}..{value.Substring(value.Length - (maxChars), maxChars)}";
            else return value.Length <= maxChars ? value : $"{value.Substring(0, maxChars)}..";
        }

        ///  Initialize program routine starts here --->
        public void Init_Program()
        {
            // Set default values for options
            this.Text = title;
            // turn off the Program tabs until we know if any of the nibtools executables have been located
            Tabs.Visible = Conv_Start.Enabled = false;
            // Get the current filepath and check if nibtools executables are in the same folder as the GUI executable
            main_path = System.IO.Path.GetDirectoryName(exe_path);
            CheckFiles(main_path);
            // if none of the nibtools executables were found in the current path, Check nibtools-GUI registry location for path to nibtools
            if (!conv_tab && !writ_tab && !read_tab) RegPath();
            CheckTabs(); // function checks which nibtools executables are available and turns off tabs for ones that are not
            if (conv_tab) Set_Convert_Defaults(); // set Nibconv default values
            if (read_tab) Set_Read_Defaults();
            // makes the tabs page visible
            Tabs.Visible = true;
            //Tabs.Selecting += new TabControlCancelEventHandler(TabControl1_Selecting);

            void RegPath()
            {
                // handle path to nibtools through system registry if not in same folder as gui executable
                bool s = (ntkey.GetValueNames().Contains("path")); // check if path to nibtools folder exists in the registry
                if (s) main_path = ntkey.GetValue("path").ToString();
                // if path exists in registry, check to verify nibtools executables are still there
                CheckFiles(main_path);
                if (!conv_tab && !writ_tab && !read_tab) // if not found, prompt user for new location to nibtools
                {
                    string t = "Nibtools not found!";
                    string m = "Browse for Nibtools folder?";
                    MessageBoxButtons b = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show(m, t, b, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Cancel) NothingToDo();
                    else CheckRegPath();
                    if (!conv_tab && !writ_tab && !read_tab) RegPath();
                }

                void CheckRegPath()
                {
                    var p = folderBrowserDialog1.ShowDialog(this);
                    if (p == DialogResult.OK)
                    {
                        main_path = folderBrowserDialog1.SelectedPath;
                        CheckFiles(main_path);
                        if (conv_tab || writ_tab || read_tab) // if any of the 3 nibtools exe's were found, write path to files in the registry 
                        {
                            ntkey.SetValue("path", main_path);
                        }
                    }
                    if (p == DialogResult.Cancel) NothingToDo();

                }

                // Path to nibtools wasn't found. Pointless to continue, might as well quit
                void NothingToDo()
                {
                    string t = "Nothing to do!";
                    string m = "Closing Program";
                    MessageForYouSir(t, m);
                    System.Environment.Exit(0);
                }
            }

            void Set_Convert_Defaults()
            {
                P_handler.DataSource = ProHand;
                T_align.DataSource = trk_aln;
                A_Opts.Enabled = Adv_opts.Checked;
                listBox1.HorizontalScrollbar = true; // listBox2.HorizontalScrollbar = true;
                G_len.Value = 7;
                RPM.Value = 300;
                Ag_Gcr.Value = 1;
                RPM.Enabled = S_Rpm.Checked;
                S_NIB.Checked = O_G64.Checked = rel_path.Checked = true;
                listBox1.AllowDrop = true;
                listBox1.DragEnter += new DragEventHandler(Nib_Drag_Enter);
                listBox1.DragDrop += new DragEventHandler(Nib_Drag_Drop);
                Matching_Files.Text = "";
                bool op = (ntkey.GetValueNames().Contains("ConvOutputPath"));
                if (op)
                {
                    out_path = ntkey.GetValue("ConvOutputPath").ToString();
                    if (!Directory.Exists(out_path)) out_path = $@"{Path.GetDirectoryName(exe_path)}\";
                }
                else out_path = $@"{Path.GetDirectoryName(exe_path)}\";
                Out_Folder.Text = $"Output Folder [ {Trunc(true, out_path, 65)} ]";
                List<string> d = new List<string>
                {
                    "Drag file(s) / folder (singular) to convert"
                };
                listBox1.DataSource = d;
                Conv_proc.Text = "";
            }

            void Set_Read_Defaults()
            {
                r_ext.Text = "";
                R_NIB.Checked = true;
                Read_Start.Enabled = false;
                Dev_num.Enabled = R_Devnum.Checked;
                N_Scheme.Enabled = NS.Checked;
                R_tgap.Enabled = Read_tgap.Checked;
                S_track.Enabled = E_track.Enabled = T_override.Checked;
                R_tgap.Value = 7;
                S_track.Value = 1;
                E_track.Value = 41;
                listBox2.AllowDrop = true;
                listBox2.DragEnter += new DragEventHandler(NibR_Drag_Enter);
                listBox2.DragDrop += new DragEventHandler(NibR_Drag_Drop);
                U_test.Enabled = U_sensor.Enabled = U_bitrate.Enabled = U_alignment.Enabled = IHS.Checked;
                bool op = (ntkey.GetValueNames().Contains("ReadOutputPath"));
                if (op)
                {
                    read_path = ntkey.GetValue("ReadOutputPath").ToString();
                    if (!Directory.Exists(read_path)) read_path = $@"{Path.GetDirectoryName(exe_path)}\";
                }
                else read_path = $@"{Path.GetDirectoryName(exe_path)}\";
                R_Path.Text = $"Output Folder [ {Trunc(true, read_path, 30)} ]";
                toolTip1.SetToolTip(this.R_Path, read_path);
                GetDirContent(read_path);
                op = (ntkey.GetValueNames().Contains("ParallelTransfer"));
                if (op)
                {
                    var qp = (ntkey.GetValue("ParallelTransfer"));
                    Parallel.Checked = (string)qp == "True";
                }
                else Parallel.Checked = false;
            }
            // Checks if nibtools executables exist in selected path
            void CheckFiles(string p)
            {
                if (System.IO.File.Exists($@"{p}\{n_conv}")) conv_tab = true;
                if (System.IO.File.Exists($@"{p}\{n_read}")) read_tab = true;
                if (System.IO.File.Exists($@"{p}\{n_writ}")) writ_tab = true;
            }

            // Removes tabs for nib-executables that weren't found in the selected path
            void CheckTabs()
            {
                if (!conv_tab) this.Tabs.Controls.Remove(this.Nibconv);
                if (!read_tab) this.Tabs.Controls.Remove(this.Nibread);
                if (!writ_tab) this.Tabs.Controls.Remove(this.Nibwrite);
            }
        }

        /// ** end ** Program initialization ----
        void SetReadOutputFileName()
        {
            if (R_Outfile.Text != "")
            {
                r_ext.Text = Trunc(true, $"{R_Outfile.Text}{num_seq}{rext}", 45);
                toolTip1.SetToolTip(r_ext, $"{R_Outfile.Text}{num_seq}{rext}");
            }
            else { r_ext.Text = "none"; }
        }
        void ReCompile_List()
        {
            if (Droplist.Length > 0)
            {
                DoList = new string[0];
                ext = "";
                oxt = "";
                if (S_NIB.Checked) ext = ".nib";
                if (S_NBZ.Checked) ext = ".nbz";
                if (S_G64.Checked) ext = ".g64";
                if (S_D64.Checked) ext = ".d64";
                if (O_D64.Checked) { oxt = ".d64"; if (Adv_opts.Checked) A_Opts.Enabled = false; }
                if (O_G64.Checked) oxt = ".g64";
                if (O_NIB.Checked) oxt = ".nib";
                if (O_NBZ.Checked) oxt = ".nbz";
                if (!O_D64.Checked && Adv_opts.Checked) { A_Opts.Enabled = true; }
                List<string> Source_list = new List<string>();
                DateTime start = DateTime.Now;
                TimeSpan span = TimeSpan.FromSeconds(3);
                Task.Run(delegate
                {
                    for (int i = 0; i < Droplist.Length; i++)
                    {
                        var file = Droplist[i];
                        if (System.IO.File.Exists(file))
                        {
                            string ex = Path.GetExtension(file).ToLower();
                            if (ex.Contains(ext))
                            {
                                Source_list.Add(file);
                            }
                        }
                        if (DateTime.Now - span > start)
                        {
                            Invoke(new Action(() => { Total_Files.Text = $"Processing files {i:N0} of {Droplist.Length:N0}"; Total_Files.Update(); }));
                        }
                    }
                    Invoke(new Action(() =>
                    {
                        if (Source_list.Count > 0)
                        {
                            DoList = Source_list.ToArray();
                            listBox1.BeginUpdate();
                            listBox1.DataSource = DoList;
                            listBox1.EndUpdate();
                        }
                        else listBox1.DataSource = nmf;

                        Matching_Files.Text = $"[{ext.ToUpper()}] files found {DoList.Length:N0}";
                        if (DoList.Length > 0) Conv_Start.Enabled = true; else Conv_Start.Enabled = false;
                    }));
                });
            }
            Total_Files.Text = $"Total files selected {Droplist.Length:N0}";
            Out_Folder.Text = $"Output Folder [ {Trunc(true, out_path, 65)} ]";
        }
        void NibR_Drag_Enter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        void NibR_Drag_Drop(object sender, DragEventArgs e)
        {
            string[] File_List = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (File_List.Length > 0)
            {
                if (Directory.Exists(File_List[0]))
                {
                    read_path = File_List[0];
                    toolTip1.SetToolTip(this.R_Path, read_path);
                    ntkey.SetValue("ReadOutputPath", read_path);
                    R_Path.Text = $"Output Folder [ {Trunc(true, read_path, 30)} ]";
                    GetDirContent(read_path);
                }
            }
        }

            void Nib_Drag_Enter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        void Nib_Drag_Drop(object sender, DragEventArgs e)
        {
            var d = 0;
            var g = 0;
            var n = 0;
            var z = 0;
            root_path = "";
            string[] File_List = (string[])e.Data.GetData(DataFormats.FileDrop);
            var files = new List<string>();
            var len = 0;
            if (Directory.Exists(File_List[0])) root_path = $@"{File_List[0]}\";
            else if (System.IO.File.Exists(File_List[0])) root_path = Path.GetDirectoryName(File_List[0]);
            for (int r = 0; r < File_List.Length; ++r)
            {
                string ex;
                try
                {
                    if (!Directory.Exists(File_List[r]))
                    {
                        len = (File_List[r].Length);
                        ex = Path.GetExtension(File_List[r]);
                        if (len > 0 && SupFmt.Contains(ex))
                        {
                            files.Add(File_List[r]);
                            inc(ex);
                        }
                    }
                    else
                    {
                        var Folder_files = Get(File_List[r]).ToArray();
                        for (int s = 0; s < Folder_files.Length; ++s)
                        {
                            ex = Path.GetExtension(Folder_files[s]).ToLower();
                            if (!Directory.Exists(Folder_files[s])) len = (Folder_files[s].Length);
                            if (len > 0)
                            {
                                if (System.IO.File.Exists(Folder_files[s]) && SupFmt.Contains(Path.GetExtension(ex))) files.Add(Folder_files[s]);
                                inc(ex);
                            }
                        }
                    }
                }
                catch (Exception) { }
            }
            var f = new int[] { d, g, n, z };
            var m = f.Max();
            Droplist = new string[files.Count];
            Droplist = files.ToArray();
            if (m == d) S_D64.Checked = true;
            if (m == g) S_G64.Checked = true;
            if (m == n) S_NIB.Checked = true;
            if (m == z) S_NBZ.Checked = true;
            ReCompile_List();

            void inc(string et)
            {
                switch (et)
                {
                    case ".d64": ++d; break;
                    case ".g64": ++g; break;
                    case ".nib": ++n; break;
                    case ".nbz": ++z; break;
                }
            }
        }

        void GetDirContent(string rp)
        {
            List<string> list = new List<string>();
            try
            {
                if (Directory.Exists(rp))
                {
                    DirectoryInfo d = new DirectoryInfo(rp);
                    FileInfo[] Files = d.GetFiles("*.*");
                    foreach (FileInfo file in Files)
                    {
                        if (SupFmt.Contains(file.Extension) && (file.Extension.ToLower()).Contains(rext)) list.Add(file.Name);
                    }
                }
            }
            catch (Exception) { }
            listBox2.BeginUpdate();
            listBox2.DataSource = list;
            listBox2.EndUpdate();
            SetReadOutputFileName();
            r_current.Text = $"Total {rext.ToUpper()} files in current folder {list.Count:N0}";
        }
        void Convert(string arg)
        {
            if (overwrite)
            {
                string t = "Overwrite?";
                string m = "Existing files will be overwritten!";
                MessageBoxButtons b = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show(m, t, b, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel) { goto endcode; }
            }
            working = true;
            int ovr = 0;
            int skp = 0;
            var exe = $@"{main_path}\{n_conv}";
            Source_box.Enabled = Out_Box.Enabled = rel_path.Enabled = browse.Enabled = Adv_opts.Enabled = A_Opts.Enabled = false;
            ((Control)this.Nibread).Enabled = ((Control)this.Nibwrite).Enabled = false;
            Conv_Start.Text = "Cancel";
            string result = "";
            // Start task asynchronous to allow cancel function to work
            Task.Run(delegate
            {
                for (int i = 0; i < DoList.Length; i++)
                {

                    Invoke(new Action(() => { Conv_proc.Text = $"Processing {i + 1:N0} of {DoList.Length:N0}"; }));
                    string outdir = "";
                    string outfile = "";
                    if (rel_path.Checked)
                    {
                        var new_ext = Path.ChangeExtension(DoList[i], oxt);
                        outfile = $"{new_ext.Remove(new_ext.IndexOf(root_path), root_path.Length)}";
                    }
                    else
                    {
                        outfile = Path.ChangeExtension(Path.GetFileName(DoList[i]), oxt);
                    }
                    outdir = $@"{Path.GetDirectoryName(out_path + outfile)}";
                    var final_Output = arg + " " + "\"" + DoList[i] + "\"" + " " + "\"" + out_path + outfile + "\"";
                    if (!Directory.Exists(outdir))
                    {
                        try
                        {
                            Directory.CreateDirectory(outdir);
                        }
                        catch { }
                    }
                    if (overwrite && File.Exists(out_path + outfile))
                    {
                        try
                        {
                            File.Delete(out_path + outfile);
                            ++ovr;
                        }
                        catch { }
                    }
                    if (!File.Exists(out_path + outfile))
                    {
                        sem.WaitOne();
                        ThreadPool.QueueUserWorkItem(state => Work(exe, final_Output));
                        if (cancel) i = DoList.Length - 1;
                    }
                    else ++skp;
                }
                this.Invoke(new Action(() =>
                {
                    Conv_proc.Text = ""; Conv_Start.Text = "Convert"; Source_box.Enabled = ((Control)this.Nibread).Enabled = ((Control)this.Nibwrite).Enabled =
                    Out_Box.Enabled = rel_path.Enabled = browse.Enabled = Adv_opts.Enabled = true; if (!O_D64.Checked && Adv_opts.Checked) A_Opts.Enabled = true;
                    cancel = working = false;
                }));
                if (ovr > 0)
                {
                    string t = "Done!";
                    string m = $"{ovr} files overwritten";
                    MessageForYouSir(t, m);
                }
                if (skp > 0)
                {
                    string t = "Done!";
                    string m = $"{skp} files skipped because they already exist";
                    MessageForYouSir(t, m);
                }
            });
        endcode:

            void Work(string ex, string cmd)
            {
                try
                {
                    ProcessStartInfo procStartInfo = new ProcessStartInfo(ex, cmd)
                    {
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    Process process = new Process
                    {
                        StartInfo = procStartInfo
                    };
                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    result = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                }
                catch { }
                sem.Release();
            }
        }
        private void NIB_CheckedChanged(object sender, EventArgs e)
        {
            if (S_NIB.Checked)
            {
                O_NIB.Enabled = false;
                if (O_NIB.Checked) O_G64.Checked = true;
            }
            else { O_NIB.Enabled = true; };
            ReCompile_List();
        }

        private void NBZ_CheckedChanged(object sender, EventArgs e)
        {
            if (S_NBZ.Checked)
            {
                O_NBZ.Enabled = false;
                if (O_NBZ.Checked) O_G64.Checked = true;
            }
            else { O_NBZ.Enabled = true; };
            ReCompile_List();
        }

        private void G64_CheckedChanged(object sender, EventArgs e)
        {
            if (S_G64.Checked)
            {
                O_G64.Enabled = false;
                if (O_G64.Checked) O_D64.Checked = true;
            }
            else { O_G64.Enabled = true; };
            ReCompile_List();
        }

        private void D64_CheckedChanged(object sender, EventArgs e)
        {
            if (S_D64.Checked)
            {
                O_D64.Enabled = false;
                if (O_D64.Checked) O_G64.Checked = true;
            }
            else { O_D64.Enabled = true; };
            ReCompile_List();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.Out_Folder, out_path);
            toolTip1.SetToolTip(this.R_Browse, "Change Output Folder");
            toolTip1.SetToolTip(this.browse, "Change Output Folder");
            toolTip1.SetToolTip(this.Agg_Gcr, "0 = Do not repair, 1 = Kill only completely bad GCR, 2 = Kill bad GCR & mask out bytes before/after, 3 = kill bad GCR + bytes before/after");
            toolTip1.SetToolTip(this.rel_path, "Preserves the folder structure of the input on batch-convert");
            toolTip1.SetToolTip(this.Over_Write, "Overwrites existing files on output.  If (NOT) checked, existing files will be skipped");
            toolTip1.SetToolTip(this.S_D64, "This option is pointless, but I'm sure you have your reasons. Converting FROM .d64 to anything else is like converting VHS to Blu-Ray");
            toolTip1.SetToolTip(this.O_D64, "This is a (lossy) format that contains sector data only. G64 is recommended to preserve data between sectors for programs that require it");
            toolTip1.SetToolTip(this.NS, "Enabling appends a number to the end of the file name and increments every time a disk is read");
        }

        private void O_G64_CheckedChanged(object sender, EventArgs e)
        {
            if (O_D64.Checked && Adv_opts.Checked) A_Opts.Enabled = false; else A_Opts.Enabled = Adv_opts.Checked;
            ReCompile_List();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            var previous = out_path;
            var p = folderBrowserDialog1.ShowDialog(this);
            if (p == DialogResult.OK)
            {
                out_path = $@"{folderBrowserDialog1.SelectedPath}\";
            }
            else out_path = previous;
            toolTip1.SetToolTip(this.Out_Folder, out_path);
            ntkey.SetValue("ConvOutputPath", out_path);
            ReCompile_List();
        }

        private void Rel_path_CheckedChanged(object sender, EventArgs e)
        {
            ReCompile_List();
        }

        private void Conv_Start_Click(object sender, EventArgs e)
        {
            if (!working)
            {
                string args = " ";
                if (Adv_opts.Checked && !O_D64.Checked)
                {
                    if (Prot.Checked)
                    {
                        var se = P_handler.SelectedIndex;
                        switch (se)
                        {
                            case 0: args += "-px "; break;
                            case 1: args += "-pc "; break;
                            case 2: args += "-pg "; break;
                            case 3: args += "-pm "; break;
                            case 4: args += "-pr "; break;
                            case 5: args += "-pv "; break;
                        }
                    }
                    if (A_Align.Checked)
                    {
                        var se = T_align.SelectedIndex;
                        switch (se)
                        {
                            case 0: args += "-aa "; break;
                            case 1: args += "-aw "; break;
                            case 2: args += "-ag "; break;
                            case 3: args += "-as "; break;
                            case 4: args += "-a0 "; break;
                            case 5: args += "-an "; break;
                        }
                    }
                    if (GCR.Checked) args += "-0 ";
                    if (Gap.Checked) args += "-g ";
                    if (Sync.Checked) args += "-r ";
                    if (Bad_GCR.Checked) args += "-f ";
                    if (S_Rpm.Checked) args += $"-C{RPM.Value} ";
                    if (Skew.Checked) args += $"-T{t_skew.Value} ";
                    if (Gm_Len.Checked) args += $"-G{G_len.Value} ";
                    if (Agg_Gcr.Checked) args += $"-f{Ag_Gcr.Value} ";
                }
                Convert(args);
            }
            else cancel = true;
        }
        private void Adv_opts_CheckedChanged(object sender, EventArgs e)
        {

            if (Bad_GCR.Checked) Agg_Gcr.Checked = false;
            if (Adv_opts.Checked && !O_D64.Checked)
            {
                A_Opts.Enabled = true;
                t_skew.Enabled = Skew.Checked; P_handler.Enabled = Prot.Checked;
            }
            else A_Opts.Enabled = false;
            t_skew.Enabled = Skew.Checked;
            RPM.Enabled = S_Rpm.Checked;
            P_handler.Enabled = Prot.Checked;
            T_align.Enabled = A_Align.Checked;
            Ag_Gcr.Enabled = Agg_Gcr.Checked;
            G_len.Enabled = Gm_Len.Checked;
        }

        private void Read_Start_Click(object sender, EventArgs e)
        {
            string t = "Something (possibly) went wrong!";
            string m = $"Either {n_read} failed to start\ror something is wrong with your settings\rcheck your settings and try again";
            string q = "\r\rthis message will also appear if the file\ralready existed and you chose not to overwrite it";
            string args = " ";
            Get_ReadArgs();
            var exe = $@"{main_path}\{n_read}";
            var f = $"{read_path}{R_Outfile.Text}{num_seq}{rext}";
            var inc = 0;
            if (NS.Checked)
            {
                while (File.Exists(f))
                {
                    ++inc;
                    num_seq = $"_{N_Scheme.Value + inc}";
                    f = $"{read_path}{R_Outfile.Text}{num_seq}{rext}";
                }
            }
            var outfile = args + " \"" + f + "\"";
            //this.Text = $"{exe}{outfile} {inc}";
            //Thread.Sleep(4000) ;
            ProcessStartInfo procStartInfo = new ProcessStartInfo(exe, outfile)
            {
                RedirectStandardError = false,
                RedirectStandardOutput = false,
                UseShellExecute = false,
                CreateNoWindow = false,

            };
            Process process = new Process
            {
                StartInfo = procStartInfo
            };
            try
            {
                process.Start();
                process.WaitForExit();
                // Rudimentary way of checking if Nibread succeeded by checking if the ouptut file exists and comparing its
                // creation date/time to the current date/time with a tollerance of 60 seconds
                // Nibtools-GUI cannot currently get the error-state of a program run in a shell process
                if (System.IO.File.Exists(f))
                {
                    DateTime n = DateTime.Now;                       // <-- Current date/time
                    DateTime s = System.IO.File.GetCreationTime(f);  // <-- file creation date/time
                    TimeSpan d = (n - s);                            // <-- time elapsed since the file was created
                    if (d.TotalSeconds <= 60)                        // <-- (set tollerance value in seconds) 
                    {
                        if (NS.Checked)
                        {
                            N_Scheme.Value += (inc + 1);
                        }
                        GetDirContent(read_path);
                    }
                    else MessageForYouSir(t, m + q);
                }
                else MessageForYouSir(t, m);
            }
            catch { }

            void Get_ReadArgs()
            {
                if (R_Devnum.Checked) args += $"-D{Dev_num.Value} ";
                if (T_override.Checked) args += $"-S{S_track.Value} -E{E_track.Value} ";
                if (Parallel.Checked) args += "-P ";
                if (DR_killer.Checked) args += "-k ";
                if (FD_density.Checked) args += "-d ";
                if (ET_matching.Checked) args += "-v ";
                if (II_mode.Checked) args += "-I ";
                if (VB_output.Checked) args += "-V ";
                if (R_halftracks.Checked) args += "-h ";
                if (EP_tests.Checked) args += "-t ";
                if (U_sensor.Checked) args += "-j ";
                if (U_alignment.Checked) args += "-x ";
                if (U_bitrate.Checked) args += "-y ";
                if (U_test.Checked) args += "-z ";
                if (Read_tgap.Checked) args += $"-G{R_tgap.Value} ";
            }
        }

        private void R_Browse_Click(object sender, EventArgs e)
        {
            var previous = read_path;
            var p = folderBrowserDialog1.ShowDialog(this);
            if (p == DialogResult.OK)
            {
                read_path = $@"{folderBrowserDialog1.SelectedPath}\";
            }
            else read_path = previous;
            toolTip1.SetToolTip(this.R_Path, read_path);
            ntkey.SetValue("ReadOutputPath", read_path);
            R_Path.Text = $"Output Folder [ {Trunc(true, read_path, 30)} ]";
            GetDirContent(read_path);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            char[] invalidChars = Path.GetInvalidFileNameChars();
            R_Outfile.Text = string.Join("", R_Outfile.Text.Split(invalidChars));
            R_Outfile.SelectionStart = R_Outfile.Text.Length + 1;
            read_name = R_Outfile.Text;
            if (read_name == "") Read_Start.Enabled = false; else Read_Start.Enabled = true;
            SetReadOutputFileName();
        }
       
        private void ListBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                R_Outfile.Text = Path.GetFileNameWithoutExtension(listBox2.SelectedItem.ToString());
            }
        }
       
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                this.Text = "Closing..";
                Application.Exit();
                Environment.Exit(0);
            }
            catch { }
            this.Close();
        }

        private void R_Path_Click(object sender, EventArgs e)
        {
            if (read_path != null)
            {
                if (read_path.Length != 0)
                {
                    string filePath = read_path;
                    if (!System.IO.Directory.Exists(filePath))
                    {
                        return;
                    }
                    string argument = "/open, \"" + filePath;//+ "\"";
                    Process.Start("explorer.exe", argument);
                }
            }
        }
        private void NS_CheckedChanged(object sender, EventArgs e)
        {
            N_Scheme.Enabled = NS.Checked;
            if (NS.Checked) num_seq = $"_{N_Scheme.Value}"; else num_seq = "";
            SetReadOutputFileName();
        }

        private void N_Scheme_ValueChanged(object sender, EventArgs e)
        {
            if (NS.Checked) num_seq = $"_{N_Scheme.Value}"; else num_seq = "";
            SetReadOutputFileName();
        }

        private void Read_tgap_CheckedChanged(object sender, EventArgs e)
        {
            R_tgap.Enabled = Read_tgap.Checked;
        }
        private void Bad_GCR_CheckedChanged(object sender, EventArgs e)
        {
            if (Bad_GCR.Checked) Agg_Gcr.Checked = false;
        }

        private void Agg_Gcr_CheckedChanged(object sender, EventArgs e)
        {
            if (Agg_Gcr.Checked) Bad_GCR.Checked = false;
            Ag_Gcr.Enabled = Agg_Gcr.Checked;
        }

        private void Over_Write_CheckedChanged(object sender, EventArgs e)
        {
            overwrite = Over_Write.Checked;
        }

        private void R_NIB_CheckedChanged(object sender, EventArgs e)
        {
            rext = ".nib";
            GetDirContent(read_path);
        }

        private void R_NBZ_CheckedChanged(object sender, EventArgs e)
        {
            rext = ".nbz";
            GetDirContent(read_path);
        }
        private void R_G64_CheckedChanged(object sender, EventArgs e)
        {
            rext = ".g64";
            GetDirContent(read_path);
        }

        private void R_D64_CheckedChanged(object sender, EventArgs e)
        {
            rext = ".d64";
            GetDirContent(read_path);
        }
        private void Parallel_CheckedChanged(object sender, EventArgs e)
        {
            ntkey.SetValue("ParallelTransfer", Parallel.Checked);
        }

        private void R_Devnum_CheckedChanged(object sender, EventArgs e)
        {
            Dev_num.Enabled = R_Devnum.Checked;
        }

        private void Track_override_CheckedChanged(object sender, EventArgs e)
        {
            S_track.Enabled = E_track.Enabled = T_override.Checked;
        }

        private void End_track_ValueChanged(object sender, EventArgs e)
        {
            if (E_track.Value < S_track.Value) { S_track.Value = E_track.Value; }
        }

        private void Start_track_ValueChanged(object sender, EventArgs e)
        {
            if (S_track.Value > E_track.Value) { E_track.Value = S_track.Value; }
        }
        private void IHS_CheckedChanged(object sender, EventArgs e)
        {
            U_test.Enabled = U_sensor.Enabled = U_bitrate.Enabled = U_alignment.Enabled = IHS.Checked;
        }
    }
}
