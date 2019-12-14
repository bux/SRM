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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAllRepositoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAddToOptionalMods = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAddToRequiredMods = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listBoxOptionalMods = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listBoxRequiredMods = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonCreateRepository = new System.Windows.Forms.Button();
            this.buttonSaveProfile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabelSelectAllMods = new System.Windows.Forms.LinkLabel();
            this.linkLabelDeselectAllMods = new System.Windows.Forms.LinkLabel();
            this.listBoxAllMods = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.buttonBrowseRepoIcon = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRepoIcon = new System.Windows.Forms.TextBox();
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
            this.linkLabelDeselectAllOptionalMods = new System.Windows.Forms.LinkLabel();
            this.linkLabelDeselectAllRequiredMods = new System.Windows.Forms.LinkLabel();
            this.linkLabelSelectAllOptionalMods = new System.Windows.Forms.LinkLabel();
            this.linkLabelSelectAllRequiredMods = new System.Windows.Forms.LinkLabel();
            this.btnRemoveFromRequiredMods = new System.Windows.Forms.Button();
            this.btnRemoveFromOptionalMods = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(718, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem,
            this.renameProfileToolStripMenuItem,
            this.duplicateProfileToolStripMenuItem,
            this.deleteProfileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "File";
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newProfileToolStripMenuItem.Text = "New Profile";
            this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click);
            // 
            // renameProfileToolStripMenuItem
            // 
            this.renameProfileToolStripMenuItem.Name = "renameProfileToolStripMenuItem";
            this.renameProfileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.renameProfileToolStripMenuItem.Text = "Rename Profile";
            this.renameProfileToolStripMenuItem.Click += new System.EventHandler(this.renameProfileToolStripMenuItem_Click);
            // 
            // duplicateProfileToolStripMenuItem
            // 
            this.duplicateProfileToolStripMenuItem.Name = "duplicateProfileToolStripMenuItem";
            this.duplicateProfileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.duplicateProfileToolStripMenuItem.Text = "Duplicate Profile";
            this.duplicateProfileToolStripMenuItem.Click += new System.EventHandler(this.duplicateProfileToolStripMenuItem_Click);
            // 
            // deleteProfileToolStripMenuItem
            // 
            this.deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            this.deleteProfileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteProfileToolStripMenuItem.Text = "Delete Profile";
            this.deleteProfileToolStripMenuItem.Click += new System.EventHandler(this.deleteProfileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // profilesToolStripMenuItem
            // 
            this.profilesToolStripMenuItem.Name = "profilesToolStripMenuItem";
            this.profilesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.profilesToolStripMenuItem.Text = "Profiles";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAllRepositoriesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // createAllRepositoriesToolStripMenuItem
            // 
            this.createAllRepositoriesToolStripMenuItem.Name = "createAllRepositoriesToolStripMenuItem";
            this.createAllRepositoriesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.createAllRepositoriesToolStripMenuItem.Text = "Create all repositories";
            this.createAllRepositoriesToolStripMenuItem.Click += new System.EventHandler(this.createAllRepositoriesToolStripMenuItem_Click);
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
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 850);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.btnRemoveFromOptionalMods);
            this.panel8.Controls.Add(this.btnAddToOptionalMods);
            this.panel8.Location = new System.Drawing.Point(258, 675);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(88, 93);
            this.panel8.TabIndex = 7;
            // 
            // btnAddToOptionalMods
            // 
            this.btnAddToOptionalMods.Location = new System.Drawing.Point(3, 3);
            this.btnAddToOptionalMods.Name = "btnAddToOptionalMods";
            this.btnAddToOptionalMods.Size = new System.Drawing.Size(82, 40);
            this.btnAddToOptionalMods.TabIndex = 1;
            this.btnAddToOptionalMods.Text = "→";
            this.btnAddToOptionalMods.UseVisualStyleBackColor = true;
            this.btnAddToOptionalMods.Click += new System.EventHandler(this.btnAddToOptionalMods_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.btnRemoveFromRequiredMods);
            this.panel7.Controls.Add(this.btnAddToRequiredMods);
            this.panel7.Location = new System.Drawing.Point(258, 344);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(88, 92);
            this.panel7.TabIndex = 6;
            // 
            // btnAddToRequiredMods
            // 
            this.btnAddToRequiredMods.Location = new System.Drawing.Point(3, 3);
            this.btnAddToRequiredMods.Name = "btnAddToRequiredMods";
            this.btnAddToRequiredMods.Size = new System.Drawing.Size(82, 40);
            this.btnAddToRequiredMods.TabIndex = 1;
            this.btnAddToRequiredMods.Text = "→";
            this.btnAddToRequiredMods.UseVisualStyleBackColor = true;
            this.btnAddToRequiredMods.Click += new System.EventHandler(this.btnAddToRequiredMods_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.Controls.Add(this.linkLabelSelectAllOptionalMods);
            this.panel6.Controls.Add(this.linkLabelDeselectAllOptionalMods);
            this.panel6.Controls.Add(this.listBoxOptionalMods);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(352, 574);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 264);
            this.panel6.TabIndex = 9;
            // 
            // listBoxOptionalMods
            // 
            this.listBoxOptionalMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxOptionalMods.FormattingEnabled = true;
            this.listBoxOptionalMods.Location = new System.Drawing.Point(9, 26);
            this.listBoxOptionalMods.Name = "listBoxOptionalMods";
            this.listBoxOptionalMods.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxOptionalMods.Size = new System.Drawing.Size(223, 212);
            this.listBoxOptionalMods.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Optional Mods";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.linkLabelSelectAllRequiredMods);
            this.panel5.Controls.Add(this.linkLabelDeselectAllRequiredMods);
            this.panel5.Controls.Add(this.listBoxRequiredMods);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(352, 256);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 325);
            this.panel5.TabIndex = 8;
            // 
            // listBoxRequiredMods
            // 
            this.listBoxRequiredMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxRequiredMods.FormattingEnabled = true;
            this.listBoxRequiredMods.Location = new System.Drawing.Point(9, 26);
            this.listBoxRequiredMods.Name = "listBoxRequiredMods";
            this.listBoxRequiredMods.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRequiredMods.Size = new System.Drawing.Size(223, 277);
            this.listBoxRequiredMods.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Required Mods";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.buttonCreateRepository);
            this.panel4.Controls.Add(this.buttonSaveProfile);
            this.panel4.Location = new System.Drawing.Point(598, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(108, 118);
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
            this.panel3.Controls.Add(this.linkLabelSelectAllMods);
            this.panel3.Controls.Add(this.linkLabelDeselectAllMods);
            this.panel3.Controls.Add(this.listBoxAllMods);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(12, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 582);
            this.panel3.TabIndex = 4;
            // 
            // linkLabelSelectAllMods
            // 
            this.linkLabelSelectAllMods.AutoSize = true;
            this.linkLabelSelectAllMods.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelSelectAllMods.Location = new System.Drawing.Point(175, 10);
            this.linkLabelSelectAllMods.Name = "linkLabelSelectAllMods";
            this.linkLabelSelectAllMods.Size = new System.Drawing.Size(18, 13);
            this.linkLabelSelectAllMods.TabIndex = 7;
            this.linkLabelSelectAllMods.TabStop = true;
            this.linkLabelSelectAllMods.Text = "All";
            this.linkLabelSelectAllMods.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelSelectAllMods.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelSelectAllMods.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectAllMods_LinkClicked);
            // 
            // linkLabelDeselectAllMods
            // 
            this.linkLabelDeselectAllMods.AutoSize = true;
            this.linkLabelDeselectAllMods.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelDeselectAllMods.Location = new System.Drawing.Point(199, 10);
            this.linkLabelDeselectAllMods.Name = "linkLabelDeselectAllMods";
            this.linkLabelDeselectAllMods.Size = new System.Drawing.Size(33, 13);
            this.linkLabelDeselectAllMods.TabIndex = 6;
            this.linkLabelDeselectAllMods.TabStop = true;
            this.linkLabelDeselectAllMods.Text = "None";
            this.linkLabelDeselectAllMods.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelDeselectAllMods.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelDeselectAllMods.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDeselectAllMods_LinkClicked);
            // 
            // listBoxAllMods
            // 
            this.listBoxAllMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAllMods.FormattingEnabled = true;
            this.listBoxAllMods.Location = new System.Drawing.Point(9, 26);
            this.listBoxAllMods.Name = "listBoxAllMods";
            this.listBoxAllMods.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAllMods.Size = new System.Drawing.Size(223, 550);
            this.listBoxAllMods.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "All Mods";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBoxProfile);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 247);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.buttonBrowseRepoIcon);
            this.groupBoxProfile.Controls.Add(this.label11);
            this.groupBoxProfile.Controls.Add(this.textBoxRepoIcon);
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
            this.groupBoxProfile.Size = new System.Drawing.Size(577, 241);
            this.groupBoxProfile.TabIndex = 0;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Profile";
            // 
            // buttonBrowseRepoIcon
            // 
            this.buttonBrowseRepoIcon.Location = new System.Drawing.Point(212, 210);
            this.buttonBrowseRepoIcon.Name = "buttonBrowseRepoIcon";
            this.buttonBrowseRepoIcon.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowseRepoIcon.TabIndex = 24;
            this.buttonBrowseRepoIcon.Text = "...";
            this.buttonBrowseRepoIcon.UseVisualStyleBackColor = true;
            this.buttonBrowseRepoIcon.Click += new System.EventHandler(this.buttonBrowseRepoIcon_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Repo Icon";
            // 
            // textBoxRepoIcon
            // 
            this.textBoxRepoIcon.Location = new System.Drawing.Point(6, 212);
            this.textBoxRepoIcon.Name = "textBoxRepoIcon";
            this.textBoxRepoIcon.ReadOnly = true;
            this.textBoxRepoIcon.Size = new System.Drawing.Size(200, 20);
            this.textBoxRepoIcon.TabIndex = 22;
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
            this.label2.Size = new System.Drawing.Size(60, 13);
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
            // linkLabelDeselectAllOptionalMods
            // 
            this.linkLabelDeselectAllOptionalMods.AutoSize = true;
            this.linkLabelDeselectAllOptionalMods.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelDeselectAllOptionalMods.Location = new System.Drawing.Point(199, 10);
            this.linkLabelDeselectAllOptionalMods.Name = "linkLabelDeselectAllOptionalMods";
            this.linkLabelDeselectAllOptionalMods.Size = new System.Drawing.Size(33, 13);
            this.linkLabelDeselectAllOptionalMods.TabIndex = 6;
            this.linkLabelDeselectAllOptionalMods.TabStop = true;
            this.linkLabelDeselectAllOptionalMods.Text = "None";
            this.linkLabelDeselectAllOptionalMods.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelDeselectAllOptionalMods.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelDeselectAllOptionalMods.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDeselectAllOptionalMods_LinkClicked);
            // 
            // linkLabelDeselectAllRequiredMods
            // 
            this.linkLabelDeselectAllRequiredMods.AutoSize = true;
            this.linkLabelDeselectAllRequiredMods.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelDeselectAllRequiredMods.Location = new System.Drawing.Point(199, 10);
            this.linkLabelDeselectAllRequiredMods.Name = "linkLabelDeselectAllRequiredMods";
            this.linkLabelDeselectAllRequiredMods.Size = new System.Drawing.Size(33, 13);
            this.linkLabelDeselectAllRequiredMods.TabIndex = 6;
            this.linkLabelDeselectAllRequiredMods.TabStop = true;
            this.linkLabelDeselectAllRequiredMods.Text = "None";
            this.linkLabelDeselectAllRequiredMods.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelDeselectAllRequiredMods.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelDeselectAllRequiredMods.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDeselectAllRequiredMods_LinkClicked);
            // 
            // linkLabelSelectAllOptionalMods
            // 
            this.linkLabelSelectAllOptionalMods.AutoSize = true;
            this.linkLabelSelectAllOptionalMods.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelSelectAllOptionalMods.Location = new System.Drawing.Point(175, 10);
            this.linkLabelSelectAllOptionalMods.Name = "linkLabelSelectAllOptionalMods";
            this.linkLabelSelectAllOptionalMods.Size = new System.Drawing.Size(18, 13);
            this.linkLabelSelectAllOptionalMods.TabIndex = 7;
            this.linkLabelSelectAllOptionalMods.TabStop = true;
            this.linkLabelSelectAllOptionalMods.Text = "All";
            this.linkLabelSelectAllOptionalMods.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelSelectAllOptionalMods.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelSelectAllOptionalMods.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectAllOptionalMods_LinkClicked);
            // 
            // linkLabelSelectAllRequiredMods
            // 
            this.linkLabelSelectAllRequiredMods.AutoSize = true;
            this.linkLabelSelectAllRequiredMods.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelSelectAllRequiredMods.Location = new System.Drawing.Point(175, 10);
            this.linkLabelSelectAllRequiredMods.Name = "linkLabelSelectAllRequiredMods";
            this.linkLabelSelectAllRequiredMods.Size = new System.Drawing.Size(18, 13);
            this.linkLabelSelectAllRequiredMods.TabIndex = 7;
            this.linkLabelSelectAllRequiredMods.TabStop = true;
            this.linkLabelSelectAllRequiredMods.Text = "All";
            this.linkLabelSelectAllRequiredMods.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelSelectAllRequiredMods.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelSelectAllRequiredMods.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectAllRequiredMods_LinkClicked);
            // 
            // btnRemoveFromRequiredMods
            // 
            this.btnRemoveFromRequiredMods.Location = new System.Drawing.Point(3, 49);
            this.btnRemoveFromRequiredMods.Name = "btnRemoveFromRequiredMods";
            this.btnRemoveFromRequiredMods.Size = new System.Drawing.Size(82, 40);
            this.btnRemoveFromRequiredMods.TabIndex = 2;
            this.btnRemoveFromRequiredMods.Text = "←";
            this.btnRemoveFromRequiredMods.UseVisualStyleBackColor = true;
            this.btnRemoveFromRequiredMods.Click += new System.EventHandler(this.btnRemoveFromRequiredMods_Click);
            // 
            // btnRemoveFromOptionalMods
            // 
            this.btnRemoveFromOptionalMods.Location = new System.Drawing.Point(3, 49);
            this.btnRemoveFromOptionalMods.Name = "btnRemoveFromOptionalMods";
            this.btnRemoveFromOptionalMods.Size = new System.Drawing.Size(82, 40);
            this.btnRemoveFromOptionalMods.TabIndex = 2;
            this.btnRemoveFromOptionalMods.Text = "←";
            this.btnRemoveFromOptionalMods.UseVisualStyleBackColor = true;
            this.btnRemoveFromOptionalMods.Click += new System.EventHandler(this.btnRemoveFromOptionalMods_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 874);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "SRM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAllRepositoriesToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabelSelectAllMods;
        private System.Windows.Forms.LinkLabel linkLabelDeselectAllMods;
        private System.Windows.Forms.Button buttonBrowseRepoIcon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRepoIcon;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAddToOptionalMods;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddToRequiredMods;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox listBoxOptionalMods;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listBoxRequiredMods;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabelSelectAllOptionalMods;
        private System.Windows.Forms.LinkLabel linkLabelDeselectAllOptionalMods;
        private System.Windows.Forms.LinkLabel linkLabelSelectAllRequiredMods;
        private System.Windows.Forms.LinkLabel linkLabelDeselectAllRequiredMods;
        private System.Windows.Forms.Button btnRemoveFromOptionalMods;
        private System.Windows.Forms.Button btnRemoveFromRequiredMods;
    }
}

