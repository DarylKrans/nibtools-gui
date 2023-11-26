using System.Text.RegularExpressions;

namespace nibtools_gui
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Nibconv = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rel_path = new System.Windows.Forms.CheckBox();
            this.Over_Write = new System.Windows.Forms.CheckBox();
            this.Conv_proc = new System.Windows.Forms.Label();
            this.A_Opts = new System.Windows.Forms.GroupBox();
            this.G_len = new System.Windows.Forms.NumericUpDown();
            this.Gm_Len = new System.Windows.Forms.CheckBox();
            this.Ag_Gcr = new System.Windows.Forms.NumericUpDown();
            this.Agg_Gcr = new System.Windows.Forms.CheckBox();
            this.T_align = new System.Windows.Forms.ComboBox();
            this.A_Align = new System.Windows.Forms.CheckBox();
            this.RPM = new System.Windows.Forms.NumericUpDown();
            this.S_Rpm = new System.Windows.Forms.CheckBox();
            this.P_handler = new System.Windows.Forms.ComboBox();
            this.Prot = new System.Windows.Forms.CheckBox();
            this.Skew = new System.Windows.Forms.CheckBox();
            this.t_skew = new System.Windows.Forms.NumericUpDown();
            this.Bad_GCR = new System.Windows.Forms.CheckBox();
            this.Sync = new System.Windows.Forms.CheckBox();
            this.GCR = new System.Windows.Forms.CheckBox();
            this.Gap = new System.Windows.Forms.CheckBox();
            this.Adv_opts = new System.Windows.Forms.CheckBox();
            this.Conv_Start = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.Out_Folder = new System.Windows.Forms.Label();
            this.Matching_Files = new System.Windows.Forms.Label();
            this.Total_Files = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Out_Box = new System.Windows.Forms.GroupBox();
            this.O_NBZ = new System.Windows.Forms.RadioButton();
            this.O_NIB = new System.Windows.Forms.RadioButton();
            this.O_D64 = new System.Windows.Forms.RadioButton();
            this.O_G64 = new System.Windows.Forms.RadioButton();
            this.Source_box = new System.Windows.Forms.GroupBox();
            this.S_D64 = new System.Windows.Forms.RadioButton();
            this.S_G64 = new System.Windows.Forms.RadioButton();
            this.S_NBZ = new System.Windows.Forms.RadioButton();
            this.S_NIB = new System.Windows.Forms.RadioButton();
            this.Nibread = new System.Windows.Forms.TabPage();
            this.R_adv = new System.Windows.Forms.GroupBox();
            this.R_halftracks = new System.Windows.Forms.CheckBox();
            this.DR_killer = new System.Windows.Forms.CheckBox();
            this.FD_density = new System.Windows.Forms.CheckBox();
            this.R_tgap = new System.Windows.Forms.NumericUpDown();
            this.ET_matching = new System.Windows.Forms.CheckBox();
            this.Read_tgap = new System.Windows.Forms.CheckBox();
            this.II_mode = new System.Windows.Forms.CheckBox();
            this.EP_tests = new System.Windows.Forms.CheckBox();
            this.U_sensor = new System.Windows.Forms.CheckBox();
            this.U_alignment = new System.Windows.Forms.CheckBox();
            this.U_bitrate = new System.Windows.Forms.CheckBox();
            this.U_test = new System.Windows.Forms.CheckBox();
            this.IHS = new System.Windows.Forms.CheckBox();
            this.R_advanced = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.R_limit = new System.Windows.Forms.CheckBox();
            this.R_Devnum = new System.Windows.Forms.CheckBox();
            this.Dev_num = new System.Windows.Forms.NumericUpDown();
            this.Parallel = new System.Windows.Forms.CheckBox();
            this.T_override = new System.Windows.Forms.CheckBox();
            this.S_track = new System.Windows.Forms.NumericUpDown();
            this.E_track = new System.Windows.Forms.NumericUpDown();
            this.N_Scheme = new System.Windows.Forms.NumericUpDown();
            this.NS = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.r_current = new System.Windows.Forms.Label();
            this.VB_output = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.r_ext = new System.Windows.Forms.Label();
            this.R_Outfile = new System.Windows.Forms.TextBox();
            this.R_Browse = new System.Windows.Forms.Button();
            this.R_Path = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Read_Start = new System.Windows.Forms.Button();
            this.Read_out = new System.Windows.Forms.GroupBox();
            this.R_NBZ = new System.Windows.Forms.RadioButton();
            this.R_NIB = new System.Windows.Forms.RadioButton();
            this.Nibwrite = new System.Windows.Forms.TabPage();
            this.WAdv = new System.Windows.Forms.CheckBox();
            this.W_advopts = new System.Windows.Forms.GroupBox();
            this.W_cap = new System.Windows.Forms.NumericUpDown();
            this.W_capmar = new System.Windows.Forms.CheckBox();
            this.W_autobad = new System.Windows.Forms.CheckBox();
            this.W_agg = new System.Windows.Forms.NumericUpDown();
            this.W_aggcr = new System.Windows.Forms.CheckBox();
            this.W_tgap = new System.Windows.Forms.NumericUpDown();
            this.W_timedalign = new System.Windows.Forms.CheckBox();
            this.W_rpm = new System.Windows.Forms.NumericUpDown();
            this.W_gapmatch = new System.Windows.Forms.CheckBox();
            this.W_capacity = new System.Windows.Forms.CheckBox();
            this.Wrpm = new System.Windows.Forms.CheckBox();
            this.W_gapreduce = new System.Windows.Forms.CheckBox();
            this.W_skew = new System.Windows.Forms.CheckBox();
            this.W_gcrrunred = new System.Windows.Forms.CheckBox();
            this.W_tskew = new System.Windows.Forms.NumericUpDown();
            this.W_syncred = new System.Windows.Forms.CheckBox();
            this.W_align = new System.Windows.Forms.ComboBox();
            this.WTA = new System.Windows.Forms.CheckBox();
            this.W_prot = new System.Windows.Forms.ComboBox();
            this.WP = new System.Windows.Forms.CheckBox();
            this.Zero_Disk = new System.Windows.Forms.Button();
            this.W_verb = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.W_limit = new System.Windows.Forms.CheckBox();
            this.W_dev = new System.Windows.Forms.CheckBox();
            this.W_num = new System.Windows.Forms.NumericUpDown();
            this.WParallel = new System.Windows.Forms.CheckBox();
            this.W_override = new System.Windows.Forms.CheckBox();
            this.W_start = new System.Windows.Forms.NumericUpDown();
            this.W_end = new System.Windows.Forms.NumericUpDown();
            this.Write_Clear = new System.Windows.Forms.Button();
            this.wtotal = new System.Windows.Forms.Label();
            this.wsb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wfn = new System.Windows.Forms.TextBox();
            this.Write_Start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Tabs.SuspendLayout();
            this.Nibconv.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.A_Opts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G_len)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ag_Gcr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_skew)).BeginInit();
            this.Out_Box.SuspendLayout();
            this.Source_box.SuspendLayout();
            this.Nibread.SuspendLayout();
            this.R_adv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R_tgap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dev_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_Scheme)).BeginInit();
            this.Read_out.SuspendLayout();
            this.Nibwrite.SuspendLayout();
            this.W_advopts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.W_cap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_agg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_tgap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_rpm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_tskew)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.W_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_end)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Nibconv);
            this.Tabs.Controls.Add(this.Nibread);
            this.Tabs.Controls.Add(this.Nibwrite);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1306, 901);
            this.Tabs.TabIndex = 2;
            // 
            // Nibconv
            // 
            this.Nibconv.Controls.Add(this.groupBox3);
            this.Nibconv.Controls.Add(this.Conv_proc);
            this.Nibconv.Controls.Add(this.A_Opts);
            this.Nibconv.Controls.Add(this.Adv_opts);
            this.Nibconv.Controls.Add(this.Conv_Start);
            this.Nibconv.Controls.Add(this.browse);
            this.Nibconv.Controls.Add(this.Out_Folder);
            this.Nibconv.Controls.Add(this.Matching_Files);
            this.Nibconv.Controls.Add(this.Total_Files);
            this.Nibconv.Controls.Add(this.listBox1);
            this.Nibconv.Controls.Add(this.Out_Box);
            this.Nibconv.Controls.Add(this.Source_box);
            this.Nibconv.Location = new System.Drawing.Point(8, 39);
            this.Nibconv.Name = "Nibconv";
            this.Nibconv.Padding = new System.Windows.Forms.Padding(3);
            this.Nibconv.Size = new System.Drawing.Size(1290, 854);
            this.Nibconv.TabIndex = 0;
            this.Nibconv.Text = "Convert";
            this.Nibconv.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rel_path);
            this.groupBox3.Controls.Add(this.Over_Write);
            this.groupBox3.Location = new System.Drawing.Point(12, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 119);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output Files";
            // 
            // rel_path
            // 
            this.rel_path.AutoSize = true;
            this.rel_path.Location = new System.Drawing.Point(6, 38);
            this.rel_path.Name = "rel_path";
            this.rel_path.Size = new System.Drawing.Size(312, 29);
            this.rel_path.TabIndex = 10;
            this.rel_path.Text = "Preserver relative file paths ";
            this.rel_path.UseVisualStyleBackColor = true;
            this.rel_path.CheckedChanged += new System.EventHandler(this.Rel_path_CheckedChanged);
            // 
            // Over_Write
            // 
            this.Over_Write.AutoSize = true;
            this.Over_Write.Location = new System.Drawing.Point(6, 73);
            this.Over_Write.Name = "Over_Write";
            this.Over_Write.Size = new System.Drawing.Size(260, 29);
            this.Over_Write.TabIndex = 15;
            this.Over_Write.Text = "Overwrite existing files";
            this.Over_Write.UseVisualStyleBackColor = true;
            this.Over_Write.CheckedChanged += new System.EventHandler(this.Over_Write_CheckedChanged);
            // 
            // Conv_proc
            // 
            this.Conv_proc.AutoSize = true;
            this.Conv_proc.Location = new System.Drawing.Point(872, 815);
            this.Conv_proc.Name = "Conv_proc";
            this.Conv_proc.Size = new System.Drawing.Size(70, 25);
            this.Conv_proc.TabIndex = 16;
            this.Conv_proc.Text = "label1";
            this.Conv_proc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // A_Opts
            // 
            this.A_Opts.Controls.Add(this.G_len);
            this.A_Opts.Controls.Add(this.Gm_Len);
            this.A_Opts.Controls.Add(this.Ag_Gcr);
            this.A_Opts.Controls.Add(this.Agg_Gcr);
            this.A_Opts.Controls.Add(this.T_align);
            this.A_Opts.Controls.Add(this.A_Align);
            this.A_Opts.Controls.Add(this.RPM);
            this.A_Opts.Controls.Add(this.S_Rpm);
            this.A_Opts.Controls.Add(this.P_handler);
            this.A_Opts.Controls.Add(this.Prot);
            this.A_Opts.Controls.Add(this.Skew);
            this.A_Opts.Controls.Add(this.t_skew);
            this.A_Opts.Controls.Add(this.Bad_GCR);
            this.A_Opts.Controls.Add(this.Sync);
            this.A_Opts.Controls.Add(this.GCR);
            this.A_Opts.Controls.Add(this.Gap);
            this.A_Opts.Location = new System.Drawing.Point(380, 3);
            this.A_Opts.Name = "A_Opts";
            this.A_Opts.Size = new System.Drawing.Size(908, 261);
            this.A_Opts.TabIndex = 13;
            this.A_Opts.TabStop = false;
            this.A_Opts.Text = "Advanced Options";
            // 
            // G_len
            // 
            this.G_len.Location = new System.Drawing.Point(769, 100);
            this.G_len.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.G_len.Name = "G_len";
            this.G_len.Size = new System.Drawing.Size(120, 31);
            this.G_len.TabIndex = 15;
            this.G_len.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Gm_Len
            // 
            this.Gm_Len.AutoSize = true;
            this.Gm_Len.Location = new System.Drawing.Point(408, 102);
            this.Gm_Len.Name = "Gm_Len";
            this.Gm_Len.Size = new System.Drawing.Size(301, 29);
            this.Gm_Len.TabIndex = 14;
            this.Gm_Len.Text = "Alternate gap match length";
            this.Gm_Len.UseVisualStyleBackColor = true;
            this.Gm_Len.CheckedChanged += new System.EventHandler(this.Adv_opts_CheckedChanged);
            // 
            // Ag_Gcr
            // 
            this.Ag_Gcr.Location = new System.Drawing.Point(769, 63);
            this.Ag_Gcr.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Ag_Gcr.Name = "Ag_Gcr";
            this.Ag_Gcr.Size = new System.Drawing.Size(120, 31);
            this.Ag_Gcr.TabIndex = 13;
            // 
            // Agg_Gcr
            // 
            this.Agg_Gcr.AutoSize = true;
            this.Agg_Gcr.Location = new System.Drawing.Point(408, 65);
            this.Agg_Gcr.Name = "Agg_Gcr";
            this.Agg_Gcr.Size = new System.Drawing.Size(348, 29);
            this.Agg_Gcr.TabIndex = 12;
            this.Agg_Gcr.Text = "Aggressive bad GCR simulation";
            this.Agg_Gcr.UseVisualStyleBackColor = true;
            this.Agg_Gcr.CheckedChanged += new System.EventHandler(this.Agg_Gcr_CheckedChanged);
            // 
            // T_align
            // 
            this.T_align.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.T_align.FormattingEnabled = true;
            this.T_align.Location = new System.Drawing.Point(408, 179);
            this.T_align.Name = "T_align";
            this.T_align.Size = new System.Drawing.Size(348, 33);
            this.T_align.TabIndex = 11;
            // 
            // A_Align
            // 
            this.A_Align.AutoSize = true;
            this.A_Align.Location = new System.Drawing.Point(6, 183);
            this.A_Align.Name = "A_Align";
            this.A_Align.Size = new System.Drawing.Size(309, 29);
            this.A_Align.TabIndex = 10;
            this.A_Align.Text = "Alternative track alignments";
            this.A_Align.UseVisualStyleBackColor = true;
            this.A_Align.CheckedChanged += new System.EventHandler(this.Adv_opts_CheckedChanged);
            // 
            // RPM
            // 
            this.RPM.Location = new System.Drawing.Point(769, 134);
            this.RPM.Maximum = new decimal(new int[] {
            340,
            0,
            0,
            0});
            this.RPM.Minimum = new decimal(new int[] {
            260,
            0,
            0,
            0});
            this.RPM.Name = "RPM";
            this.RPM.Size = new System.Drawing.Size(120, 31);
            this.RPM.TabIndex = 9;
            this.RPM.Value = new decimal(new int[] {
            260,
            0,
            0,
            0});
            // 
            // S_Rpm
            // 
            this.S_Rpm.AutoSize = true;
            this.S_Rpm.Location = new System.Drawing.Point(408, 138);
            this.S_Rpm.Name = "S_Rpm";
            this.S_Rpm.Size = new System.Drawing.Size(333, 29);
            this.S_Rpm.TabIndex = 8;
            this.S_Rpm.Text = "Simulate track capacity (RPM)";
            this.S_Rpm.UseVisualStyleBackColor = true;
            this.S_Rpm.CheckedChanged += new System.EventHandler(this.Adv_opts_CheckedChanged);
            // 
            // P_handler
            // 
            this.P_handler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.P_handler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.P_handler.FormattingEnabled = true;
            this.P_handler.Location = new System.Drawing.Point(408, 216);
            this.P_handler.Name = "P_handler";
            this.P_handler.Size = new System.Drawing.Size(348, 33);
            this.P_handler.TabIndex = 7;
            // 
            // Prot
            // 
            this.Prot.AutoSize = true;
            this.Prot.Location = new System.Drawing.Point(6, 218);
            this.Prot.Name = "Prot";
            this.Prot.Size = new System.Drawing.Size(296, 29);
            this.Prot.TabIndex = 6;
            this.Prot.Text = "Custom protection handler";
            this.Prot.UseVisualStyleBackColor = true;
            this.Prot.CheckedChanged += new System.EventHandler(this.Adv_opts_CheckedChanged);
            // 
            // Skew
            // 
            this.Skew.AutoSize = true;
            this.Skew.Location = new System.Drawing.Point(408, 30);
            this.Skew.Name = "Skew";
            this.Skew.Size = new System.Drawing.Size(156, 29);
            this.Skew.TabIndex = 5;
            this.Skew.Text = "Track Skew";
            this.Skew.UseVisualStyleBackColor = true;
            this.Skew.CheckedChanged += new System.EventHandler(this.Adv_opts_CheckedChanged);
            // 
            // t_skew
            // 
            this.t_skew.Location = new System.Drawing.Point(769, 28);
            this.t_skew.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.t_skew.Name = "t_skew";
            this.t_skew.Size = new System.Drawing.Size(120, 31);
            this.t_skew.TabIndex = 4;
            // 
            // Bad_GCR
            // 
            this.Bad_GCR.AutoSize = true;
            this.Bad_GCR.Location = new System.Drawing.Point(6, 148);
            this.Bad_GCR.Name = "Bad_GCR";
            this.Bad_GCR.Size = new System.Drawing.Size(361, 29);
            this.Bad_GCR.TabIndex = 3;
            this.Bad_GCR.Text = "Disable auto bad GCR simulation";
            this.Bad_GCR.UseVisualStyleBackColor = true;
            this.Bad_GCR.CheckedChanged += new System.EventHandler(this.Bad_GCR_CheckedChanged);
            // 
            // Sync
            // 
            this.Sync.AutoSize = true;
            this.Sync.Location = new System.Drawing.Point(6, 111);
            this.Sync.Name = "Sync";
            this.Sync.Size = new System.Drawing.Size(310, 29);
            this.Sync.TabIndex = 2;
            this.Sync.Text = "Disable auto sync reduction";
            this.Sync.UseVisualStyleBackColor = true;
            // 
            // GCR
            // 
            this.GCR.AutoSize = true;
            this.GCR.Location = new System.Drawing.Point(6, 76);
            this.GCR.Name = "GCR";
            this.GCR.Size = new System.Drawing.Size(266, 29);
            this.GCR.TabIndex = 1;
            this.GCR.Text = "Bad GCR run reduction";
            this.GCR.UseVisualStyleBackColor = true;
            // 
            // Gap
            // 
            this.Gap.AutoSize = true;
            this.Gap.Location = new System.Drawing.Point(6, 41);
            this.Gap.Name = "Gap";
            this.Gap.Size = new System.Drawing.Size(248, 29);
            this.Gap.TabIndex = 0;
            this.Gap.Text = "Enable gap reduction";
            this.Gap.UseVisualStyleBackColor = true;
            // 
            // Adv_opts
            // 
            this.Adv_opts.AutoSize = true;
            this.Adv_opts.Location = new System.Drawing.Point(1129, 273);
            this.Adv_opts.Name = "Adv_opts";
            this.Adv_opts.Size = new System.Drawing.Size(140, 29);
            this.Adv_opts.TabIndex = 12;
            this.Adv_opts.Text = "Advanced";
            this.Adv_opts.UseVisualStyleBackColor = true;
            this.Adv_opts.CheckedChanged += new System.EventHandler(this.Adv_opts_CheckedChanged);
            // 
            // Conv_Start
            // 
            this.Conv_Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Conv_Start.Location = new System.Drawing.Point(380, 268);
            this.Conv_Start.Name = "Conv_Start";
            this.Conv_Start.Size = new System.Drawing.Size(107, 37);
            this.Conv_Start.TabIndex = 11;
            this.Conv_Start.Text = "Convert";
            this.Conv_Start.UseVisualStyleBackColor = true;
            this.Conv_Start.Click += new System.EventHandler(this.Conv_Start_Click);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.LightGray;
            this.browse.BackgroundImage = global::nibtools_gui.Properties.Resources.browse;
            this.browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.browse.Location = new System.Drawing.Point(18, 345);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(39, 30);
            this.browse.TabIndex = 9;
            this.browse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Out_Folder
            // 
            this.Out_Folder.AutoSize = true;
            this.Out_Folder.Location = new System.Drawing.Point(63, 350);
            this.Out_Folder.Name = "Out_Folder";
            this.Out_Folder.Size = new System.Drawing.Size(143, 25);
            this.Out_Folder.TabIndex = 8;
            this.Out_Folder.Text = "Output Folder";
            this.Out_Folder.Click += new System.EventHandler(this.Out_FolderClick);
            // 
            // Matching_Files
            // 
            this.Matching_Files.AutoSize = true;
            this.Matching_Files.Location = new System.Drawing.Point(431, 815);
            this.Matching_Files.Name = "Matching_Files";
            this.Matching_Files.Size = new System.Drawing.Size(151, 25);
            this.Matching_Files.TabIndex = 6;
            this.Matching_Files.Text = "This is a label!";
            // 
            // Total_Files
            // 
            this.Total_Files.AutoSize = true;
            this.Total_Files.Location = new System.Drawing.Point(6, 815);
            this.Total_Files.Name = "Total_Files";
            this.Total_Files.Size = new System.Drawing.Size(192, 25);
            this.Total_Files.TabIndex = 5;
            this.Total_Files.Text = "Total files selected";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(6, 381);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1282, 429);
            this.listBox1.TabIndex = 4;
            // 
            // Out_Box
            // 
            this.Out_Box.Controls.Add(this.O_NBZ);
            this.Out_Box.Controls.Add(this.O_NIB);
            this.Out_Box.Controls.Add(this.O_D64);
            this.Out_Box.Controls.Add(this.O_G64);
            this.Out_Box.Location = new System.Drawing.Point(201, 3);
            this.Out_Box.Name = "Out_Box";
            this.Out_Box.Size = new System.Drawing.Size(173, 176);
            this.Out_Box.TabIndex = 3;
            this.Out_Box.TabStop = false;
            this.Out_Box.Text = "Output Type";
            // 
            // O_NBZ
            // 
            this.O_NBZ.AutoSize = true;
            this.O_NBZ.Location = new System.Drawing.Point(6, 135);
            this.O_NBZ.Name = "O_NBZ";
            this.O_NBZ.Size = new System.Drawing.Size(85, 29);
            this.O_NBZ.TabIndex = 3;
            this.O_NBZ.TabStop = true;
            this.O_NBZ.Text = "NBZ";
            this.O_NBZ.UseVisualStyleBackColor = true;
            this.O_NBZ.CheckedChanged += new System.EventHandler(this.O_G64_CheckedChanged);
            // 
            // O_NIB
            // 
            this.O_NIB.AutoSize = true;
            this.O_NIB.Location = new System.Drawing.Point(6, 100);
            this.O_NIB.Name = "O_NIB";
            this.O_NIB.Size = new System.Drawing.Size(77, 29);
            this.O_NIB.TabIndex = 2;
            this.O_NIB.TabStop = true;
            this.O_NIB.Text = "NIB";
            this.O_NIB.UseVisualStyleBackColor = true;
            this.O_NIB.CheckedChanged += new System.EventHandler(this.O_G64_CheckedChanged);
            // 
            // O_D64
            // 
            this.O_D64.AutoSize = true;
            this.O_D64.Location = new System.Drawing.Point(6, 65);
            this.O_D64.Name = "O_D64";
            this.O_D64.Size = new System.Drawing.Size(82, 29);
            this.O_D64.TabIndex = 1;
            this.O_D64.TabStop = true;
            this.O_D64.Text = "D64";
            this.O_D64.UseVisualStyleBackColor = true;
            this.O_D64.CheckedChanged += new System.EventHandler(this.O_G64_CheckedChanged);
            // 
            // O_G64
            // 
            this.O_G64.AutoSize = true;
            this.O_G64.Location = new System.Drawing.Point(6, 30);
            this.O_G64.Name = "O_G64";
            this.O_G64.Size = new System.Drawing.Size(83, 29);
            this.O_G64.TabIndex = 0;
            this.O_G64.TabStop = true;
            this.O_G64.Text = "G64";
            this.O_G64.UseVisualStyleBackColor = true;
            this.O_G64.CheckedChanged += new System.EventHandler(this.O_G64_CheckedChanged);
            // 
            // Source_box
            // 
            this.Source_box.Controls.Add(this.S_D64);
            this.Source_box.Controls.Add(this.S_G64);
            this.Source_box.Controls.Add(this.S_NBZ);
            this.Source_box.Controls.Add(this.S_NIB);
            this.Source_box.Location = new System.Drawing.Point(12, 3);
            this.Source_box.Name = "Source_box";
            this.Source_box.Size = new System.Drawing.Size(183, 176);
            this.Source_box.TabIndex = 2;
            this.Source_box.TabStop = false;
            this.Source_box.Text = "Source Type";
            // 
            // S_D64
            // 
            this.S_D64.AutoSize = true;
            this.S_D64.Location = new System.Drawing.Point(6, 135);
            this.S_D64.Name = "S_D64";
            this.S_D64.Size = new System.Drawing.Size(82, 29);
            this.S_D64.TabIndex = 3;
            this.S_D64.TabStop = true;
            this.S_D64.Text = "D64";
            this.S_D64.UseVisualStyleBackColor = true;
            this.S_D64.CheckedChanged += new System.EventHandler(this.D64_CheckedChanged);
            // 
            // S_G64
            // 
            this.S_G64.AutoSize = true;
            this.S_G64.Location = new System.Drawing.Point(6, 100);
            this.S_G64.Name = "S_G64";
            this.S_G64.Size = new System.Drawing.Size(83, 29);
            this.S_G64.TabIndex = 2;
            this.S_G64.TabStop = true;
            this.S_G64.Text = "G64";
            this.S_G64.UseVisualStyleBackColor = true;
            this.S_G64.CheckedChanged += new System.EventHandler(this.G64_CheckedChanged);
            // 
            // S_NBZ
            // 
            this.S_NBZ.AutoSize = true;
            this.S_NBZ.Location = new System.Drawing.Point(6, 65);
            this.S_NBZ.Name = "S_NBZ";
            this.S_NBZ.Size = new System.Drawing.Size(85, 29);
            this.S_NBZ.TabIndex = 1;
            this.S_NBZ.TabStop = true;
            this.S_NBZ.Text = "NBZ";
            this.S_NBZ.UseVisualStyleBackColor = true;
            this.S_NBZ.CheckedChanged += new System.EventHandler(this.NBZ_CheckedChanged);
            // 
            // S_NIB
            // 
            this.S_NIB.AutoSize = true;
            this.S_NIB.Location = new System.Drawing.Point(6, 30);
            this.S_NIB.Name = "S_NIB";
            this.S_NIB.Size = new System.Drawing.Size(77, 29);
            this.S_NIB.TabIndex = 0;
            this.S_NIB.TabStop = true;
            this.S_NIB.Text = "NIB";
            this.S_NIB.UseVisualStyleBackColor = true;
            this.S_NIB.CheckedChanged += new System.EventHandler(this.NIB_CheckedChanged);
            // 
            // Nibread
            // 
            this.Nibread.Controls.Add(this.R_adv);
            this.Nibread.Controls.Add(this.R_advanced);
            this.Nibread.Controls.Add(this.groupBox1);
            this.Nibread.Controls.Add(this.N_Scheme);
            this.Nibread.Controls.Add(this.NS);
            this.Nibread.Controls.Add(this.label3);
            this.Nibread.Controls.Add(this.label2);
            this.Nibread.Controls.Add(this.r_current);
            this.Nibread.Controls.Add(this.VB_output);
            this.Nibread.Controls.Add(this.label1);
            this.Nibread.Controls.Add(this.r_ext);
            this.Nibread.Controls.Add(this.R_Outfile);
            this.Nibread.Controls.Add(this.R_Browse);
            this.Nibread.Controls.Add(this.R_Path);
            this.Nibread.Controls.Add(this.listBox2);
            this.Nibread.Controls.Add(this.Read_Start);
            this.Nibread.Controls.Add(this.Read_out);
            this.Nibread.Location = new System.Drawing.Point(8, 39);
            this.Nibread.Name = "Nibread";
            this.Nibread.Padding = new System.Windows.Forms.Padding(3);
            this.Nibread.Size = new System.Drawing.Size(1290, 854);
            this.Nibread.TabIndex = 1;
            this.Nibread.Text = "Read Disk Image";
            this.Nibread.UseVisualStyleBackColor = true;
            // 
            // R_adv
            // 
            this.R_adv.Controls.Add(this.R_halftracks);
            this.R_adv.Controls.Add(this.DR_killer);
            this.R_adv.Controls.Add(this.FD_density);
            this.R_adv.Controls.Add(this.R_tgap);
            this.R_adv.Controls.Add(this.ET_matching);
            this.R_adv.Controls.Add(this.Read_tgap);
            this.R_adv.Controls.Add(this.II_mode);
            this.R_adv.Controls.Add(this.EP_tests);
            this.R_adv.Controls.Add(this.U_sensor);
            this.R_adv.Controls.Add(this.U_alignment);
            this.R_adv.Controls.Add(this.U_bitrate);
            this.R_adv.Controls.Add(this.U_test);
            this.R_adv.Controls.Add(this.IHS);
            this.R_adv.Location = new System.Drawing.Point(550, 3);
            this.R_adv.Name = "R_adv";
            this.R_adv.Size = new System.Drawing.Size(738, 265);
            this.R_adv.TabIndex = 49;
            this.R_adv.TabStop = false;
            this.R_adv.Text = "Advanced Options";
            // 
            // R_halftracks
            // 
            this.R_halftracks.AutoSize = true;
            this.R_halftracks.Location = new System.Drawing.Point(11, 42);
            this.R_halftracks.Name = "R_halftracks";
            this.R_halftracks.Size = new System.Drawing.Size(201, 29);
            this.R_halftracks.TabIndex = 33;
            this.R_halftracks.Text = "Read half-tracks";
            this.R_halftracks.UseVisualStyleBackColor = true;
            // 
            // DR_killer
            // 
            this.DR_killer.AutoSize = true;
            this.DR_killer.Location = new System.Drawing.Point(323, 77);
            this.DR_killer.Name = "DR_killer";
            this.DR_killer.Size = new System.Drawing.Size(347, 29);
            this.DR_killer.TabIndex = 28;
            this.DR_killer.Text = "Disable reading of \'killer\' tracks ";
            this.DR_killer.UseVisualStyleBackColor = true;
            // 
            // FD_density
            // 
            this.FD_density.AutoSize = true;
            this.FD_density.Location = new System.Drawing.Point(11, 77);
            this.FD_density.Name = "FD_density";
            this.FD_density.Size = new System.Drawing.Size(262, 29);
            this.FD_density.TabIndex = 29;
            this.FD_density.Text = "Force default densities";
            this.FD_density.UseVisualStyleBackColor = true;
            // 
            // R_tgap
            // 
            this.R_tgap.Location = new System.Drawing.Point(589, 41);
            this.R_tgap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.R_tgap.Name = "R_tgap";
            this.R_tgap.Size = new System.Drawing.Size(106, 31);
            this.R_tgap.TabIndex = 46;
            this.R_tgap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ET_matching
            // 
            this.ET_matching.AutoSize = true;
            this.ET_matching.Location = new System.Drawing.Point(11, 112);
            this.ET_matching.Name = "ET_matching";
            this.ET_matching.Size = new System.Drawing.Size(257, 29);
            this.ET_matching.TabIndex = 30;
            this.ET_matching.Text = "Enable track matching";
            this.ET_matching.UseVisualStyleBackColor = true;
            // 
            // Read_tgap
            // 
            this.Read_tgap.AutoSize = true;
            this.Read_tgap.Location = new System.Drawing.Point(323, 42);
            this.Read_tgap.Name = "Read_tgap";
            this.Read_tgap.Size = new System.Drawing.Size(253, 29);
            this.Read_tgap.TabIndex = 45;
            this.Read_tgap.Text = "Match track gap (adv)";
            this.Read_tgap.UseVisualStyleBackColor = true;
            this.Read_tgap.CheckedChanged += new System.EventHandler(this.Read_tgap_CheckedChanged);
            // 
            // II_mode
            // 
            this.II_mode.AutoSize = true;
            this.II_mode.Location = new System.Drawing.Point(11, 145);
            this.II_mode.Name = "II_mode";
            this.II_mode.Size = new System.Drawing.Size(283, 29);
            this.II_mode.TabIndex = 31;
            this.II_mode.Text = "Interactive imaging mode";
            this.II_mode.UseVisualStyleBackColor = true;
            // 
            // EP_tests
            // 
            this.EP_tests.AutoSize = true;
            this.EP_tests.Location = new System.Drawing.Point(11, 180);
            this.EP_tests.Name = "EP_tests";
            this.EP_tests.Size = new System.Drawing.Size(282, 29);
            this.EP_tests.TabIndex = 34;
            this.EP_tests.Text = "Extend parallel port tests";
            this.EP_tests.UseVisualStyleBackColor = true;
            // 
            // U_sensor
            // 
            this.U_sensor.AutoSize = true;
            this.U_sensor.Location = new System.Drawing.Point(323, 112);
            this.U_sensor.Name = "U_sensor";
            this.U_sensor.Size = new System.Drawing.Size(258, 29);
            this.U_sensor.TabIndex = 35;
            this.U_sensor.Text = "Use index hole sensor";
            this.U_sensor.UseVisualStyleBackColor = true;
            // 
            // U_alignment
            // 
            this.U_alignment.AutoSize = true;
            this.U_alignment.Location = new System.Drawing.Point(323, 145);
            this.U_alignment.Name = "U_alignment";
            this.U_alignment.Size = new System.Drawing.Size(259, 29);
            this.U_alignment.TabIndex = 36;
            this.U_alignment.Text = "Track alignment report";
            this.U_alignment.UseVisualStyleBackColor = true;
            // 
            // U_bitrate
            // 
            this.U_bitrate.AutoSize = true;
            this.U_bitrate.Location = new System.Drawing.Point(323, 180);
            this.U_bitrate.Name = "U_bitrate";
            this.U_bitrate.Size = new System.Drawing.Size(246, 29);
            this.U_bitrate.TabIndex = 37;
            this.U_bitrate.Text = "Deep bitrate analysis";
            this.U_bitrate.UseVisualStyleBackColor = true;
            // 
            // U_test
            // 
            this.U_test.AutoSize = true;
            this.U_test.Location = new System.Drawing.Point(323, 215);
            this.U_test.Name = "U_test";
            this.U_test.Size = new System.Drawing.Size(262, 29);
            this.U_test.TabIndex = 38;
            this.U_test.Text = "Test index hole sensor";
            this.U_test.UseVisualStyleBackColor = true;
            // 
            // IHS
            // 
            this.IHS.AutoSize = true;
            this.IHS.Location = new System.Drawing.Point(11, 215);
            this.IHS.Name = "IHS";
            this.IHS.Size = new System.Drawing.Size(279, 29);
            this.IHS.TabIndex = 39;
            this.IHS.Text = "Use SC+ compatible IHS";
            this.IHS.UseVisualStyleBackColor = true;
            this.IHS.CheckedChanged += new System.EventHandler(this.IHS_CheckedChanged);
            // 
            // R_advanced
            // 
            this.R_advanced.AutoSize = true;
            this.R_advanced.Location = new System.Drawing.Point(388, 141);
            this.R_advanced.Name = "R_advanced";
            this.R_advanced.Size = new System.Drawing.Size(140, 29);
            this.R_advanced.TabIndex = 48;
            this.R_advanced.Text = "Advanced";
            this.R_advanced.UseVisualStyleBackColor = true;
            this.R_advanced.CheckedChanged += new System.EventHandler(this.R_advanced_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.R_limit);
            this.groupBox1.Controls.Add(this.R_Devnum);
            this.groupBox1.Controls.Add(this.Dev_num);
            this.groupBox1.Controls.Add(this.Parallel);
            this.groupBox1.Controls.Add(this.T_override);
            this.groupBox1.Controls.Add(this.S_track);
            this.groupBox1.Controls.Add(this.E_track);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 179);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Settings";
            // 
            // R_limit
            // 
            this.R_limit.AutoSize = true;
            this.R_limit.Location = new System.Drawing.Point(185, 28);
            this.R_limit.Name = "R_limit";
            this.R_limit.Size = new System.Drawing.Size(153, 29);
            this.R_limit.TabIndex = 28;
            this.R_limit.Text = "Limit (T-40)";
            this.R_limit.UseVisualStyleBackColor = true;
            this.R_limit.CheckedChanged += new System.EventHandler(this.R_limit_CheckedChanged);
            // 
            // R_Devnum
            // 
            this.R_Devnum.AutoSize = true;
            this.R_Devnum.Location = new System.Drawing.Point(6, 30);
            this.R_Devnum.Name = "R_Devnum";
            this.R_Devnum.Size = new System.Drawing.Size(94, 29);
            this.R_Devnum.TabIndex = 24;
            this.R_Devnum.Text = "Drive";
            this.R_Devnum.UseVisualStyleBackColor = true;
            this.R_Devnum.CheckedChanged += new System.EventHandler(this.R_Devnum_CheckedChanged);
            // 
            // Dev_num
            // 
            this.Dev_num.Location = new System.Drawing.Point(106, 28);
            this.Dev_num.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.Dev_num.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Dev_num.Name = "Dev_num";
            this.Dev_num.Size = new System.Drawing.Size(73, 31);
            this.Dev_num.TabIndex = 23;
            this.Dev_num.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Parallel
            // 
            this.Parallel.AutoSize = true;
            this.Parallel.Location = new System.Drawing.Point(6, 138);
            this.Parallel.Name = "Parallel";
            this.Parallel.Size = new System.Drawing.Size(358, 29);
            this.Parallel.TabIndex = 22;
            this.Parallel.Text = "Use parallel Transfer (1571 only)";
            this.Parallel.UseVisualStyleBackColor = true;
            this.Parallel.CheckedChanged += new System.EventHandler(this.Parallel_CheckedChanged);
            // 
            // T_override
            // 
            this.T_override.AutoSize = true;
            this.T_override.Location = new System.Drawing.Point(6, 65);
            this.T_override.Name = "T_override";
            this.T_override.Size = new System.Drawing.Size(309, 29);
            this.T_override.TabIndex = 25;
            this.T_override.Text = "Override (Start) (End) Track";
            this.T_override.UseVisualStyleBackColor = true;
            this.T_override.CheckedChanged += new System.EventHandler(this.Track_override_CheckedChanged);
            // 
            // S_track
            // 
            this.S_track.Location = new System.Drawing.Point(122, 100);
            this.S_track.Maximum = new decimal(new int[] {
            41,
            0,
            0,
            0});
            this.S_track.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.S_track.Name = "S_track";
            this.S_track.Size = new System.Drawing.Size(74, 31);
            this.S_track.TabIndex = 26;
            this.S_track.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.S_track.ValueChanged += new System.EventHandler(this.Start_track_ValueChanged);
            // 
            // E_track
            // 
            this.E_track.Location = new System.Drawing.Point(202, 100);
            this.E_track.Maximum = new decimal(new int[] {
            41,
            0,
            0,
            0});
            this.E_track.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.E_track.Name = "E_track";
            this.E_track.Size = new System.Drawing.Size(75, 31);
            this.E_track.TabIndex = 27;
            this.E_track.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.E_track.ValueChanged += new System.EventHandler(this.End_track_ValueChanged);
            // 
            // N_Scheme
            // 
            this.N_Scheme.Location = new System.Drawing.Point(1114, 305);
            this.N_Scheme.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.N_Scheme.Name = "N_Scheme";
            this.N_Scheme.Size = new System.Drawing.Size(120, 31);
            this.N_Scheme.TabIndex = 44;
            this.N_Scheme.ValueChanged += new System.EventHandler(this.N_Scheme_ValueChanged);
            // 
            // NS
            // 
            this.NS.AutoSize = true;
            this.NS.Location = new System.Drawing.Point(834, 305);
            this.NS.Name = "NS";
            this.NS.Size = new System.Drawing.Size(270, 29);
            this.NS.TabIndex = 43;
            this.NS.Text = "Use numbering scheme";
            this.NS.UseVisualStyleBackColor = true;
            this.NS.CheckedChanged += new System.EventHandler(this.NS_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Output file name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 815);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(725, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "(double) click file to copy name (single) click folder to open location";
            // 
            // r_current
            // 
            this.r_current.AutoSize = true;
            this.r_current.Location = new System.Drawing.Point(6, 815);
            this.r_current.Name = "r_current";
            this.r_current.Size = new System.Drawing.Size(261, 25);
            this.r_current.TabIndex = 40;
            this.r_current.Text = "Total files in current folder";
            // 
            // VB_output
            // 
            this.VB_output.AutoSize = true;
            this.VB_output.Location = new System.Drawing.Point(208, 200);
            this.VB_output.Name = "VB_output";
            this.VB_output.Size = new System.Drawing.Size(124, 29);
            this.VB_output.TabIndex = 32;
            this.VB_output.Text = "Verbose";
            this.VB_output.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Destination file name";
            // 
            // r_ext
            // 
            this.r_ext.AutoSize = true;
            this.r_ext.Location = new System.Drawing.Point(771, 350);
            this.r_ext.Name = "r_ext";
            this.r_ext.Size = new System.Drawing.Size(70, 25);
            this.r_ext.TabIndex = 20;
            this.r_ext.Text = "label1";
            // 
            // R_Outfile
            // 
            this.R_Outfile.Location = new System.Drawing.Point(249, 302);
            this.R_Outfile.Name = "R_Outfile";
            this.R_Outfile.Size = new System.Drawing.Size(569, 31);
            this.R_Outfile.TabIndex = 19;
            this.R_Outfile.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // R_Browse
            // 
            this.R_Browse.BackColor = System.Drawing.Color.LightGray;
            this.R_Browse.BackgroundImage = global::nibtools_gui.Properties.Resources.browse;
            this.R_Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.R_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.R_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Browse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.R_Browse.Location = new System.Drawing.Point(14, 345);
            this.R_Browse.Name = "R_Browse";
            this.R_Browse.Size = new System.Drawing.Size(39, 30);
            this.R_Browse.TabIndex = 17;
            this.R_Browse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.R_Browse.UseVisualStyleBackColor = false;
            this.R_Browse.Click += new System.EventHandler(this.R_Browse_Click);
            // 
            // R_Path
            // 
            this.R_Path.AutoSize = true;
            this.R_Path.Location = new System.Drawing.Point(59, 350);
            this.R_Path.Name = "R_Path";
            this.R_Path.Size = new System.Drawing.Size(143, 25);
            this.R_Path.TabIndex = 16;
            this.R_Path.Text = "Output Folder";
            this.R_Path.Click += new System.EventHandler(this.R_Path_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(6, 381);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1282, 429);
            this.listBox2.TabIndex = 7;
            this.listBox2.DoubleClick += new System.EventHandler(this.ListBox2_DoubleClick);
            // 
            // Read_Start
            // 
            this.Read_Start.Location = new System.Drawing.Point(12, 195);
            this.Read_Start.Name = "Read_Start";
            this.Read_Start.Size = new System.Drawing.Size(173, 37);
            this.Read_Start.TabIndex = 6;
            this.Read_Start.Text = "Read Disk";
            this.Read_Start.UseVisualStyleBackColor = true;
            this.Read_Start.Click += new System.EventHandler(this.Read_Start_Click);
            // 
            // Read_out
            // 
            this.Read_out.Controls.Add(this.R_NBZ);
            this.Read_out.Controls.Add(this.R_NIB);
            this.Read_out.Location = new System.Drawing.Point(382, 3);
            this.Read_out.Name = "Read_out";
            this.Read_out.Size = new System.Drawing.Size(162, 105);
            this.Read_out.TabIndex = 4;
            this.Read_out.TabStop = false;
            this.Read_out.Text = "Output Type";
            // 
            // R_NBZ
            // 
            this.R_NBZ.AutoSize = true;
            this.R_NBZ.Location = new System.Drawing.Point(6, 65);
            this.R_NBZ.Name = "R_NBZ";
            this.R_NBZ.Size = new System.Drawing.Size(85, 29);
            this.R_NBZ.TabIndex = 3;
            this.R_NBZ.TabStop = true;
            this.R_NBZ.Text = "NBZ";
            this.R_NBZ.UseVisualStyleBackColor = true;
            this.R_NBZ.CheckedChanged += new System.EventHandler(this.R_NBZ_CheckedChanged);
            // 
            // R_NIB
            // 
            this.R_NIB.AutoSize = true;
            this.R_NIB.Location = new System.Drawing.Point(6, 30);
            this.R_NIB.Name = "R_NIB";
            this.R_NIB.Size = new System.Drawing.Size(77, 29);
            this.R_NIB.TabIndex = 2;
            this.R_NIB.TabStop = true;
            this.R_NIB.Text = "NIB";
            this.R_NIB.UseVisualStyleBackColor = true;
            this.R_NIB.CheckedChanged += new System.EventHandler(this.R_NIB_CheckedChanged);
            // 
            // Nibwrite
            // 
            this.Nibwrite.Controls.Add(this.WAdv);
            this.Nibwrite.Controls.Add(this.W_advopts);
            this.Nibwrite.Controls.Add(this.Zero_Disk);
            this.Nibwrite.Controls.Add(this.W_verb);
            this.Nibwrite.Controls.Add(this.groupBox2);
            this.Nibwrite.Controls.Add(this.Write_Clear);
            this.Nibwrite.Controls.Add(this.wtotal);
            this.Nibwrite.Controls.Add(this.wsb);
            this.Nibwrite.Controls.Add(this.label6);
            this.Nibwrite.Controls.Add(this.label5);
            this.Nibwrite.Controls.Add(this.wfn);
            this.Nibwrite.Controls.Add(this.Write_Start);
            this.Nibwrite.Controls.Add(this.label4);
            this.Nibwrite.Controls.Add(this.listBox3);
            this.Nibwrite.Location = new System.Drawing.Point(8, 39);
            this.Nibwrite.Name = "Nibwrite";
            this.Nibwrite.Size = new System.Drawing.Size(1290, 854);
            this.Nibwrite.TabIndex = 2;
            this.Nibwrite.Text = "Write Disk Image";
            this.Nibwrite.UseVisualStyleBackColor = true;
            // 
            // WAdv
            // 
            this.WAdv.AutoSize = true;
            this.WAdv.Location = new System.Drawing.Point(219, 249);
            this.WAdv.Name = "WAdv";
            this.WAdv.Size = new System.Drawing.Size(140, 29);
            this.WAdv.TabIndex = 72;
            this.WAdv.Text = "Advanced";
            this.WAdv.UseVisualStyleBackColor = true;
            this.WAdv.CheckedChanged += new System.EventHandler(this.Write_AdvanceOptions);
            // 
            // W_advopts
            // 
            this.W_advopts.Controls.Add(this.W_cap);
            this.W_advopts.Controls.Add(this.W_capmar);
            this.W_advopts.Controls.Add(this.W_autobad);
            this.W_advopts.Controls.Add(this.W_agg);
            this.W_advopts.Controls.Add(this.W_aggcr);
            this.W_advopts.Controls.Add(this.W_tgap);
            this.W_advopts.Controls.Add(this.W_timedalign);
            this.W_advopts.Controls.Add(this.W_rpm);
            this.W_advopts.Controls.Add(this.W_gapmatch);
            this.W_advopts.Controls.Add(this.W_capacity);
            this.W_advopts.Controls.Add(this.Wrpm);
            this.W_advopts.Controls.Add(this.W_gapreduce);
            this.W_advopts.Controls.Add(this.W_skew);
            this.W_advopts.Controls.Add(this.W_gcrrunred);
            this.W_advopts.Controls.Add(this.W_tskew);
            this.W_advopts.Controls.Add(this.W_syncred);
            this.W_advopts.Controls.Add(this.W_align);
            this.W_advopts.Controls.Add(this.WTA);
            this.W_advopts.Controls.Add(this.W_prot);
            this.W_advopts.Controls.Add(this.WP);
            this.W_advopts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.W_advopts.Location = new System.Drawing.Point(380, 3);
            this.W_advopts.Name = "W_advopts";
            this.W_advopts.Size = new System.Drawing.Size(911, 321);
            this.W_advopts.TabIndex = 71;
            this.W_advopts.TabStop = false;
            this.W_advopts.Text = "Advanced Options";
            // 
            // W_cap
            // 
            this.W_cap.Location = new System.Drawing.Point(770, 167);
            this.W_cap.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.W_cap.Name = "W_cap";
            this.W_cap.Size = new System.Drawing.Size(120, 31);
            this.W_cap.TabIndex = 77;
            // 
            // W_capmar
            // 
            this.W_capmar.AutoSize = true;
            this.W_capmar.Location = new System.Drawing.Point(409, 168);
            this.W_capmar.Name = "W_capmar";
            this.W_capmar.Size = new System.Drawing.Size(330, 29);
            this.W_capmar.TabIndex = 76;
            this.W_capmar.Text = "Change extra capacity margin";
            this.W_capmar.UseVisualStyleBackColor = true;
            this.W_capmar.CheckedChanged += new System.EventHandler(this.Write_AdvanceOptions);
            // 
            // W_autobad
            // 
            this.W_autobad.AutoSize = true;
            this.W_autobad.Location = new System.Drawing.Point(7, 164);
            this.W_autobad.Name = "W_autobad";
            this.W_autobad.Size = new System.Drawing.Size(361, 29);
            this.W_autobad.TabIndex = 75;
            this.W_autobad.Text = "Disable auto bad GCR simulation";
            this.W_autobad.UseVisualStyleBackColor = true;
            this.W_autobad.CheckedChanged += new System.EventHandler(this.W_autobad_CheckedChanged);
            // 
            // W_agg
            // 
            this.W_agg.Location = new System.Drawing.Point(770, 63);
            this.W_agg.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.W_agg.Name = "W_agg";
            this.W_agg.Size = new System.Drawing.Size(120, 31);
            this.W_agg.TabIndex = 74;
            // 
            // W_aggcr
            // 
            this.W_aggcr.AutoSize = true;
            this.W_aggcr.Location = new System.Drawing.Point(409, 65);
            this.W_aggcr.Name = "W_aggcr";
            this.W_aggcr.Size = new System.Drawing.Size(348, 29);
            this.W_aggcr.TabIndex = 73;
            this.W_aggcr.Text = "Aggressive bad GCR simulation";
            this.W_aggcr.UseVisualStyleBackColor = true;
            this.W_aggcr.CheckedChanged += new System.EventHandler(this.W_aggcr_CheckedChanged);
            // 
            // W_tgap
            // 
            this.W_tgap.Location = new System.Drawing.Point(770, 97);
            this.W_tgap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.W_tgap.Name = "W_tgap";
            this.W_tgap.Size = new System.Drawing.Size(120, 31);
            this.W_tgap.TabIndex = 72;
            this.W_tgap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // W_timedalign
            // 
            this.W_timedalign.AutoSize = true;
            this.W_timedalign.Location = new System.Drawing.Point(7, 199);
            this.W_timedalign.Name = "W_timedalign";
            this.W_timedalign.Size = new System.Drawing.Size(381, 29);
            this.W_timedalign.TabIndex = 53;
            this.W_timedalign.Text = "Enable timer based track alignment";
            this.W_timedalign.UseVisualStyleBackColor = true;
            // 
            // W_rpm
            // 
            this.W_rpm.Location = new System.Drawing.Point(770, 131);
            this.W_rpm.Maximum = new decimal(new int[] {
            340,
            0,
            0,
            0});
            this.W_rpm.Minimum = new decimal(new int[] {
            260,
            0,
            0,
            0});
            this.W_rpm.Name = "W_rpm";
            this.W_rpm.Size = new System.Drawing.Size(120, 31);
            this.W_rpm.TabIndex = 70;
            this.W_rpm.Value = new decimal(new int[] {
            260,
            0,
            0,
            0});
            // 
            // W_gapmatch
            // 
            this.W_gapmatch.AutoSize = true;
            this.W_gapmatch.Location = new System.Drawing.Point(409, 99);
            this.W_gapmatch.Name = "W_gapmatch";
            this.W_gapmatch.Size = new System.Drawing.Size(301, 29);
            this.W_gapmatch.TabIndex = 71;
            this.W_gapmatch.Text = "Alternate gap match length";
            this.W_gapmatch.UseVisualStyleBackColor = true;
            this.W_gapmatch.CheckedChanged += new System.EventHandler(this.Write_AdvanceOptions);
            // 
            // W_capacity
            // 
            this.W_capacity.AutoSize = true;
            this.W_capacity.Location = new System.Drawing.Point(7, 30);
            this.W_capacity.Name = "W_capacity";
            this.W_capacity.Size = new System.Drawing.Size(361, 29);
            this.W_capacity.TabIndex = 49;
            this.W_capacity.Text = "Disable auto capacity adjustment";
            this.W_capacity.UseVisualStyleBackColor = true;
            // 
            // Wrpm
            // 
            this.Wrpm.AutoSize = true;
            this.Wrpm.Location = new System.Drawing.Point(409, 133);
            this.Wrpm.Name = "Wrpm";
            this.Wrpm.Size = new System.Drawing.Size(333, 29);
            this.Wrpm.TabIndex = 69;
            this.Wrpm.Text = "Simulate track capacity (RPM)";
            this.Wrpm.UseVisualStyleBackColor = true;
            this.Wrpm.CheckedChanged += new System.EventHandler(this.Write_AdvanceOptions);
            // 
            // W_gapreduce
            // 
            this.W_gapreduce.AutoSize = true;
            this.W_gapreduce.Location = new System.Drawing.Point(6, 63);
            this.W_gapreduce.Name = "W_gapreduce";
            this.W_gapreduce.Size = new System.Drawing.Size(248, 29);
            this.W_gapreduce.TabIndex = 50;
            this.W_gapreduce.Text = "Enable gap reduction";
            this.W_gapreduce.UseVisualStyleBackColor = true;
            // 
            // W_skew
            // 
            this.W_skew.AutoSize = true;
            this.W_skew.Location = new System.Drawing.Point(409, 30);
            this.W_skew.Name = "W_skew";
            this.W_skew.Size = new System.Drawing.Size(156, 29);
            this.W_skew.TabIndex = 68;
            this.W_skew.Text = "Track Skew";
            this.W_skew.UseVisualStyleBackColor = true;
            this.W_skew.CheckedChanged += new System.EventHandler(this.Write_AdvanceOptions);
            // 
            // W_gcrrunred
            // 
            this.W_gcrrunred.AutoSize = true;
            this.W_gcrrunred.Location = new System.Drawing.Point(7, 97);
            this.W_gcrrunred.Name = "W_gcrrunred";
            this.W_gcrrunred.Size = new System.Drawing.Size(266, 29);
            this.W_gcrrunred.TabIndex = 51;
            this.W_gcrrunred.Text = "Bad GCR run reduction";
            this.W_gcrrunred.UseVisualStyleBackColor = true;
            // 
            // W_tskew
            // 
            this.W_tskew.Location = new System.Drawing.Point(770, 28);
            this.W_tskew.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.W_tskew.Name = "W_tskew";
            this.W_tskew.Size = new System.Drawing.Size(120, 31);
            this.W_tskew.TabIndex = 67;
            // 
            // W_syncred
            // 
            this.W_syncred.AutoSize = true;
            this.W_syncred.Location = new System.Drawing.Point(7, 131);
            this.W_syncred.Name = "W_syncred";
            this.W_syncred.Size = new System.Drawing.Size(310, 29);
            this.W_syncred.TabIndex = 54;
            this.W_syncred.Text = "Disable auto sync reduction";
            this.W_syncred.UseVisualStyleBackColor = true;
            // 
            // W_align
            // 
            this.W_align.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.W_align.FormattingEnabled = true;
            this.W_align.Location = new System.Drawing.Point(409, 232);
            this.W_align.Name = "W_align";
            this.W_align.Size = new System.Drawing.Size(348, 33);
            this.W_align.TabIndex = 66;
            // 
            // WTA
            // 
            this.WTA.AutoSize = true;
            this.WTA.Location = new System.Drawing.Point(7, 236);
            this.WTA.Name = "WTA";
            this.WTA.Size = new System.Drawing.Size(309, 29);
            this.WTA.TabIndex = 65;
            this.WTA.Text = "Alternative track alignments";
            this.WTA.UseVisualStyleBackColor = true;
            this.WTA.CheckedChanged += new System.EventHandler(this.Write_AdvanceOptions);
            // 
            // W_prot
            // 
            this.W_prot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.W_prot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.W_prot.FormattingEnabled = true;
            this.W_prot.Location = new System.Drawing.Point(409, 269);
            this.W_prot.Name = "W_prot";
            this.W_prot.Size = new System.Drawing.Size(348, 33);
            this.W_prot.TabIndex = 64;
            // 
            // WP
            // 
            this.WP.AutoSize = true;
            this.WP.Location = new System.Drawing.Point(7, 271);
            this.WP.Name = "WP";
            this.WP.Size = new System.Drawing.Size(296, 29);
            this.WP.TabIndex = 63;
            this.WP.Text = "Custom protection handler";
            this.WP.UseVisualStyleBackColor = true;
            this.WP.CheckedChanged += new System.EventHandler(this.Write_AdvanceOptions);
            // 
            // Zero_Disk
            // 
            this.Zero_Disk.Location = new System.Drawing.Point(186, 195);
            this.Zero_Disk.Name = "Zero_Disk";
            this.Zero_Disk.Size = new System.Drawing.Size(173, 37);
            this.Zero_Disk.TabIndex = 62;
            this.Zero_Disk.Text = "Unformat Disk";
            this.Zero_Disk.UseVisualStyleBackColor = true;
            this.Zero_Disk.Click += new System.EventHandler(this.Zero_Disk_Click);
            // 
            // W_verb
            // 
            this.W_verb.AutoSize = true;
            this.W_verb.Location = new System.Drawing.Point(12, 249);
            this.W_verb.Name = "W_verb";
            this.W_verb.Size = new System.Drawing.Size(124, 29);
            this.W_verb.TabIndex = 52;
            this.W_verb.Text = "Verbose";
            this.W_verb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.W_limit);
            this.groupBox2.Controls.Add(this.W_dev);
            this.groupBox2.Controls.Add(this.W_num);
            this.groupBox2.Controls.Add(this.WParallel);
            this.groupBox2.Controls.Add(this.W_override);
            this.groupBox2.Controls.Add(this.W_start);
            this.groupBox2.Controls.Add(this.W_end);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 179);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Settings";
            // 
            // W_limit
            // 
            this.W_limit.AutoSize = true;
            this.W_limit.Location = new System.Drawing.Point(185, 28);
            this.W_limit.Name = "W_limit";
            this.W_limit.Size = new System.Drawing.Size(153, 29);
            this.W_limit.TabIndex = 29;
            this.W_limit.Text = "Limit (T-40)";
            this.W_limit.UseVisualStyleBackColor = true;
            this.W_limit.CheckedChanged += new System.EventHandler(this.W_limit_CheckedChanged);
            // 
            // W_dev
            // 
            this.W_dev.AutoSize = true;
            this.W_dev.Location = new System.Drawing.Point(6, 30);
            this.W_dev.Name = "W_dev";
            this.W_dev.Size = new System.Drawing.Size(94, 29);
            this.W_dev.TabIndex = 24;
            this.W_dev.Text = "Drive";
            this.W_dev.UseVisualStyleBackColor = true;
            this.W_dev.CheckedChanged += new System.EventHandler(this.W_dev_CheckedChanged);
            // 
            // W_num
            // 
            this.W_num.Location = new System.Drawing.Point(106, 28);
            this.W_num.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.W_num.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.W_num.Name = "W_num";
            this.W_num.Size = new System.Drawing.Size(73, 31);
            this.W_num.TabIndex = 23;
            this.W_num.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // WParallel
            // 
            this.WParallel.AutoSize = true;
            this.WParallel.Location = new System.Drawing.Point(6, 138);
            this.WParallel.Name = "WParallel";
            this.WParallel.Size = new System.Drawing.Size(358, 29);
            this.WParallel.TabIndex = 22;
            this.WParallel.Text = "Use parallel Transfer (1571 only)";
            this.WParallel.UseVisualStyleBackColor = true;
            this.WParallel.CheckedChanged += new System.EventHandler(this.WParallel_CheckedChanged);
            // 
            // W_override
            // 
            this.W_override.AutoSize = true;
            this.W_override.Location = new System.Drawing.Point(6, 65);
            this.W_override.Name = "W_override";
            this.W_override.Size = new System.Drawing.Size(309, 29);
            this.W_override.TabIndex = 25;
            this.W_override.Text = "Override (Start) (End) Track";
            this.W_override.UseVisualStyleBackColor = true;
            this.W_override.CheckedChanged += new System.EventHandler(this.WTrackOverride_CheckedChanged);
            // 
            // W_start
            // 
            this.W_start.Location = new System.Drawing.Point(122, 100);
            this.W_start.Maximum = new decimal(new int[] {
            41,
            0,
            0,
            0});
            this.W_start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.W_start.Name = "W_start";
            this.W_start.Size = new System.Drawing.Size(74, 31);
            this.W_start.TabIndex = 26;
            this.W_start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.W_start.ValueChanged += new System.EventHandler(this.W_start_ValueChanged);
            // 
            // W_end
            // 
            this.W_end.Location = new System.Drawing.Point(202, 100);
            this.W_end.Maximum = new decimal(new int[] {
            41,
            0,
            0,
            0});
            this.W_end.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.W_end.Name = "W_end";
            this.W_end.Size = new System.Drawing.Size(75, 31);
            this.W_end.TabIndex = 27;
            this.W_end.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.W_end.ValueChanged += new System.EventHandler(this.W_end_ValueChanged);
            // 
            // Write_Clear
            // 
            this.Write_Clear.Location = new System.Drawing.Point(9, 338);
            this.Write_Clear.Name = "Write_Clear";
            this.Write_Clear.Size = new System.Drawing.Size(100, 39);
            this.Write_Clear.TabIndex = 13;
            this.Write_Clear.Text = "Clear";
            this.Write_Clear.UseVisualStyleBackColor = true;
            this.Write_Clear.Click += new System.EventHandler(this.Clear_ButtonClick);
            // 
            // wtotal
            // 
            this.wtotal.AutoSize = true;
            this.wtotal.Location = new System.Drawing.Point(931, 813);
            this.wtotal.Name = "wtotal";
            this.wtotal.Size = new System.Drawing.Size(176, 25);
            this.wtotal.TabIndex = 12;
            this.wtotal.Text = "Total Files Listed";
            // 
            // wsb
            // 
            this.wsb.Location = new System.Drawing.Point(951, 338);
            this.wsb.Name = "wsb";
            this.wsb.Size = new System.Drawing.Size(340, 31);
            this.wsb.TabIndex = 11;
            this.wsb.TextChanged += new System.EventHandler(this.Wsb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(865, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "File";
            // 
            // wfn
            // 
            this.wfn.Location = new System.Drawing.Point(186, 338);
            this.wfn.Name = "wfn";
            this.wfn.Size = new System.Drawing.Size(673, 31);
            this.wfn.TabIndex = 8;
            this.wfn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wfn.TextChanged += new System.EventHandler(this.Wfn_TextChanged);
            // 
            // Write_Start
            // 
            this.Write_Start.Location = new System.Drawing.Point(12, 195);
            this.Write_Start.Name = "Write_Start";
            this.Write_Start.Size = new System.Drawing.Size(152, 37);
            this.Write_Start.TabIndex = 7;
            this.Write_Start.Text = "Write Disk";
            this.Write_Start.UseVisualStyleBackColor = true;
            this.Write_Start.Click += new System.EventHandler(this.Write_Start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 813);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(790, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Drag File(s)/Folder(s) into window for batch writing or drag single files into fi" +
    "le box";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(6, 381);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(1285, 429);
            this.listBox3.TabIndex = 5;
            this.listBox3.Click += new System.EventHandler(this.ListBox3_SingleClick);
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.ListBox3_SelectedIndexChanged);
            this.listBox3.DoubleClick += new System.EventHandler(this.ListBox3_DoubleClick);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1307, 902);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "Nibtools GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.Nibconv.ResumeLayout(false);
            this.Nibconv.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.A_Opts.ResumeLayout(false);
            this.A_Opts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G_len)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ag_Gcr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_skew)).EndInit();
            this.Out_Box.ResumeLayout(false);
            this.Out_Box.PerformLayout();
            this.Source_box.ResumeLayout(false);
            this.Source_box.PerformLayout();
            this.Nibread.ResumeLayout(false);
            this.Nibread.PerformLayout();
            this.R_adv.ResumeLayout(false);
            this.R_adv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R_tgap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dev_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_Scheme)).EndInit();
            this.Read_out.ResumeLayout(false);
            this.Read_out.PerformLayout();
            this.Nibwrite.ResumeLayout(false);
            this.Nibwrite.PerformLayout();
            this.W_advopts.ResumeLayout(false);
            this.W_advopts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.W_cap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_agg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_tgap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_rpm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_tskew)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.W_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_end)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Nibconv;
        private System.Windows.Forms.TabPage Nibread;
        private System.Windows.Forms.TabPage Nibwrite;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox Out_Box;
        private System.Windows.Forms.RadioButton O_NBZ;
        private System.Windows.Forms.RadioButton O_NIB;
        private System.Windows.Forms.RadioButton O_D64;
        private System.Windows.Forms.RadioButton O_G64;
        private System.Windows.Forms.GroupBox Source_box;
        private System.Windows.Forms.RadioButton S_D64;
        private System.Windows.Forms.RadioButton S_G64;
        private System.Windows.Forms.RadioButton S_NBZ;
        private System.Windows.Forms.RadioButton S_NIB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Matching_Files;
        private System.Windows.Forms.Label Total_Files;
        private System.Windows.Forms.Label Out_Folder;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.CheckBox rel_path;
        private System.Windows.Forms.Button Conv_Start;
        private System.Windows.Forms.CheckBox Adv_opts;
        private System.Windows.Forms.GroupBox A_Opts;
        private System.Windows.Forms.CheckBox Sync;
        private System.Windows.Forms.CheckBox GCR;
        private System.Windows.Forms.CheckBox Gap;
        private System.Windows.Forms.CheckBox Bad_GCR;
        private System.Windows.Forms.CheckBox Skew;
        private System.Windows.Forms.NumericUpDown t_skew;
        private System.Windows.Forms.CheckBox Prot;
        private System.Windows.Forms.ComboBox P_handler;
        private System.Windows.Forms.CheckBox S_Rpm;
        private System.Windows.Forms.NumericUpDown RPM;
        private System.Windows.Forms.ComboBox T_align;
        private System.Windows.Forms.CheckBox A_Align;
        private System.Windows.Forms.NumericUpDown Ag_Gcr;
        private System.Windows.Forms.CheckBox Agg_Gcr;
        private System.Windows.Forms.NumericUpDown G_len;
        private System.Windows.Forms.CheckBox Gm_Len;
        private System.Windows.Forms.CheckBox Over_Write;
        private System.Windows.Forms.Label Conv_proc;
        private System.Windows.Forms.GroupBox Read_out;
        private System.Windows.Forms.RadioButton R_NBZ;
        private System.Windows.Forms.RadioButton R_NIB;
        private System.Windows.Forms.Button Read_Start;
        private System.Windows.Forms.Button R_Browse;
        private System.Windows.Forms.Label R_Path;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox R_Outfile;
        private System.Windows.Forms.Label r_ext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Parallel;
        private System.Windows.Forms.CheckBox R_Devnum;
        private System.Windows.Forms.NumericUpDown Dev_num;
        private System.Windows.Forms.NumericUpDown E_track;
        private System.Windows.Forms.NumericUpDown S_track;
        private System.Windows.Forms.CheckBox T_override;
        private System.Windows.Forms.CheckBox VB_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label r_current;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown N_Scheme;
        private System.Windows.Forms.CheckBox NS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wfn;
        private System.Windows.Forms.Button Write_Start;
        private System.Windows.Forms.TextBox wsb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label wtotal;
        private System.Windows.Forms.Button Write_Clear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox W_dev;
        private System.Windows.Forms.NumericUpDown W_num;
        private System.Windows.Forms.CheckBox WParallel;
        private System.Windows.Forms.CheckBox W_override;
        private System.Windows.Forms.NumericUpDown W_start;
        private System.Windows.Forms.NumericUpDown W_end;
        private System.Windows.Forms.CheckBox W_syncred;
        private System.Windows.Forms.CheckBox W_timedalign;
        private System.Windows.Forms.CheckBox W_verb;
        private System.Windows.Forms.CheckBox W_gcrrunred;
        private System.Windows.Forms.CheckBox W_gapreduce;
        private System.Windows.Forms.CheckBox W_capacity;
        private System.Windows.Forms.Button Zero_Disk;
        private System.Windows.Forms.ComboBox W_align;
        private System.Windows.Forms.CheckBox WTA;
        private System.Windows.Forms.ComboBox W_prot;
        private System.Windows.Forms.CheckBox WP;
        private System.Windows.Forms.NumericUpDown W_rpm;
        private System.Windows.Forms.CheckBox Wrpm;
        private System.Windows.Forms.CheckBox W_skew;
        private System.Windows.Forms.NumericUpDown W_tskew;
        private System.Windows.Forms.GroupBox W_advopts;
        private System.Windows.Forms.CheckBox WAdv;
        private System.Windows.Forms.NumericUpDown W_tgap;
        private System.Windows.Forms.CheckBox W_gapmatch;
        private System.Windows.Forms.NumericUpDown W_agg;
        private System.Windows.Forms.CheckBox W_aggcr;
        private System.Windows.Forms.CheckBox W_autobad;
        private System.Windows.Forms.GroupBox R_adv;
        private System.Windows.Forms.CheckBox R_halftracks;
        private System.Windows.Forms.CheckBox DR_killer;
        private System.Windows.Forms.CheckBox FD_density;
        private System.Windows.Forms.NumericUpDown R_tgap;
        private System.Windows.Forms.CheckBox ET_matching;
        private System.Windows.Forms.CheckBox Read_tgap;
        private System.Windows.Forms.CheckBox II_mode;
        private System.Windows.Forms.CheckBox EP_tests;
        private System.Windows.Forms.CheckBox U_sensor;
        private System.Windows.Forms.CheckBox U_alignment;
        private System.Windows.Forms.CheckBox U_bitrate;
        private System.Windows.Forms.CheckBox U_test;
        private System.Windows.Forms.CheckBox IHS;
        private System.Windows.Forms.CheckBox R_advanced;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox R_limit;
        private System.Windows.Forms.CheckBox W_limit;
        private System.Windows.Forms.NumericUpDown W_cap;
        private System.Windows.Forms.CheckBox W_capmar;
    }
}

