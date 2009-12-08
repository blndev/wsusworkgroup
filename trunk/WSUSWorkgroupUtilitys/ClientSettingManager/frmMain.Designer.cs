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
            this.removeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToWsusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWSUSAuthorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestSystrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.stopServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.microsoftKBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenKB328010 = new System.Windows.Forms.ToolStripMenuItem();
            this.wSUSRegSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToReadWindowsUpdatelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdWriteSettings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkEnableGroup = new System.Windows.Forms.CheckBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtWSUSStateServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdOpenSystemUpdate = new System.Windows.Forms.Button();
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
            this.numRebootDelayTime = new System.Windows.Forms.NumericUpDown();
            this.numUpdateInterval = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProviderNet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOK = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRebootDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateInterval)).BeginInit();
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
            this.txtWSUSServer.Location = new System.Drawing.Point(7, 31);
            this.txtWSUSServer.Name = "txtWSUSServer";
            this.txtWSUSServer.Size = new System.Drawing.Size(325, 20);
            this.txtWSUSServer.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtWSUSServer, "Enter a server name, or a full URL (http://server:port)");
            this.txtWSUSServer.TextChanged += new System.EventHandler(this.txtWSUSServer_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.windowsUpdateToolStripMenuItem,
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
            this.removeSettingsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exportToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "&Application";
            // 
            // removeSettingsToolStripMenuItem
            // 
            this.removeSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeSettingsToolStripMenuItem.Image")));
            this.removeSettingsToolStripMenuItem.Name = "removeSettingsToolStripMenuItem";
            this.removeSettingsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.removeSettingsToolStripMenuItem.Text = "&Remove WSUS - Reg";
            this.removeSettingsToolStripMenuItem.ToolTipText = "Removes the WSUS Settings from this PC";
            this.removeSettingsToolStripMenuItem.Click += new System.EventHandler(this.action_removeWSUSRegKeys);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(179, 6);
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem1.Image")));
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.exportToolStripMenuItem1.Text = "&Export Reg-Settings";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.action_ExportRegToFile);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.action_Exit);
            // 
            // windowsUpdateToolStripMenuItem
            // 
            this.windowsUpdateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLogToolStripMenuItem,
            this.openSettingsToolStripMenuItem,
            this.toolStripMenuItem6,
            this.actionsToolStripMenuItem});
            this.windowsUpdateToolStripMenuItem.Name = "windowsUpdateToolStripMenuItem";
            this.windowsUpdateToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.windowsUpdateToolStripMenuItem.Text = "&WindowsUpdate";
            // 
            // showLogToolStripMenuItem
            // 
            this.showLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLogToolStripMenuItem.Image")));
            this.showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            this.showLogToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.showLogToolStripMenuItem.Text = "&Show Log";
            this.showLogToolStripMenuItem.Click += new System.EventHandler(this.action_OpenWindowsUpdateLogfile);
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openSettingsToolStripMenuItem.Image")));
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openSettingsToolStripMenuItem.Text = "&Configure AutomaticUpdates";
            this.openSettingsToolStripMenuItem.Click += new System.EventHandler(this.action_ShowWindowsUpdate);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(226, 6);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceDetectToolStripMenuItem,
            this.reportToWsusToolStripMenuItem,
            this.resetWSUSAuthorizationToolStripMenuItem,
            this.TestSystrayToolStripMenuItem,
            this.toolStripMenuItem5,
            this.stopServiceToolStripMenuItem,
            this.startServiceToolStripMenuItem});
            this.actionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actionsToolStripMenuItem.Image")));
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.actionsToolStripMenuItem.Text = "&Actions";
            // 
            // forceDetectToolStripMenuItem
            // 
            this.forceDetectToolStripMenuItem.Name = "forceDetectToolStripMenuItem";
            this.forceDetectToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.forceDetectToolStripMenuItem.Text = "&force detect";
            this.forceDetectToolStripMenuItem.Click += new System.EventHandler(this.action_ForceDetectUpdates);
            // 
            // reportToWsusToolStripMenuItem
            // 
            this.reportToWsusToolStripMenuItem.Name = "reportToWsusToolStripMenuItem";
            this.reportToWsusToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.reportToWsusToolStripMenuItem.Text = "&report to wsus";
            this.reportToWsusToolStripMenuItem.Click += new System.EventHandler(this.action_SendReportToWSUS);
            // 
            // resetWSUSAuthorizationToolStripMenuItem
            // 
            this.resetWSUSAuthorizationToolStripMenuItem.Name = "resetWSUSAuthorizationToolStripMenuItem";
            this.resetWSUSAuthorizationToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.resetWSUSAuthorizationToolStripMenuItem.Text = "reset wsus &authorization";
            this.resetWSUSAuthorizationToolStripMenuItem.Click += new System.EventHandler(this.action_removeWSUSCoockie);
            // 
            // TestSystrayToolStripMenuItem
            // 
            this.TestSystrayToolStripMenuItem.Name = "TestSystrayToolStripMenuItem";
            this.TestSystrayToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.TestSystrayToolStripMenuItem.Text = "&test notification";
            this.TestSystrayToolStripMenuItem.Click += new System.EventHandler(this.action_ShowSystrayNotification);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(198, 6);
            // 
            // stopServiceToolStripMenuItem
            // 
            this.stopServiceToolStripMenuItem.Name = "stopServiceToolStripMenuItem";
            this.stopServiceToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.stopServiceToolStripMenuItem.Text = "&stop service";
            this.stopServiceToolStripMenuItem.Click += new System.EventHandler(this.action_WUServiceStop);
            // 
            // startServiceToolStripMenuItem
            // 
            this.startServiceToolStripMenuItem.Name = "startServiceToolStripMenuItem";
            this.startServiceToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.startServiceToolStripMenuItem.Text = "st&art service";
            this.startServiceToolStripMenuItem.Click += new System.EventHandler(this.action_WUServiceStart);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkUpdatesToolStripMenuItem,
            this.projectHomepageToolStripMenuItem,
            this.licenseToolStripMenuItem,
            this.toolStripMenuItem3,
            this.microsoftKBToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.action_ShowAbout);
            // 
            // checkUpdatesToolStripMenuItem
            // 
            this.checkUpdatesToolStripMenuItem.Enabled = false;
            this.checkUpdatesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkUpdatesToolStripMenuItem.Image")));
            this.checkUpdatesToolStripMenuItem.Name = "checkUpdatesToolStripMenuItem";
            this.checkUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkUpdatesToolStripMenuItem.Text = "&Check for updates";
            // 
            // projectHomepageToolStripMenuItem
            // 
            this.projectHomepageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projectHomepageToolStripMenuItem.Image")));
            this.projectHomepageToolStripMenuItem.Name = "projectHomepageToolStripMenuItem";
            this.projectHomepageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.projectHomepageToolStripMenuItem.Text = "&Project Homepage";
            this.projectHomepageToolStripMenuItem.Click += new System.EventHandler(this.action_ShowHomepage);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("licenseToolStripMenuItem.Image")));
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.licenseToolStripMenuItem.Text = "&License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.action_ShowLicense);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(170, 6);
            // 
            // microsoftKBToolStripMenuItem
            // 
            this.microsoftKBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenKB328010,
            this.wSUSRegSettingsToolStripMenuItem,
            this.howToReadWindowsUpdatelogToolStripMenuItem});
            this.microsoftKBToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("microsoftKBToolStripMenuItem.Image")));
            this.microsoftKBToolStripMenuItem.Name = "microsoftKBToolStripMenuItem";
            this.microsoftKBToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.microsoftKBToolStripMenuItem.Text = "Microsoft KB";
            // 
            // mnuOpenKB328010
            // 
            this.mnuOpenKB328010.Name = "mnuOpenKB328010";
            this.mnuOpenKB328010.Size = new System.Drawing.Size(249, 22);
            this.mnuOpenKB328010.Text = "Configure AutomaticUpdates ";
            this.mnuOpenKB328010.Click += new System.EventHandler(this.action_ShowKB328010);
            // 
            // wSUSRegSettingsToolStripMenuItem
            // 
            this.wSUSRegSettingsToolStripMenuItem.Name = "wSUSRegSettingsToolStripMenuItem";
            this.wSUSRegSettingsToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.wSUSRegSettingsToolStripMenuItem.Text = "WSUS - RegSettings";
            this.wSUSRegSettingsToolStripMenuItem.Click += new System.EventHandler(this.action_ShowWSUSHP_01);
            // 
            // howToReadWindowsUpdatelogToolStripMenuItem
            // 
            this.howToReadWindowsUpdatelogToolStripMenuItem.Name = "howToReadWindowsUpdatelogToolStripMenuItem";
            this.howToReadWindowsUpdatelogToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.howToReadWindowsUpdatelogToolStripMenuItem.Text = "How to read WindowsUpdate.log";
            this.howToReadWindowsUpdatelogToolStripMenuItem.Click += new System.EventHandler(this.action_OpenKBLogfiel);
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
            this.cmdWriteSettings.Location = new System.Drawing.Point(7, 223);
            this.cmdWriteSettings.Name = "cmdWriteSettings";
            this.cmdWriteSettings.Size = new System.Drawing.Size(325, 41);
            this.cmdWriteSettings.TabIndex = 7;
            this.cmdWriteSettings.Text = "Activate WSUS";
            this.cmdWriteSettings.UseVisualStyleBackColor = true;
            this.cmdWriteSettings.Click += new System.EventHandler(this.cmdWriteSettings_Click);
            // 
            // chkEnableGroup
            // 
            this.chkEnableGroup.AutoSize = true;
            this.chkEnableGroup.Location = new System.Drawing.Point(7, 131);
            this.chkEnableGroup.Name = "chkEnableGroup";
            this.chkEnableGroup.Size = new System.Drawing.Size(210, 17);
            this.chkEnableGroup.TabIndex = 12;
            this.chkEnableGroup.Text = "put this client to special WSUS - Group";
            this.toolTip1.SetToolTip(this.chkEnableGroup, "If this option is enabled, this computer will use the wsus-groups to get updates");
            this.chkEnableGroup.UseVisualStyleBackColor = true;
            this.chkEnableGroup.CheckStateChanged += new System.EventHandler(this.chkEnableGroup_CheckStateChanged);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(6, 169);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(326, 20);
            this.txtGroupName.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txtGroupName, "Enter a WSUS-Groupname");
            this.txtGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // txtWSUSStateServer
            // 
            this.txtWSUSStateServer.Location = new System.Drawing.Point(7, 79);
            this.txtWSUSStateServer.Name = "txtWSUSStateServer";
            this.txtWSUSStateServer.Size = new System.Drawing.Size(325, 20);
            this.txtWSUSStateServer.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtWSUSStateServer, "Enter a server name, or a full URL (http://server:port)");
            this.txtWSUSStateServer.TextChanged += new System.EventHandler(this.txtWSUSLogServer_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "delay time:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip1.SetToolTip(this.label5, "Is time in minutes after the user is repeatedly prompted to restart");
            // 
            // cmdOpenSystemUpdate
            // 
            this.cmdOpenSystemUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOpenSystemUpdate.Image = ((System.Drawing.Image)(resources.GetObject("cmdOpenSystemUpdate.Image")));
            this.cmdOpenSystemUpdate.Location = new System.Drawing.Point(380, 33);
            this.cmdOpenSystemUpdate.Name = "cmdOpenSystemUpdate";
            this.cmdOpenSystemUpdate.Size = new System.Drawing.Size(228, 290);
            this.cmdOpenSystemUpdate.TabIndex = 13;
            this.cmdOpenSystemUpdate.Text = "configure automatic updates";
            this.cmdOpenSystemUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.cmdOpenSystemUpdate, "a click opens the windows update configuration");
            this.cmdOpenSystemUpdate.UseVisualStyleBackColor = true;
            this.cmdOpenSystemUpdate.Click += new System.EventHandler(this.action_ShowWindowsUpdate);
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
            this.tabPage2.Controls.Add(this.cmdWriteSettings);
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
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Groupname:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 59);
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
            this.tabPage1.Text = "Details";
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
            this.chkEnableRebootDelay.Location = new System.Drawing.Point(9, 86);
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
            // numRebootDelayTime
            // 
            this.numRebootDelayTime.Location = new System.Drawing.Point(86, 109);
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
            this.numUpdateInterval.Location = new System.Drawing.Point(86, 45);
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
            this.label8.Location = new System.Drawing.Point(134, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "h";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(134, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "min.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "frequency:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 348);
            this.Controls.Add(this.cmdOpenSystemUpdate);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRebootDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateInterval)).EndInit();
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
        private System.Windows.Forms.CheckBox chkEnableUpdateInterval;
        private System.Windows.Forms.CheckBox chkEnableRebootDelay;
        private System.Windows.Forms.CheckBox chkNoRebootWithUser;
        private System.Windows.Forms.CheckBox chkAutoInstallMinor;
        private System.Windows.Forms.NumericUpDown numRebootDelayTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNonAdminInstall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderNet;
        private System.Windows.Forms.ErrorProvider errorProviderOK;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem microsoftKBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenKB328010;
        private System.Windows.Forms.ToolStripMenuItem removeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem projectHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wSUSRegSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceDetectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToWsusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWSUSAuthorizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestSystrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem stopServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToReadWindowsUpdatelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.Button cmdOpenSystemUpdate;
    }
}

