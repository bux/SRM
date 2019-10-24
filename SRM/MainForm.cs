using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using SRM.Forms;
using SRM.Logic.Classes;
using SRM.Logic.Enums;
using SRM.Logic.Helpers;
using SRM.Logic.Managers;

namespace SRM
{
    public partial class MainForm : Form
    {
        private readonly ProfileManager _profileManager;
        private readonly RepoManager _repoManager;
        private readonly SettingsManager _settingsManager;
        private RepoProfile _activeProfile;

        private Settings _settings;

        public MainForm()
        {
            InitializeComponent();
            _settingsManager = new SettingsManager();
            _profileManager = new ProfileManager();
            _repoManager = new RepoManager();

            // Load Settings if available
            _settings = _settingsManager.LoadSettings();

            ListMods();

            SwitchProfile(_settings?.RepoProfiles.FirstOrDefault());
        }

        private void ActivateControls()
        {
            // Menu Strip
            renameProfileToolStripMenuItem.Enabled = _activeProfile != null;
            duplicateProfileToolStripMenuItem.Enabled = _activeProfile != null;
            deleteProfileToolStripMenuItem.Enabled = _activeProfile != null;


            // Controls
            textBoxRepoName.Enabled = _activeProfile != null;

            textBoxClientParameters.Enabled = _activeProfile != null;
            textBoxRepoImage.Enabled = _activeProfile != null;
            textBoxRepoIcon.Enabled = _activeProfile != null;
            textBoxProfileName.Enabled = _activeProfile != null;
            textBoxProfilePath.Enabled = _activeProfile != null;
            textBoxServerAddress.Enabled = _activeProfile != null;
            textBoxServerName.Enabled = _activeProfile != null;
            textBoxServerPassword.Enabled = _activeProfile != null;
            textBoxServerPort.Enabled = _activeProfile != null;

            buttonBrowseProfilePath.Enabled = _activeProfile != null;
            buttonBrowseRepoImage.Enabled = _activeProfile != null;
            buttonBrowseRepoIcon.Enabled = _activeProfile != null;

            buttonSaveProfile.Enabled = _activeProfile != null;
            buttonCreateRepository.Enabled = _activeProfile != null;

            checkBoxServerBattleEye.Enabled = _activeProfile != null;

            listBoxAllMods.Enabled = _activeProfile != null;
        }

        private void FillControls()
        {
            if (_activeProfile == null)
            {
                textBoxRepoName.Text = "";
                textBoxClientParameters.Text = "";
                textBoxRepoImage.Text = "";
                textBoxRepoIcon.Text = "";
                textBoxProfileName.Text = "";
                textBoxProfilePath.Text = "";
                textBoxServerAddress.Text = "";
                textBoxServerName.Text = "";
                textBoxServerPassword.Text = "";
                textBoxServerPort.Text = "";

                checkBoxServerBattleEye.Checked = false;

                return;
            }

            textBoxRepoName.Text = _activeProfile.Repository.Name;
            textBoxClientParameters.Text = _activeProfile.Repository.ClientParams;
            textBoxRepoImage.Text = _activeProfile.Repository.ImagePath;
            textBoxRepoIcon.Text = _activeProfile.Repository.IconPath;
            textBoxProfileName.Text = _activeProfile.Name;
            textBoxProfilePath.Text = _activeProfile.Repository.TargetPath;
            textBoxServerAddress.Text = _activeProfile.Repository.ServerInfo.Address;
            textBoxServerName.Text = _activeProfile.Repository.ServerInfo.Name;
            textBoxServerPassword.Text = _activeProfile.Repository.ServerInfo.Password;
            textBoxServerPort.Text = _activeProfile.Repository.ServerInfo.Port.ToString();

            checkBoxServerBattleEye.Checked = _activeProfile.Repository.ServerInfo.BattleEye;
        }

