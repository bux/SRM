namespace SRM.Forms
{
    partial class SettingsForm
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
            this.textBoxPathSwiftyCli = new System.Windows.Forms.TextBox();
            this.buttonBrowseSwiftyCli = new System.Windows.Forms.Button();
            this.labelPathSwiftyCli = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPathModsFolder = new System.Windows.Forms.Label();
            this.textBoxPathModsFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowsePathModsFolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPathSwiftyCli
            // 
            this.textBoxPathSwiftyCli.Location = new System.Drawing.Point(115, 22);
            this.textBoxPathSwiftyCli.Name = "textBoxPathSwiftyCli";
            this.textBoxPathSwiftyCli.Size = new System.Drawing.Size(261, 20);
            this.textBoxPathSwiftyCli.TabIndex = 0;
            // 
            // buttonBrowseSwiftyCli
            // 
            this.buttonBrowseSwiftyCli.Location = new System.Drawing.Point(382, 20);
            this.buttonBrowseSwiftyCli.Name = "buttonBrowseSwiftyCli";
            this.buttonBrowseSwiftyCli.Size = new System.Drawing.Size(30, 23);
            this.buttonBrowseSwiftyCli.TabIndex = 1;
            this.buttonBrowseSwiftyCli.Text = "...";
            this.buttonBrowseSwiftyCli.UseVisualStyleBackColor = true;
            this.buttonBrowseSwiftyCli.Click += new System.EventHandler(this.buttonBrowseSwiftyCli_Click);
            // 
            // labelPathSwiftyCli
            // 
            this.labelPathSwiftyCli.AutoSize = true;
            this.labelPathSwiftyCli.Location = new System.Drawing.Point(6, 25);
            this.labelPathSwiftyCli.Name = "labelPathSwiftyCli";
            this.labelPathSwiftyCli.Size = new System.Drawing.Size(103, 13);
            this.labelPathSwiftyCli.TabIndex = 2;
            this.labelPathSwiftyCli.Text = "Path to swifty-cli.exe";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 185);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPathSwiftyCli);
            this.groupBox1.Controls.Add(this.textBoxPathSwiftyCli);
            this.groupBox1.Controls.Add(this.buttonBrowseSwiftyCli);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Swifty";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(362, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelPathModsFolder);
            this.groupBox2.Controls.Add(this.textBoxPathModsFolder);
            this.groupBox2.Controls.Add(this.buttonBrowsePathModsFolder);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mods";
            // 
            // labelPathModsFolder
            // 
            this.labelPathModsFolder.AutoSize = true;
            this.labelPathModsFolder.Location = new System.Drawing.Point(6, 25);
            this.labelPathModsFolder.Name = "labelPathModsFolder";
            this.labelPathModsFolder.Size = new System.Drawing.Size(102, 13);
            this.labelPathModsFolder.TabIndex = 2;
            this.labelPathModsFolder.Text = "Path to Mods Folder";
            // 
            // textBoxPathModsFolder
            // 
            this.textBoxPathModsFolder.Location = new System.Drawing.Point(115, 22);
            this.textBoxPathModsFolder.Name = "textBoxPathModsFolder";
            this.textBoxPathModsFolder.Size = new System.Drawing.Size(261, 20);
            this.textBoxPathModsFolder.TabIndex = 0;
            // 
            // buttonBrowsePathModsFolder
            // 
            this.buttonBrowsePathModsFolder.Location = new System.Drawing.Point(382, 20);
            this.buttonBrowsePathModsFolder.Name = "buttonBrowsePathModsFolder";
            this.buttonBrowsePathModsFolder.Size = new System.Drawing.Size(30, 23);
            this.buttonBrowsePathModsFolder.TabIndex = 1;
            this.buttonBrowsePathModsFolder.Text = "...";
            this.buttonBrowsePathModsFolder.UseVisualStyleBackColor = true;
            this.buttonBrowsePathModsFolder.Click += new System.EventHandler(this.buttonBrowsePathModsFolder_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 185);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPathSwiftyCli;
        private System.Windows.Forms.Button buttonBrowseSwiftyCli;
        private System.Windows.Forms.Label labelPathSwiftyCli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPathModsFolder;
        private System.Windows.Forms.TextBox textBoxPathModsFolder;
        private System.Windows.Forms.Button buttonBrowsePathModsFolder;
    }
}