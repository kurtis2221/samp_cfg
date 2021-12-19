namespace samp_cfg
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.help_lan = new System.Windows.Forms.Label();
            this.help_rcon = new System.Windows.Forms.Label();
            this.help_maxplayers = new System.Windows.Forms.Label();
            this.help_port = new System.Windows.Forms.Label();
            this.help_hostname = new System.Windows.Forms.Label();
            this.help_gmode = new System.Windows.Forms.Label();
            this.help_fscript = new System.Windows.Forms.Label();
            this.help_announce = new System.Windows.Forms.Label();
            this.help_query = new System.Windows.Forms.Label();
            this.help_weburl = new System.Windows.Forms.Label();
            this.help_streamdis = new System.Windows.Forms.Label();
            this.help_maxnpc = new System.Windows.Forms.Label();
            this.help_logtime = new System.Windows.Forms.Label();
            this.help_mapname = new System.Windows.Forms.Label();
            this.help_plugin = new System.Windows.Forms.Label();
            this.help_password = new System.Windows.Forms.Label();
            this.data_lan = new System.Windows.Forms.CheckBox();
            this.data_serverpass = new System.Windows.Forms.TextBox();
            this.data_rconpass = new System.Windows.Forms.TextBox();
            this.data_maxplayers = new System.Windows.Forms.NumericUpDown();
            this.data_port = new System.Windows.Forms.NumericUpDown();
            this.data_hostname = new System.Windows.Forms.TextBox();
            this.data_gmode = new System.Windows.Forms.ComboBox();
            this.data_fscript = new System.Windows.Forms.ComboBox();
            this.data_plugin = new System.Windows.Forms.ComboBox();
            this.bt_setgmode = new System.Windows.Forms.Button();
            this.bt_setfscript = new System.Windows.Forms.Button();
            this.bt_setplugin = new System.Windows.Forms.Button();
            this.data_announce = new System.Windows.Forms.CheckBox();
            this.data_query = new System.Windows.Forms.CheckBox();
            this.data_web = new System.Windows.Forms.TextBox();
            this.data_rincar = new System.Windows.Forms.NumericUpDown();
            this.data_rstream = new System.Windows.Forms.NumericUpDown();
            this.data_streamdis = new System.Windows.Forms.NumericUpDown();
            this.data_maxnpc = new System.Windows.Forms.NumericUpDown();
            this.data_logtime = new System.Windows.Forms.TextBox();
            this.data_mapname = new System.Windows.Forms.TextBox();
            this.help_rates = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.data_ronfoot = new System.Windows.Forms.NumericUpDown();
            this.data_rweapon = new System.Windows.Forms.NumericUpDown();
            this.bt_loadcfg = new System.Windows.Forms.Button();
            this.bt_savecfg = new System.Windows.Forms.Button();
            this.bg_load = new System.ComponentModel.BackgroundWorker();
            this.bt_about = new System.Windows.Forms.Button();
            this.help_timestamp = new System.Windows.Forms.Label();
            this.data_timestamp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_maxplayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_rincar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_rstream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_streamdis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_maxnpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_ronfoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_rweapon)).BeginInit();
            this.SuspendLayout();
            // 
            // help_lan
            // 
            this.help_lan.AutoSize = true;
            this.help_lan.Location = new System.Drawing.Point(12, 10);
            this.help_lan.Name = "help_lan";
            this.help_lan.Size = new System.Drawing.Size(61, 13);
            this.help_lan.TabIndex = 0;
            this.help_lan.Text = "LAN Mode:";
            this.help_lan.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_lan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_lan.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_rcon
            // 
            this.help_rcon.AutoSize = true;
            this.help_rcon.Location = new System.Drawing.Point(12, 40);
            this.help_rcon.Name = "help_rcon";
            this.help_rcon.Size = new System.Drawing.Size(122, 13);
            this.help_rcon.TabIndex = 1;
            this.help_rcon.Text = "RCON Admin Password:";
            this.help_rcon.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_rcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_rcon.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_maxplayers
            // 
            this.help_maxplayers.AutoSize = true;
            this.help_maxplayers.Location = new System.Drawing.Point(12, 70);
            this.help_maxplayers.Name = "help_maxplayers";
            this.help_maxplayers.Size = new System.Drawing.Size(67, 13);
            this.help_maxplayers.TabIndex = 1;
            this.help_maxplayers.Text = "Max Players:";
            this.help_maxplayers.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_maxplayers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_maxplayers.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_port
            // 
            this.help_port.AutoSize = true;
            this.help_port.Location = new System.Drawing.Point(12, 100);
            this.help_port.Name = "help_port";
            this.help_port.Size = new System.Drawing.Size(29, 13);
            this.help_port.TabIndex = 2;
            this.help_port.Text = "Port:";
            this.help_port.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_port.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_port.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_hostname
            // 
            this.help_hostname.AutoSize = true;
            this.help_hostname.Location = new System.Drawing.Point(12, 130);
            this.help_hostname.Name = "help_hostname";
            this.help_hostname.Size = new System.Drawing.Size(63, 13);
            this.help_hostname.TabIndex = 2;
            this.help_hostname.Text = "Host Name:";
            this.help_hostname.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_hostname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_hostname.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_gmode
            // 
            this.help_gmode.AutoSize = true;
            this.help_gmode.Location = new System.Drawing.Point(12, 160);
            this.help_gmode.Name = "help_gmode";
            this.help_gmode.Size = new System.Drawing.Size(65, 13);
            this.help_gmode.TabIndex = 2;
            this.help_gmode.Text = "GameMode:";
            this.help_gmode.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_gmode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_gmode.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_fscript
            // 
            this.help_fscript.AutoSize = true;
            this.help_fscript.Location = new System.Drawing.Point(12, 190);
            this.help_fscript.Name = "help_fscript";
            this.help_fscript.Size = new System.Drawing.Size(64, 13);
            this.help_fscript.TabIndex = 3;
            this.help_fscript.Text = "FilterScripts:";
            this.help_fscript.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_fscript.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_fscript.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_announce
            // 
            this.help_announce.AutoSize = true;
            this.help_announce.Location = new System.Drawing.Point(12, 250);
            this.help_announce.Name = "help_announce";
            this.help_announce.Size = new System.Drawing.Size(59, 13);
            this.help_announce.TabIndex = 3;
            this.help_announce.Text = "Announce:";
            this.help_announce.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_announce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_announce.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_query
            // 
            this.help_query.AutoSize = true;
            this.help_query.Location = new System.Drawing.Point(12, 280);
            this.help_query.Name = "help_query";
            this.help_query.Size = new System.Drawing.Size(38, 13);
            this.help_query.TabIndex = 3;
            this.help_query.Text = "Query:";
            this.help_query.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_query.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_query.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_weburl
            // 
            this.help_weburl.AutoSize = true;
            this.help_weburl.Location = new System.Drawing.Point(12, 310);
            this.help_weburl.Name = "help_weburl";
            this.help_weburl.Size = new System.Drawing.Size(44, 13);
            this.help_weburl.TabIndex = 3;
            this.help_weburl.Text = "Weburl:";
            this.help_weburl.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_weburl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_weburl.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_streamdis
            // 
            this.help_streamdis.AutoSize = true;
            this.help_streamdis.Location = new System.Drawing.Point(12, 430);
            this.help_streamdis.Name = "help_streamdis";
            this.help_streamdis.Size = new System.Drawing.Size(85, 13);
            this.help_streamdis.TabIndex = 3;
            this.help_streamdis.Text = "StreamDistance:";
            this.help_streamdis.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_streamdis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_streamdis.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_maxnpc
            // 
            this.help_maxnpc.AutoSize = true;
            this.help_maxnpc.Location = new System.Drawing.Point(12, 460);
            this.help_maxnpc.Name = "help_maxnpc";
            this.help_maxnpc.Size = new System.Drawing.Size(92, 13);
            this.help_maxnpc.TabIndex = 3;
            this.help_maxnpc.Text = "Max NPC Players:";
            this.help_maxnpc.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_maxnpc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_maxnpc.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_logtime
            // 
            this.help_logtime.AutoSize = true;
            this.help_logtime.Location = new System.Drawing.Point(12, 490);
            this.help_logtime.Name = "help_logtime";
            this.help_logtime.Size = new System.Drawing.Size(89, 13);
            this.help_logtime.TabIndex = 3;
            this.help_logtime.Text = "Log Time Format:";
            this.help_logtime.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_logtime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_logtime.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_mapname
            // 
            this.help_mapname.AutoSize = true;
            this.help_mapname.Location = new System.Drawing.Point(12, 520);
            this.help_mapname.Name = "help_mapname";
            this.help_mapname.Size = new System.Drawing.Size(62, 13);
            this.help_mapname.TabIndex = 3;
            this.help_mapname.Text = "Map Name:";
            this.help_mapname.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_mapname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_mapname.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_plugin
            // 
            this.help_plugin.AutoSize = true;
            this.help_plugin.Location = new System.Drawing.Point(12, 220);
            this.help_plugin.Name = "help_plugin";
            this.help_plugin.Size = new System.Drawing.Size(44, 13);
            this.help_plugin.TabIndex = 3;
            this.help_plugin.Text = "Plugins:";
            this.help_plugin.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_plugin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_plugin.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // help_password
            // 
            this.help_password.AutoSize = true;
            this.help_password.Location = new System.Drawing.Point(100, 10);
            this.help_password.Name = "help_password";
            this.help_password.Size = new System.Drawing.Size(90, 13);
            this.help_password.TabIndex = 1;
            this.help_password.Text = "Server Password:";
            this.help_password.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_password.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // data_lan
            // 
            this.data_lan.AutoSize = true;
            this.data_lan.Location = new System.Drawing.Point(79, 10);
            this.data_lan.Name = "data_lan";
            this.data_lan.Size = new System.Drawing.Size(15, 14);
            this.data_lan.TabIndex = 1;
            this.data_lan.UseVisualStyleBackColor = true;
            // 
            // data_serverpass
            // 
            this.data_serverpass.Location = new System.Drawing.Point(196, 7);
            this.data_serverpass.Name = "data_serverpass";
            this.data_serverpass.Size = new System.Drawing.Size(131, 20);
            this.data_serverpass.TabIndex = 2;
            // 
            // data_rconpass
            // 
            this.data_rconpass.Location = new System.Drawing.Point(140, 37);
            this.data_rconpass.Name = "data_rconpass";
            this.data_rconpass.Size = new System.Drawing.Size(187, 20);
            this.data_rconpass.TabIndex = 3;
            this.data_rconpass.Text = "changeme";
            // 
            // data_maxplayers
            // 
            this.data_maxplayers.Location = new System.Drawing.Point(85, 68);
            this.data_maxplayers.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.data_maxplayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.data_maxplayers.Name = "data_maxplayers";
            this.data_maxplayers.Size = new System.Drawing.Size(45, 20);
            this.data_maxplayers.TabIndex = 4;
            this.data_maxplayers.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // data_port
            // 
            this.data_port.Location = new System.Drawing.Point(47, 98);
            this.data_port.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.data_port.Name = "data_port";
            this.data_port.Size = new System.Drawing.Size(50, 20);
            this.data_port.TabIndex = 5;
            this.data_port.Value = new decimal(new int[] {
            7777,
            0,
            0,
            0});
            // 
            // data_hostname
            // 
            this.data_hostname.Location = new System.Drawing.Point(81, 127);
            this.data_hostname.MaxLength = 32;
            this.data_hostname.Name = "data_hostname";
            this.data_hostname.Size = new System.Drawing.Size(246, 20);
            this.data_hostname.TabIndex = 6;
            this.data_hostname.Text = "SA-MP 0.3 Server";
            // 
            // data_gmode
            // 
            this.data_gmode.FormattingEnabled = true;
            this.data_gmode.Location = new System.Drawing.Point(83, 157);
            this.data_gmode.Name = "data_gmode";
            this.data_gmode.Size = new System.Drawing.Size(113, 21);
            this.data_gmode.TabIndex = 7;
            // 
            // data_fscript
            // 
            this.data_fscript.FormattingEnabled = true;
            this.data_fscript.Location = new System.Drawing.Point(83, 187);
            this.data_fscript.Name = "data_fscript";
            this.data_fscript.Size = new System.Drawing.Size(113, 21);
            this.data_fscript.TabIndex = 8;
            // 
            // data_plugin
            // 
            this.data_plugin.FormattingEnabled = true;
            this.data_plugin.Location = new System.Drawing.Point(62, 217);
            this.data_plugin.Name = "data_plugin";
            this.data_plugin.Size = new System.Drawing.Size(134, 21);
            this.data_plugin.TabIndex = 9;
            // 
            // bt_setgmode
            // 
            this.bt_setgmode.Location = new System.Drawing.Point(202, 157);
            this.bt_setgmode.Name = "bt_setgmode";
            this.bt_setgmode.Size = new System.Drawing.Size(125, 21);
            this.bt_setgmode.TabIndex = 7;
            this.bt_setgmode.Text = "Add/Remove";
            this.bt_setgmode.UseVisualStyleBackColor = true;
            this.bt_setgmode.Click += new System.EventHandler(this.bt_setgmode_Click);
            // 
            // bt_setfscript
            // 
            this.bt_setfscript.Location = new System.Drawing.Point(202, 187);
            this.bt_setfscript.Name = "bt_setfscript";
            this.bt_setfscript.Size = new System.Drawing.Size(125, 21);
            this.bt_setfscript.TabIndex = 8;
            this.bt_setfscript.Text = "Add/Remove";
            this.bt_setfscript.UseVisualStyleBackColor = true;
            this.bt_setfscript.Click += new System.EventHandler(this.bt_setfscript_Click);
            // 
            // bt_setplugin
            // 
            this.bt_setplugin.Location = new System.Drawing.Point(202, 217);
            this.bt_setplugin.Name = "bt_setplugin";
            this.bt_setplugin.Size = new System.Drawing.Size(125, 21);
            this.bt_setplugin.TabIndex = 9;
            this.bt_setplugin.Text = "Add/Remove";
            this.bt_setplugin.UseVisualStyleBackColor = true;
            this.bt_setplugin.Click += new System.EventHandler(this.bt_setplugin_Click);
            // 
            // data_announce
            // 
            this.data_announce.AutoSize = true;
            this.data_announce.Checked = true;
            this.data_announce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.data_announce.Location = new System.Drawing.Point(77, 250);
            this.data_announce.Name = "data_announce";
            this.data_announce.Size = new System.Drawing.Size(15, 14);
            this.data_announce.TabIndex = 10;
            this.data_announce.UseVisualStyleBackColor = true;
            // 
            // data_query
            // 
            this.data_query.AutoSize = true;
            this.data_query.Checked = true;
            this.data_query.CheckState = System.Windows.Forms.CheckState.Checked;
            this.data_query.Location = new System.Drawing.Point(56, 280);
            this.data_query.Name = "data_query";
            this.data_query.Size = new System.Drawing.Size(15, 14);
            this.data_query.TabIndex = 11;
            this.data_query.UseVisualStyleBackColor = true;
            // 
            // data_web
            // 
            this.data_web.Location = new System.Drawing.Point(62, 307);
            this.data_web.Name = "data_web";
            this.data_web.Size = new System.Drawing.Size(265, 20);
            this.data_web.TabIndex = 12;
            this.data_web.Text = "www.sa-mp.com";
            // 
            // data_rincar
            // 
            this.data_rincar.Location = new System.Drawing.Point(59, 398);
            this.data_rincar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.data_rincar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.data_rincar.Name = "data_rincar";
            this.data_rincar.Size = new System.Drawing.Size(50, 20);
            this.data_rincar.TabIndex = 15;
            this.data_rincar.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // data_rstream
            // 
            this.data_rstream.Location = new System.Drawing.Point(172, 398);
            this.data_rstream.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.data_rstream.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.data_rstream.Name = "data_rstream";
            this.data_rstream.Size = new System.Drawing.Size(50, 20);
            this.data_rstream.TabIndex = 16;
            this.data_rstream.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // data_streamdis
            // 
            this.data_streamdis.Location = new System.Drawing.Point(107, 428);
            this.data_streamdis.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.data_streamdis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.data_streamdis.Name = "data_streamdis";
            this.data_streamdis.Size = new System.Drawing.Size(50, 20);
            this.data_streamdis.TabIndex = 17;
            this.data_streamdis.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // data_maxnpc
            // 
            this.data_maxnpc.Location = new System.Drawing.Point(107, 458);
            this.data_maxnpc.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.data_maxnpc.Name = "data_maxnpc";
            this.data_maxnpc.Size = new System.Drawing.Size(50, 20);
            this.data_maxnpc.TabIndex = 18;
            // 
            // data_logtime
            // 
            this.data_logtime.Location = new System.Drawing.Point(103, 487);
            this.data_logtime.Name = "data_logtime";
            this.data_logtime.Size = new System.Drawing.Size(119, 20);
            this.data_logtime.TabIndex = 19;
            this.data_logtime.Text = "[%H:%M:%S]";
            // 
            // data_mapname
            // 
            this.data_mapname.Location = new System.Drawing.Point(80, 517);
            this.data_mapname.Name = "data_mapname";
            this.data_mapname.Size = new System.Drawing.Size(142, 20);
            this.data_mapname.TabIndex = 20;
            this.data_mapname.Text = "San Andreas";
            // 
            // help_rates
            // 
            this.help_rates.AutoSize = true;
            this.help_rates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.help_rates.Location = new System.Drawing.Point(12, 340);
            this.help_rates.Name = "help_rates";
            this.help_rates.Size = new System.Drawing.Size(40, 13);
            this.help_rates.TabIndex = 3;
            this.help_rates.Text = "Rates";
            this.help_rates.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_rates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_rates.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "OnFoot:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "InCar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Weapon:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(115, 400);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Stream:";
            // 
            // data_ronfoot
            // 
            this.data_ronfoot.Location = new System.Drawing.Point(59, 368);
            this.data_ronfoot.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.data_ronfoot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.data_ronfoot.Name = "data_ronfoot";
            this.data_ronfoot.Size = new System.Drawing.Size(50, 20);
            this.data_ronfoot.TabIndex = 13;
            this.data_ronfoot.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // data_rweapon
            // 
            this.data_rweapon.Location = new System.Drawing.Point(172, 368);
            this.data_rweapon.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.data_rweapon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.data_rweapon.Name = "data_rweapon";
            this.data_rweapon.Size = new System.Drawing.Size(50, 20);
            this.data_rweapon.TabIndex = 14;
            this.data_rweapon.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // bt_loadcfg
            // 
            this.bt_loadcfg.Location = new System.Drawing.Point(228, 512);
            this.bt_loadcfg.Name = "bt_loadcfg";
            this.bt_loadcfg.Size = new System.Drawing.Size(99, 21);
            this.bt_loadcfg.TabIndex = 21;
            this.bt_loadcfg.Text = "Load server.cfg";
            this.bt_loadcfg.UseVisualStyleBackColor = true;
            this.bt_loadcfg.Click += new System.EventHandler(this.bt_loadcfg_Click);
            // 
            // bt_savecfg
            // 
            this.bt_savecfg.Location = new System.Drawing.Point(228, 542);
            this.bt_savecfg.Name = "bt_savecfg";
            this.bt_savecfg.Size = new System.Drawing.Size(99, 21);
            this.bt_savecfg.TabIndex = 21;
            this.bt_savecfg.Text = "Save server.cfg";
            this.bt_savecfg.UseVisualStyleBackColor = true;
            this.bt_savecfg.Click += new System.EventHandler(this.bt_savecfg_Click);
            // 
            // bg_load
            // 
            this.bg_load.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_load_DoWork);
            // 
            // bt_about
            // 
            this.bt_about.Location = new System.Drawing.Point(228, 482);
            this.bt_about.Name = "bt_about";
            this.bt_about.Size = new System.Drawing.Size(99, 21);
            this.bt_about.TabIndex = 21;
            this.bt_about.Text = "About";
            this.bt_about.UseVisualStyleBackColor = true;
            this.bt_about.Click += new System.EventHandler(this.bt_about_Click);
            // 
            // help_timestamp
            // 
            this.help_timestamp.AutoSize = true;
            this.help_timestamp.Location = new System.Drawing.Point(12, 550);
            this.help_timestamp.Name = "help_timestamp";
            this.help_timestamp.Size = new System.Drawing.Size(61, 13);
            this.help_timestamp.TabIndex = 22;
            this.help_timestamp.Text = "Timestamp:";
            this.help_timestamp.MouseLeave += new System.EventHandler(this.help_lan_MouseLeave);
            this.help_timestamp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_lan_MouseClick);
            this.help_timestamp.MouseEnter += new System.EventHandler(this.help_lan_MouseEnter);
            // 
            // data_timestamp
            // 
            this.data_timestamp.AutoSize = true;
            this.data_timestamp.Checked = true;
            this.data_timestamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.data_timestamp.Location = new System.Drawing.Point(79, 550);
            this.data_timestamp.Name = "data_timestamp";
            this.data_timestamp.Size = new System.Drawing.Size(15, 14);
            this.data_timestamp.TabIndex = 10;
            this.data_timestamp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 572);
            this.Controls.Add(this.help_timestamp);
            this.Controls.Add(this.bt_about);
            this.Controls.Add(this.bt_savecfg);
            this.Controls.Add(this.bt_loadcfg);
            this.Controls.Add(this.data_mapname);
            this.Controls.Add(this.data_logtime);
            this.Controls.Add(this.data_web);
            this.Controls.Add(this.bt_setplugin);
            this.Controls.Add(this.bt_setfscript);
            this.Controls.Add(this.bt_setgmode);
            this.Controls.Add(this.data_plugin);
            this.Controls.Add(this.data_fscript);
            this.Controls.Add(this.data_gmode);
            this.Controls.Add(this.data_hostname);
            this.Controls.Add(this.data_port);
            this.Controls.Add(this.data_maxnpc);
            this.Controls.Add(this.data_streamdis);
            this.Controls.Add(this.data_rstream);
            this.Controls.Add(this.data_rweapon);
            this.Controls.Add(this.data_rincar);
            this.Controls.Add(this.data_ronfoot);
            this.Controls.Add(this.data_maxplayers);
            this.Controls.Add(this.data_rconpass);
            this.Controls.Add(this.data_serverpass);
            this.Controls.Add(this.data_query);
            this.Controls.Add(this.data_timestamp);
            this.Controls.Add(this.data_announce);
            this.Controls.Add(this.data_lan);
            this.Controls.Add(this.help_mapname);
            this.Controls.Add(this.help_logtime);
            this.Controls.Add(this.help_maxnpc);
            this.Controls.Add(this.help_streamdis);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.help_rates);
            this.Controls.Add(this.help_weburl);
            this.Controls.Add(this.help_query);
            this.Controls.Add(this.help_announce);
            this.Controls.Add(this.help_plugin);
            this.Controls.Add(this.help_fscript);
            this.Controls.Add(this.help_gmode);
            this.Controls.Add(this.help_hostname);
            this.Controls.Add(this.help_port);
            this.Controls.Add(this.help_maxplayers);
            this.Controls.Add(this.help_password);
            this.Controls.Add(this.help_rcon);
            this.Controls.Add(this.help_lan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SA-MP Server Configuration Generator";
            ((System.ComponentModel.ISupportInitialize)(this.data_maxplayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_rincar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_rstream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_streamdis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_maxnpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_ronfoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_rweapon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label help_lan;
        private System.Windows.Forms.Label help_rcon;
        private System.Windows.Forms.Label help_maxplayers;
        private System.Windows.Forms.Label help_port;
        private System.Windows.Forms.Label help_hostname;
        private System.Windows.Forms.Label help_gmode;
        private System.Windows.Forms.Label help_fscript;
        private System.Windows.Forms.Label help_announce;
        private System.Windows.Forms.Label help_query;
        private System.Windows.Forms.Label help_weburl;
        private System.Windows.Forms.Label help_streamdis;
        private System.Windows.Forms.Label help_maxnpc;
        private System.Windows.Forms.Label help_logtime;
        private System.Windows.Forms.Label help_mapname;
        private System.Windows.Forms.Label help_plugin;
        private System.Windows.Forms.Label help_password;
        private System.Windows.Forms.CheckBox data_lan;
        private System.Windows.Forms.TextBox data_serverpass;
        private System.Windows.Forms.TextBox data_rconpass;
        private System.Windows.Forms.NumericUpDown data_maxplayers;
        private System.Windows.Forms.NumericUpDown data_port;
        private System.Windows.Forms.TextBox data_hostname;
        private System.Windows.Forms.Button bt_setgmode;
        private System.Windows.Forms.Button bt_setfscript;
        private System.Windows.Forms.Button bt_setplugin;
        private System.Windows.Forms.CheckBox data_announce;
        private System.Windows.Forms.CheckBox data_query;
        private System.Windows.Forms.TextBox data_web;
        private System.Windows.Forms.NumericUpDown data_rincar;
        private System.Windows.Forms.NumericUpDown data_rstream;
        private System.Windows.Forms.NumericUpDown data_streamdis;
        private System.Windows.Forms.NumericUpDown data_maxnpc;
        private System.Windows.Forms.TextBox data_logtime;
        private System.Windows.Forms.TextBox data_mapname;
        private System.Windows.Forms.Label help_rates;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown data_ronfoot;
        private System.Windows.Forms.NumericUpDown data_rweapon;
        private System.Windows.Forms.Button bt_loadcfg;
        private System.Windows.Forms.Button bt_savecfg;
        private System.ComponentModel.BackgroundWorker bg_load;
        public System.Windows.Forms.ComboBox data_gmode;
        public System.Windows.Forms.ComboBox data_fscript;
        public System.Windows.Forms.ComboBox data_plugin;
        private System.Windows.Forms.Button bt_about;
        private System.Windows.Forms.Label help_timestamp;
        private System.Windows.Forms.CheckBox data_timestamp;
    }
}

