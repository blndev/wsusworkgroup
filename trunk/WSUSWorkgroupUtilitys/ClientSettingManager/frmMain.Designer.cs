namespace Codeplex.DBedarf.WSUS.Workgroup.ClientSettingManager
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.errorProviderRed = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtWSUSServer = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWindowsUpdateSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.microsoftKBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenKB328010 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdWriteSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkEnableGroup = new System.Windows.Forms.CheckBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtWSUSStateServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveRegFile_Dialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkNonAdminInstall = new System.Windows.Forms.CheckBox();
            this.chkEnableRebootDelay = new System.Windows.Forms.CheckBox();
            this.chkNoRebootWithUser = new System.Windows.Forms.CheckBox();
            this.chkAutoInstallMinor = new System.Windows.Forms.CheckBox();
            this.chkEnableUpdateInterval = new System.Windows.Forms.CheckBox();
            this.chkEnableAutoUpdate = new System.Windows.Forms.CheckBox();
            this.numRebootDelayTime = new System.Windows.Forms.NumericUpDown();
            this.numUpdateInterval = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderNet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOK = new System.Windows.Forms.ErrorProvider(this.components);
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.currentSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRebootDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateInterval)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOK)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProviderRed
            // 
            this.errorProviderRed.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderRed.ContainerControl = this;
            this.errorProviderRed.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderRed.Icon")));
            // 
            // txtWSUSServer
            // 
            this.errorProviderRed.SetError(this.txtWSUSServer, "Required");
            this.txtWSUSServer.Location = new System.Drawing.Point(113, 8);
            this.txtWSUSServer.Name = "txtWSUSServer";
            this.txtWSUSServer.Size = new System.Drawing.Size(219, 20);
            this.txtWSUSServer.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtWSUSServer, "Enter a server name, or a full URL (http://server:port)");
            this.txtWSUSServer.TextChanged += new System.EventHandler(this.txtWSUSServer_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWindowsUpdateSettingsToolStripMenuItem,
            this.removeSettingsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exportToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "&Application";
            // 
            // openWindowsUpdateSettingsToolStripMenuItem
            // 
            this.openWindowsUpdateSettingsToolStripMenuItem.Name = "openWindowsUpdateSettingsToolStripMenuItem";
            this.openWindowsUpdateSettingsToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.openWindowsUpdateSettingsToolStripMenuItem.Text = "Open WindowsUpdate - Settings";
            this.openWindowsUpdateSettingsToolStripMenuItem.Click += new System.EventHandler(this.openWindowsUpdateSettingsToolStripMenuItem_Click);
            // 
            // removeSettingsToolStripMenuItem
            // 
            this.removeSettingsToolStripMenuItem.Name = "removeSettingsToolStripMenuItem";
            this.removeSettingsToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.removeSettingsToolStripMenuItem.Text = "&Remove WSUS - Settings";
            this.removeSettingsToolStripMenuItem.ToolTipText = "Removes the WSUS Settings from this PC";
            this.removeSettingsToolStripMenuItem.Click += new System.EventHandler(this.removeSettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(243, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkUpdatesToolStripMenuItem,
            this.projectHomepageToolStripMenuItem,
            this.toolStripMenuItem3,
            this.microsoftKBToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkUpdatesToolStripMenuItem
            // 
            this.checkUpdatesToolStripMenuItem.Enabled = false;
            this.checkUpdatesToolStripMenuItem.Name = "checkUpdatesToolStripMenuItem";
            this.checkUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkUpdatesToolStripMenuItem.Text = "&Check for updates";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 6);
            // 
            // microsoftKBToolStripMenuItem
            // 
            this.microsoftKBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenKB328010});
            this.microsoftKBToolStripMenuItem.Name = "microsoftKBToolStripMenuItem";
            this.microsoftKBToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.microsoftKBToolStripMenuItem.Text = "Microsoft KB";
            // 
            // mnuOpenKB328010
            // 
            this.mnuOpenKB328010.Name = "mnuOpenKB328010";
            this.mnuOpenKB328010.Size = new System.Drawing.Size(124, 22);
            this.mnuOpenKB328010.Text = "KB328010";
            this.mnuOpenKB328010.Click += new System.EventHandler(this.mnuOpenKB328010_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(623, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // cmdWriteSettings
            // 
            this.cmdWriteSettings.Location = new System.Drawing.Point(443, 295);
            this.cmdWriteSettings.Name = "cmdWriteSettings";
            this.cmdWriteSettings.Size = new System.Drawing.Size(115, 23);
            this.cmdWriteSettings.TabIndex = 7;
            this.cmdWriteSettings.Text = "Activate WSUS";
            this.cmdWriteSettings.UseVisualStyleBackColor = true;
            this.cmdWriteSettings.Click += new System.EventHandler(this.cmdWriteSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // chkEnableGroup
            // 
            this.chkEnableGroup.AutoSize = true;
            this.chkEnableGroup.Location = new System.Drawing.Point(113, 85);
            this.chkEnableGroup.Name = "chkEnableGroup";
            this.chkEnableGroup.Size = new System.Drawing.Size(90, 17);
            this.chkEnableGroup.TabIndex = 12;
            this.chkEnableGroup.Text = "enable Group";
            this.toolTip1.SetToolTip(this.chkEnableGroup, "If this option is enabled, this computer will use the wsus-groups to get updates");
            this.chkEnableGroup.UseVisualStyleBackColor = true;
            this.chkEnableGroup.CheckStateChanged += new System.EventHandler(this.chkEnableGroup_CheckStateChanged);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(113, 105);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(219, 20);
            this.txtGroupName.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txtGroupName, "Enter a WSUS-Groupname");
            this.txtGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // txtWSUSStateServer
            // 
            this.txtWSUSStateServer.Location = new System.Drawing.Point(113, 37);
            this.txtWSUSStateServer.Name = "txtWSUSStateServer";
            this.txtWSUSStateServer.Size = new System.Drawing.Size(219, 20);
            this.txtWSUSStateServer.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtWSUSStateServer, "Enter a server name, or a full URL (http://server:port)");
            this.txtWSUSStateServer.TextChanged += new System.EventHandler(this.txtWSUSLogServer_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(93, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "delay time:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip1.SetToolTip(this.label5, "Is time in minutes after the user is repeatedly prompted to restart");
            // 
            // saveRegFile_Dialog
            // 
            this.saveRegFile_Dialog.DefaultExt = "reg";
            this.saveRegFile_Dialog.Filter = "*.reg|*.reg|*.*|*.*";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 296);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.chkEnableGroup);
            this.tabPage2.Controls.Add(this.txtGroupName);
            this.tabPage2.Controls.Add(this.txtWSUSStateServer);
            this.tabPage2.Controls.Add(this.txtWSUSServer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(358, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Groupname:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Status - Server:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "WSUS - Server:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkNonAdminInstall);
            this.tabPage1.Controls.Add(this.chkEnableRebootDelay);
            this.tabPage1.Controls.Add(this.chkNoRebootWithUser);
            this.tabPage1.Controls.Add(this.chkAutoInstallMinor);
            this.tabPage1.Controls.Add(this.chkEnableUpdateInterval);
            this.tabPage1.Controls.Add(this.chkEnableAutoUpdate);
            this.tabPage1.Controls.Add(this.numRebootDelayTime);
            this.tabPage1.Controls.Add(this.numUpdateInterval);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(358, 270);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Action";
            // 
            // chkNonAdminInstall
            // 
            this.chkNonAdminInstall.AutoSize = true;
            this.chkNonAdminInstall.Location = new System.Drawing.Point(9, 201);
            this.chkNonAdminInstall.Name = "chkNonAdminInstall";
            this.chkNonAdminInstall.Size = new System.Drawing.Size(189, 17);
            this.chkNonAdminInstall.TabIndex = 28;
            this.chkNonAdminInstall.Text = "allow non admins to install updates";
            this.chkNonAdminInstall.UseVisualStyleBackColor = true;
            // 
            // chkEnableRebootDelay
            // 
            this.chkEnableRebootDelay.AutoSize = true;
            this.chkEnableRebootDelay.Location = new System.Drawing.Point(9, 87);
            this.chkEnableRebootDelay.Name = "chkEnableRebootDelay";
            this.chkEnableRebootDelay.Size = new System.Drawing.Size(119, 17);
            this.chkEnableRebootDelay.TabIndex = 27;
            this.chkEnableRebootDelay.Text = "enable reboot delay";
            this.chkEnableRebootDelay.UseVisualStyleBackColor = true;
            // 
            // chkNoRebootWithUser
            // 
            this.chkNoRebootWithUser.AutoSize = true;
            this.chkNoRebootWithUser.Location = new System.Drawing.Point(9, 178);
            this.chkNoRebootWithUser.Name = "chkNoRebootWithUser";
            this.chkNoRebootWithUser.Size = new System.Drawing.Size(152, 17);
            this.chkNoRebootWithUser.TabIndex = 26;
            this.chkNoRebootWithUser.Text = "no reboot if user logged on";
            this.chkNoRebootWithUser.UseVisualStyleBackColor = true;
            // 
            // chkAutoInstallMinor
            // 
            this.chkAutoInstallMinor.AutoSize = true;
            this.chkAutoInstallMinor.Location = new System.Drawing.Point(10, 155);
            this.chkAutoInstallMinor.Name = "chkAutoInstallMinor";
            this.chkAutoInstallMinor.Size = new System.Drawing.Size(145, 17);
            this.chkAutoInstallMinor.TabIndex = 26;
            this.chkAutoInstallMinor.Text = "auto install minor updates";
            this.chkAutoInstallMinor.UseVisualStyleBackColor = true;
            // 
            // chkEnableUpdateInterval
            // 
            this.chkEnableUpdateInterval.AutoSize = true;
            this.chkEnableUpdateInterval.Location = new System.Drawing.Point(9, 22);
            this.chkEnableUpdateInterval.Name = "chkEnableUpdateInterval";
            this.chkEnableUpdateInterval.Size = new System.Drawing.Size(165, 17);
            this.chkEnableUpdateInterval.TabIndex = 25;
            this.chkEnableUpdateInterval.Text = "enable auto update detection";
            this.chkEnableUpdateInterval.UseVisualStyleBackColor = true;
            // 
            // chkEnableAutoUpdate
            // 
            this.chkEnableAutoUpdate.AutoSize = true;
            this.chkEnableAutoUpdate.Location = new System.Drawing.Point(9, 247);
            this.chkEnableAutoUpdate.Name = "chkEnableAutoUpdate";
            this.chkEnableAutoUpdate.Size = new System.Drawing.Size(118, 17);
            this.chkEnableAutoUpdate.TabIndex = 24;
            this.chkEnableAutoUpdate.Text = "enable AutoUpdate";
            this.chkEnableAutoUpdate.UseVisualStyleBackColor = true;
            this.chkEnableAutoUpdate.Visible = false;
            // 
            // numRebootDelayTime
            // 
            this.numRebootDelayTime.Location = new System.Drawing.Point(168, 103);
            this.numRebootDelayTime.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numRebootDelayTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRebootDelayTime.Name = "numRebootDelayTime";
            this.numRebootDelayTime.Size = new System.Drawing.Size(42, 20);
            this.numRebootDelayTime.TabIndex = 23;
            this.numRebootDelayTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numUpdateInterval
            // 
            this.numUpdateInterval.Location = new System.Drawing.Point(168, 45);
            this.numUpdateInterval.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numUpdateInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdateInterval.Name = "numUpdateInterval";
            this.numUpdateInterval.Size = new System.Drawing.Size(42, 20);
            this.numUpdateInterval.TabIndex = 23;
            this.numUpdateInterval.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(216, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "h";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(216, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "min.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(96, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "frequency:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBox2);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(358, 270);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Schedule";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01 am",
            "02 am",
            "03 am",
            "04 am",
            "05 am",
            "06 am",
            "07 am",
            "08 am",
            "09 am",
            "10 am",
            "11 am",
            "12 am",
            "01 pm",
            "02 pm",
            "03 pm",
            "04 pm",
            "05 pm",
            "06 pm",
            "07 pm",
            "08 pm",
            "09 pm",
            "10 pm",
            "11 pm",
            "12 pm"});
            this.comboBox2.Location = new System.Drawing.Point(159, 153);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(62, 21);
            this.comboBox2.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(136, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "at:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Install:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "daily",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
            this.comboBox1.Location = new System.Drawing.Point(59, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 140);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options:";
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(7, 106);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(316, 27);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Automatically download and scheduled installation.";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(7, 78);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(316, 27);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Automatically download and notify of installation. ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(7, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(316, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Notify of download and installation.";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(7, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(316, 45);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "\"Keep my computer up to date\" has been disabled in Automatic Updates.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(358, 270);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Security";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Currently there are no security options.";
            // 
            // errorProviderNet
            // 
            this.errorProviderNet.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNet.ContainerControl = this;
            this.errorProviderNet.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderNet.Icon")));
            // 
            // errorProviderOK
            // 
            this.errorProviderOK.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderOK.ContainerControl = this;
            this.errorProviderOK.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderOK.Icon")));
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentSettingsToolStripMenuItem});
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.exportToolStripMenuItem1.Text = "&Export";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(243, 6);
            // 
            // currentSettingsToolStripMenuItem
            // 
            this.currentSettingsToolStripMenuItem.Name = "currentSettingsToolStripMenuItem";
            this.currentSettingsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.currentSettingsToolStripMenuItem.Text = "Current Settings";
            this.currentSettingsToolStripMenuItem.Click += new System.EventHandler(this.mnuExportToRegFile_Click);
            // 
            // projectHomepageToolStripMenuItem
            // 
            this.projectHomepageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem});
            this.projectHomepageToolStripMenuItem.Name = "projectHomepageToolStripMenuItem";
            this.projectHomepageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.projectHomepageToolStripMenuItem.Text = "&Project Homepage";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.licenseToolStripMenuItem.Text = "&License";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 348);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdWriteSettings);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "WSUS - WorkGroup ClientSettingManager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRebootDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateInterval)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProviderRed;
        private System.Windows.Forms.Button cmdWriteSettings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveRegFile_Dialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEnableGroup;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.TextBox txtWSUSStateServer;
        private System.Windows.Forms.TextBox txtWSUSServer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numUpdateInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkEnableUpdateInterval;
        private System.Windows.Forms.CheckBox chkEnableAutoUpdate;
        private System.Windows.Forms.CheckBox chkEnableRebootDelay;
        private System.Windows.Forms.CheckBox chkNoRebootWithUser;
        private System.Windows.Forms.CheckBox chkAutoInstallMinor;
        private System.Windows.Forms.NumericUpDown numRebootDelayTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNonAdminInstall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderNet;
        private System.Windows.Forms.ErrorProvider errorProviderOK;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem microsoftKBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenKB328010;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem openWindowsUpdateSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
    }
}