        private void ListMods()
        {
            listBoxAllMods.ClearSelected();

            if (string.IsNullOrEmpty(_settings.ModsFolderPath))
            {
                return;
            }

            var di = new DirectoryInfo(_settings.ModsFolderPath);
            var allDirs = di.GetDirectories().Where(d => d.Name.StartsWith("@")).ToList();

            listBoxAllMods.DataSource = allDirs;
            listBoxAllMods.SelectedIndex = -1;
            listBoxAllMods.DisplayMember = nameof(di.Name);

            var dirNames = allDirs.Select(d => d.Name.ToLowerInvariant()).ToList();

            if (_activeProfile != null)
            {
                foreach (var mod in _activeProfile.Repository.Mods)
                {
                    if (dirNames.Contains(mod.ToLowerInvariant()))
                    {
                        var index = dirNames.IndexOf(mod.ToLowerInvariant());
                        if (index >= 0)
                        {
                            listBoxAllMods.SetSelected(index, true);
                        }
                    }
                }
            }
        }

        private void SwitchProfile(RepoProfile profile)
        {
            _activeProfile = profile;
            ActivateControls();
            FillControls();
            UpdateProfilesMenuStrip();
            ListMods();
        }

        private void UpdateProfilesMenuStrip()
        {
            profilesToolStripMenuItem.DropDownItems.Clear();

            foreach (var repoProfile in _settings.RepoProfiles)
            {
                profilesToolStripMenuItem.DropDownItems.Add(repoProfile.Name, null, profileMenuItem_Click);
            }
        }


        private void CreateRepository(RepoProfile profile)
        {
            _repoManager.CreateRepository(profile, _settings.ModsFolderPath, _settings.SwiftyCliPath, _settings.RepoSourceFolderPath);
        }

        private bool AreSettingsValid(Settings settings)
        {
            var settingsValid = ValidationHelper.AreSettingsValid(settings);
            if (!settingsValid.HasFlag(SettingsValidation.Valid))
            {
                var sb = new StringBuilder().AppendLine("The settings are not valid and/or missing information");

                if (settingsValid.HasFlag(SettingsValidation.SwiftyCliPathMissing))
                {
                    sb.AppendLine("* Path to swifty-cli.exe missing");
                }

                if (settingsValid.HasFlag(SettingsValidation.ModsFolderPathMissing))
                {
                    sb.AppendLine("* Path to Mods Folder missing");
                }

                if (settingsValid.HasFlag(SettingsValidation.RepoSourceFolderPathMissing))
                {
                    sb.AppendLine("* Path to Repo Source Folder missing");
                }

                MessageBox.Show(sb.ToString(), "Validation Error");
                return false;
            }

            return true;
        }

        private bool IsRepoValid(RepoProfile profile)
        {
            var repoValid = ValidationHelper.IsRepoValid(profile);
            if (!repoValid.HasFlag(RepoValidation.Valid))
            {
                var sb = new StringBuilder().AppendLine("The repository is not valid and/or missing information");

                if (repoValid.HasFlag(RepoValidation.RepoNameMissing))
                {
                    sb.AppendLine("* Repository name is missing");
                }

                if (repoValid.HasFlag(RepoValidation.TargetPathMissing))
                {
                    sb.AppendLine("* Target Path is missing");
                }

                if (repoValid.HasFlag(RepoValidation.ImagePathMissing))
                {
                    sb.AppendLine("* Image Path is missing");
                }

                if (repoValid.HasFlag(RepoValidation.IconPathMissing))
                {
                    sb.AppendLine("* Icon Path is missing");
                }

                if (repoValid.HasFlag(RepoValidation.ModsMissing))
                {
                    sb.AppendLine("* No mods selected");
                }

                MessageBox.Show(sb.ToString(), "Validation Error");
                return false;
            }

            return true;
        }

        private void ReadoutAllValues()
        {
            _activeProfile.Name = textBoxProfileName.Text;

            _activeProfile.Repository.Name = textBoxRepoName.Text;
            _activeProfile.Repository.ImagePath = textBoxRepoImage.Text;
            _activeProfile.Repository.IconPath = textBoxRepoIcon.Text;
            _activeProfile.Repository.ClientParams = textBoxClientParameters.Text;
            _activeProfile.Repository.TargetPath = textBoxProfilePath.Text;
            _activeProfile.Repository.ServerInfo.Address = textBoxServerAddress.Text;
            _activeProfile.Repository.ServerInfo.Name = textBoxServerName.Text;
            _activeProfile.Repository.ServerInfo.Password = textBoxServerPassword.Text;

            var result = int.TryParse(textBoxServerPort.Text, out var portResult) ? portResult : 2302;
            _activeProfile.Repository.ServerInfo.Port = result;

            _activeProfile.Repository.ServerInfo.BattleEye = checkBoxServerBattleEye.Checked;


            _activeProfile.Repository.Mods.Clear();
            foreach (var selectedItem in listBoxAllMods.SelectedItems)
            {
                _activeProfile.Repository.Mods.Add(selectedItem.ToString());
            }
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = $"{this.Text} - {assemblyVersion}";
        }

