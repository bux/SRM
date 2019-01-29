using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using SRM.Classes;

namespace SRM.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(Settings settings)
        {
            InitializeComponent();
            Settings = settings;

            FillSettings();
        }

        public Settings Settings { get; }


        private void FillSettings()
        {
            if (!string.IsNullOrEmpty(Settings.SwiftyCliPath))
            {
                textBoxPathSwiftyCli.Text = Settings.SwiftyCliPath;
            }
            if (!string.IsNullOrEmpty(Settings.ModsFolderPath))
            {
                textBoxPathModsFolder.Text = Settings.ModsFolderPath;
            }
        }


        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            var swiftyValid = IsSwiftyValid();
            var modsFolderValid = IsModsFolderValid();

            if (!swiftyValid)
            {
                MessageBox.Show("Path to swifty-cli is not valid", "Validation Error");
                textBoxPathSwiftyCli.BackColor = Color.RosyBrown;
            }

            if (!modsFolderValid)
            {
                MessageBox.Show("Path to Mods Folder is not valid", "Validation Error");
                textBoxPathModsFolder.BackColor = Color.RosyBrown;
            }

            if (!swiftyValid || !modsFolderValid)
            {
                return;
            }

            textBoxPathSwiftyCli.BackColor = Color.Empty;
            textBoxPathModsFolder.BackColor = Color.Empty;

            Settings.SwiftyCliPath = textBoxPathSwiftyCli.Text;
            Settings.ModsFolderPath = textBoxPathModsFolder.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonBrowseSwiftyCli_Click(object sender, EventArgs e)
        {
            var defaultPath = "";
            if (!string.IsNullOrEmpty(Settings.SwiftyCliPath))
            {
                var fi = new FileInfo(Settings.SwiftyCliPath);
                if (fi.Exists && fi.Directory.Exists)
                {
                    defaultPath = fi.DirectoryName;
                }
            }

            var fileDialog = new OpenFileDialog
            {
                Filter = "Swifty CLI|swifty-cli.exe",
                InitialDirectory = defaultPath
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPathSwiftyCli.Text = fileDialog.FileName;
            }
        }

        private void buttonBrowsePathModsFolder_Click(object sender, EventArgs e)
        {
            var folderDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                DefaultDirectory = string.IsNullOrEmpty(Settings.ModsFolderPath) ? "" : Settings.ModsFolderPath
            };

            if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBoxPathModsFolder.Text = folderDialog.FileName;
            }
        }

        #endregion

        #region Validation


        private bool IsModsFolderValid()
        {
            if (string.IsNullOrEmpty(textBoxPathModsFolder.Text))
            {
                return false;
            }

            var directoryInfoMods = new DirectoryInfo(textBoxPathModsFolder.Text);
            if (!directoryInfoMods.Exists)
            {
                return false;
            }

            return true;
        }

        private bool IsSwiftyValid()
        {
            if (string.IsNullOrEmpty(textBoxPathSwiftyCli.Text))
            {
                return false;
            }

            var fileInfoSwifty = new FileInfo(textBoxPathSwiftyCli.Text);
            if (!fileInfoSwifty.Exists || !fileInfoSwifty.Name.Contains(Constants.SwiftyCliName))
            {
                return false;
            }

            return true;
        }


        #endregion


    }
}
