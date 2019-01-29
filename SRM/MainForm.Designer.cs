namespace SRM
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonCreateRepository = new System.Windows.Forms.Button();
            this.buttonSaveProfile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxAllMods = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.buttonBrowseRepoImage = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRepoImage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRepoName = new System.Windows.Forms.TextBox();
            this.checkBoxServerBattleEye = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxServerPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxServerAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientParameters = new System.Windows.Forms.TextBox();
            this.buttonBrowseProfilePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProfilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.profilesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(607, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem,
            this.renameProfileToolStripMenuItem,
            this.duplicateProfileToolStripMenuItem,
            this.deleteProfileToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newProfileToolStripMenuItem.Text = "New";
            this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click);
            // 
            // renameProfileToolStripMenuItem
            // 
            this.renameProfileToolStripMenuItem.Name = "renameProfileToolStripMenuItem";
            this.renameProfileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.renameProfileToolStripMenuItem.Text = "Rename";
            this.renameProfileToolStripMenuItem.Click += new System.EventHandler(this.renameProfileToolStripMenuItem_Click);
            // 
            // duplicateProfileToolStripMenuItem
            // 
            this.duplicateProfileToolStripMenuItem.Name = "duplicateProfileToolStripMenuItem";
            this.duplicateProfileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.duplicateProfileToolStripMenuItem.Text = "Duplicate";
            this.duplicateProfileToolStripMenuItem.Click += new System.EventHandler(this.duplicateProfileToolStripMenuItem_Click);
            // 
            // deleteProfileToolStripMenuItem
            // 
            this.deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            this.deleteProfileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteProfileToolStripMenuItem.Text = "Delete";
            this.deleteProfileToolStripMenuItem.Click += new System.EventHandler(this.deleteProfileToolStripMenuItem_Click);
            // 
            // profilesToolStripMenuItem
            // 
            this.profilesToolStripMenuItem.Name = "profilesToolStripMenuItem";
            this.profilesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.profilesToolStripMenuItem.Text = "Profiles";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 557);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.buttonCreateRepository);
            this.panel4.Controls.Add(this.buttonSaveProfile);
            this.panel4.Location = new System.Drawing.Point(284, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 97);
            this.panel4.TabIndex = 5;
            // 
            // buttonCreateRepository
            // 
            this.buttonCreateRepository.Location = new System.Drawing.Point(3, 49);
            this.buttonCreateRepository.Name = "buttonCreateRepository";
            this.buttonCreateRepository.Size = new System.Drawing.Size(100, 40);
            this.buttonCreateRepository.TabIndex = 2;
            this.buttonCreateRepository.Text = "Create Repository";
            this.buttonCreateRepository.UseVisualStyleBackColor = true;
            this.buttonCreateRepository.Click += new System.EventHandler(this.buttonCreateRepository_Click);
            // 
            // buttonSaveProfile
            // 
            this.buttonSaveProfile.Location = new System.Drawing.Point(3, 3);
            this.buttonSaveProfile.Name = "buttonSaveProfile";
            this.buttonSaveProfile.Size = new System.Drawing.Size(100, 40);
            this.buttonSaveProfile.TabIndex = 1;
            this.buttonSaveProfile.Text = "Save Profile";
            this.buttonSaveProfile.UseVisualStyleBackColor = true;
            this.buttonSaveProfile.Click += new System.EventHandler(this.buttonSaveProfile_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.listBoxAllMods);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(12, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 315);
            this.panel3.TabIndex = 4;
            // 
            // listBoxAllMods
            // 
            this.listBoxAllMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAllMods.FormattingEnabled = true;
            this.listBoxAllMods.Location = new System.Drawing.Point(9, 26);
            this.listBoxAllMods.Name = "listBoxAllMods";
            this.listBoxAllMods.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAllMods.Size = new System.Drawing.Size(223, 277);
            this.listBoxAllMods.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mods";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBoxProfile);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 221);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.buttonBrowseRepoImage);
            this.groupBoxProfile.Controls.Add(this.label10);
            this.groupBoxProfile.Controls.Add(this.textBoxRepoImage);
            this.groupBoxProfile.Controls.Add(this.label9);
            this.groupBoxProfile.Controls.Add(this.textBoxRepoName);
            this.groupBoxProfile.Controls.Add(this.checkBoxServerBattleEye);
            this.groupBoxProfile.Controls.Add(this.label7);
            this.groupBoxProfile.Controls.Add(this.textBoxServerPassword);
            this.groupBoxProfile.Controls.Add(this.label4);
            this.groupBoxProfile.Controls.Add(this.textBoxServerPort);
            this.groupBoxProfile.Controls.Add(this.label5);
            this.groupBoxProfile.Controls.Add(this.textBoxServerAddress);
            this.groupBoxProfile.Controls.Add(this.label6);
            this.groupBoxProfile.Controls.Add(this.textBoxServerName);
            this.groupBoxProfile.Controls.Add(this.label3);
            this.groupBoxProfile.Controls.Add(this.textBoxClientParameters);
            this.groupBoxProfile.Controls.Add(this.buttonBrowseProfilePath);
            this.groupBoxProfile.Controls.Add(this.label2);
            this.groupBoxProfile.Controls.Add(this.textBoxProfilePath);
            this.groupBoxProfile.Controls.Add(this.label1);
            this.groupBoxProfile.Controls.Add(this.textBoxProfileName);
            this.groupBoxProfile.Location = new System.Drawing.Point(3, 3);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(577, 215);
            this.groupBoxProfile.TabIndex = 0;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Profile";
            // 
            // buttonBrowseRepoImage
            // 
            this.buttonBrowseRepoImage.Location = new System.Drawing.Point(212, 166);
            this.buttonBrowseRepoImage.Name = "buttonBrowseRepoImage";
            this.buttonBrowseRepoImage.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowseRepoImage.TabIndex = 21;
            this.buttonBrowseRepoImage.Text = "...";
            this.buttonBrowseRepoImage.UseVisualStyleBackColor = true;
            this.buttonBrowseRepoImage.Click += new System.EventHandler(this.buttonBrowseRepoImage_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Repo Image";
            // 
            // textBoxRepoImage
            // 
            this.textBoxRepoImage.Location = new System.Drawing.Point(6, 168);
            this.textBoxRepoImage.Name = "textBoxRepoImage";
            this.textBoxRepoImage.ReadOnly = true;
            this.textBoxRepoImage.Size = new System.Drawing.Size(200, 20);
            this.textBoxRepoImage.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Repository Name";
            // 
            // textBoxRepoName
            // 
            this.textBoxRepoName.Location = new System.Drawing.Point(6, 78);
            this.textBoxRepoName.Name = "textBoxRepoName";
            this.textBoxRepoName.Size = new System.Drawing.Size(200, 20);
            this.textBoxRepoName.TabIndex = 17;
            // 
            // checkBoxServerBattleEye
            // 
            this.checkBoxServerBattleEye.AutoSize = true;
            this.checkBoxServerBattleEye.Location = new System.Drawing.Point(481, 34);
            this.checkBoxServerBattleEye.Name = "checkBoxServerBattleEye";
            this.checkBoxServerBattleEye.Size = new System.Drawing.Size(71, 17);
            this.checkBoxServerBattleEye.TabIndex = 16;
            this.checkBoxServerBattleEye.Text = "BattleEye";
            this.checkBoxServerBattleEye.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Server Password";
            // 
            // textBoxServerPassword
            // 
            this.textBoxServerPassword.Location = new System.Drawing.Point(269, 123);
            this.textBoxServerPassword.Name = "textBoxServerPassword";
            this.textBoxServerPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxServerPassword.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Server Port";
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.Location = new System.Drawing.Point(481, 78);
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(57, 20);
            this.textBoxServerPort.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Server Address";
            // 
            // textBoxServerAddress
            // 
            this.textBoxServerAddress.Location = new System.Drawing.Point(269, 78);
            this.textBoxServerAddress.Name = "textBoxServerAddress";
            this.textBoxServerAddress.Size = new System.Drawing.Size(200, 20);
            this.textBoxServerAddress.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Server Name";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(269, 32);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(200, 20);
            this.textBoxServerName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client Parameters";
            // 
            // textBoxClientParameters
            // 
            this.textBoxClientParameters.Location = new System.Drawing.Point(269, 168);
            this.textBoxClientParameters.Name = "textBoxClientParameters";
            this.textBoxClientParameters.Size = new System.Drawing.Size(200, 20);
            this.textBoxClientParameters.TabIndex = 5;
            // 
            // buttonBrowseProfilePath
            // 
            this.buttonBrowseProfilePath.Location = new System.Drawing.Point(212, 122);
            this.buttonBrowseProfilePath.Name = "buttonBrowseProfilePath";
            this.buttonBrowseProfilePath.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowseProfilePath.TabIndex = 4;
            this.buttonBrowseProfilePath.Text = "...";
            this.buttonBrowseProfilePath.UseVisualStyleBackColor = true;
            this.buttonBrowseProfilePath.Click += new System.EventHandler(this.buttonBrowseProfilePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TargetPath";
            // 
            // textBoxProfilePath
            // 
            this.textBoxProfilePath.Location = new System.Drawing.Point(6, 124);
            this.textBoxProfilePath.Name = "textBoxProfilePath";
            this.textBoxProfilePath.ReadOnly = true;
            this.textBoxProfilePath.Size = new System.Drawing.Size(200, 20);
            this.textBoxProfilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBoxProfileName
            // 
            this.textBoxProfileName.Location = new System.Drawing.Point(6, 32);
            this.textBoxProfileName.Name = "textBoxProfileName";
            this.textBoxProfileName.ReadOnly = true;
            this.textBoxProfileName.Size = new System.Drawing.Size(200, 20);
            this.textBoxProfileName.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "SRM";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientParameters;
        private System.Windows.Forms.Button buttonBrowseProfilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProfilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProfileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxServerPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxServerAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxServerBattleEye;
        private System.Windows.Forms.ToolStripMenuItem profilesToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxAllMods;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSaveProfile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRepoName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonCreateRepository;
        private System.Windows.Forms.Button buttonBrowseRepoImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRepoImage;
    }
}