        private void profileMenuItem_Click(object sender, EventArgs e)
        {
            // Get Profile by Name
            var profile = _settings.RepoProfiles.Single(p => p.Name.Equals(sender.ToString(), StringComparison.OrdinalIgnoreCase));
            SwitchProfile(profile);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm(_settings))
            {
                settingsForm.ShowDialog(this);
                if (settingsForm.DialogResult == DialogResult.OK)
                {
                    _settings = settingsForm.Settings;
                    _settingsManager.SaveSettings(_settings);
                    ListMods();
                }
            }
        }

        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var addProfileForm = new AddProfileForm(_settings))
            {
                addProfileForm.ShowDialog(this);
                if (addProfileForm.DialogResult == DialogResult.OK)
                {
                    var profile = _profileManager.CreateProfile(addProfileForm.ProfileName);
                    _profileManager.AddProfile(_settings, profile);

                    _settingsManager.SaveSettings(_settings);

                    SwitchProfile(profile);
                }
            }
        }

        private void renameProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var renameProfileForm = new RenameProfileForm(_settings, _activeProfile.Name))
            {
                renameProfileForm.ShowDialog(this);
                if (renameProfileForm.DialogResult == DialogResult.OK)
                {
                    ReadoutAllValues();
                    _activeProfile = _profileManager.RenameProfile(_activeProfile, renameProfileForm.NewProfileName);
                    _settingsManager.SaveSettings(_settings);

                    SwitchProfile(_activeProfile);
                }
            }
        }

        private void duplicateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var duplicatedProfile = _profileManager.DuplicateProfile(_activeProfile);
            _profileManager.AddProfile(_settings, duplicatedProfile);

            _settingsManager.SaveSettings(_settings);

            SwitchProfile(duplicatedProfile);
        }

        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this profile", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _settings.RepoProfiles.Remove(_activeProfile);
                _settingsManager.SaveSettings(_settings);
                SwitchProfile(_settings.RepoProfiles.FirstOrDefault());
            }
        }

        private void buttonBrowseProfilePath_Click(object sender, EventArgs e)
        {
            var folderDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                DefaultDirectory = string.IsNullOrEmpty(_activeProfile.Repository.TargetPath) ? "" : _activeProfile.Repository.TargetPath
            };

            if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBoxProfilePath.Text = folderDialog.FileName;
                _activeProfile.Repository.TargetPath = folderDialog.FileName;
            }
        }

        private void buttonBrowseRepoImage_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = "Repository Image|*.png"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxRepoImage.Text = fileDialog.FileName;
            }
        }

        private void buttonBrowseRepoIcon_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = "Repository Icon|*.png"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxRepoIcon.Text = fileDialog.FileName;
            }
        }

        private void buttonSaveProfile_Click(object sender, EventArgs e)
        {
            ReadoutAllValues();

            _settingsManager.SaveSettings(_settings);
        }

        private void buttonCreateRepository_Click(object sender, EventArgs e)
        {
            // Validate

            if (!AreSettingsValid(_settings))
            {
                return;
            }

            if (!IsRepoValid(_activeProfile))
            {
                return;
            }

            var confirmResult = MessageBox.Show("Creating a repository will delete all contents from the target path. Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            _settingsManager.SaveSettings(_settings);
            CreateRepository(_activeProfile);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createAllRepositoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Creating all repositories will delete all contents from their target paths. Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            if (!AreSettingsValid(_settings))
            {
                return;
            }

            var validProfiles = _settings.RepoProfiles.Where(p => ValidationHelper.IsRepoValid(p).HasFlag(RepoValidation.Valid));

            foreach (var validProfile in validProfiles)
            {
                // TODO Log
                CreateRepository(validProfile);
            }
        }

        private void linkLabelSelectAllMods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (var i = 0; i < listBoxAllMods.Items.Count; i++)
            {
                listBoxAllMods.SetSelected(i, true);
            }
        }

        private void linkLabelDeselectAllMods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxAllMods.SelectedItems.Clear();
        }

        #endregion

        
    }
}
