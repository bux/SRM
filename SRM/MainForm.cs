using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using SRM.ViewModels;

namespace SRM
{
    public partial class MainForm : Form
    {
        private readonly ProfileManager _profileManager;
        private readonly RepoManager _repoManager;
        private readonly SettingsManager _settingsManager;
        private RepoProfileViewModel _activeProfile;

        private BindingList<string> _modDirectories;

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

            var repoProfile = _settings?.RepoProfiles.FirstOrDefault();
            SwitchProfile(repoProfile?.GetViewModelFromData());
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
            listBoxRequiredMods.Enabled = _activeProfile != null;
            listBoxRequiredMods.Enabled = _activeProfile != null;
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

            _modDirectories = new BindingList<string>(allDirs.Select(p => p.Name).ToList());

            if (_activeProfile != null)
            {
                listBoxRequiredMods.DataSource = _activeProfile.Repository.Mods;
                listBoxOptionalMods.DataSource = _activeProfile.Repository.OptionalMods;

                var modsToRemove = new List<string>();

                foreach (var dirInfo in allDirs)
                {
                    if (_activeProfile.Repository.Mods.Contains(dirInfo.Name) || _activeProfile.Repository.OptionalMods.Contains(dirInfo.Name))
                    {
                        modsToRemove.Add(dirInfo.Name);
                    }
                }

                foreach (var modToRemove in modsToRemove)
                {
                    _modDirectories.Remove(modToRemove);
                }
            }

            var source = new BindingSource {DataSource = _modDirectories};

            listBoxAllMods.DataSource = source;
            listBoxAllMods.SelectedIndex = -1;
            listBoxAllMods.DisplayMember = nameof(di.Name);
        }

        private void SwitchProfile(RepoProfileViewModel profile)
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

        private bool IsRepoValid(RepoProfileViewModel profile)
        {
            var repoValid = ValidationHelper.IsRepoValid(profile.GetDataFromViewModel());
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
        }

        private void MoveListBoxItems(ListBox sourceListBox, BindingList<string> sourceList, ListBox targetListBox, BindingList<string> targetList)
        {
            var modsToRemove = new List<string>();
            foreach (string selectedMod in sourceListBox.SelectedItems)
            {
                targetList.Add(selectedMod);
                modsToRemove.Add(selectedMod);
            }

            var sortedList = targetList.OrderBy(p => p).ToList();

            targetList = new BindingList<string>(sortedList);

            foreach (var modToRemove in modsToRemove)
            {
                sourceList.Remove(modToRemove);
            }
        }

        private void SelectAllListBoxEntries(ListBox listBox)
        {
            for (var i = 0; i < listBox.Items.Count; i++)
            {
                listBox.SetSelected(i, true);
            }
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Text = $"{Text} - {assemblyVersion}";
        }

        private void profileMenuItem_Click(object sender, EventArgs e)
        {
            // Get Profile by Name
            var profile = _settings.RepoProfiles.Single(p => p.Name.Equals(sender.ToString(), StringComparison.OrdinalIgnoreCase));
            SwitchProfile(profile.GetViewModelFromData());
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

                    SwitchProfile(profile.GetViewModelFromData());
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
                    var renamedProfile = _profileManager.RenameProfile(_activeProfile.GetDataFromViewModel(), renameProfileForm.NewProfileName);
                    _activeProfile = renamedProfile.GetViewModelFromData();
                    _settingsManager.SaveSettings(_settings);

                    SwitchProfile(_activeProfile);
                }
            }
        }

        private void duplicateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var duplicatedProfile = _profileManager.DuplicateProfile(_activeProfile.GetDataFromViewModel());

            _profileManager.AddProfile(_settings, duplicatedProfile);

            _settingsManager.SaveSettings(_settings);

            SwitchProfile(duplicatedProfile.GetViewModelFromData());
        }

        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this profile", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _settings.RepoProfiles.Remove(_activeProfile.GetDataFromViewModel());
                _settingsManager.SaveSettings(_settings);
                var repoProfile = _settings.RepoProfiles.FirstOrDefault();
                SwitchProfile(repoProfile.GetViewModelFromData());
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
            CreateRepository(_activeProfile.GetDataFromViewModel());
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
                // TODO Log
            {
                CreateRepository(validProfile);
            }
        }

        private void btnAddToRequiredMods_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(listBoxAllMods, _modDirectories, listBoxRequiredMods, _activeProfile.Repository.Mods);
            listBoxAllMods.SelectedItems.Clear();
            listBoxRequiredMods.SelectedItems.Clear();
        }

        private void btnRemoveFromRequiredMods_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(listBoxRequiredMods, _activeProfile.Repository.Mods, listBoxAllMods, _modDirectories);
            listBoxRequiredMods.SelectedItems.Clear();
            listBoxAllMods.SelectedItems.Clear();
        }

        private void btnAddToOptionalMods_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(listBoxAllMods, _modDirectories, listBoxOptionalMods, _activeProfile.Repository.OptionalMods);
            listBoxAllMods.SelectedItems.Clear();
            listBoxOptionalMods.SelectedItems.Clear();
        }

        private void btnRemoveFromOptionalMods_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(listBoxOptionalMods, _activeProfile.Repository.OptionalMods, listBoxAllMods, _modDirectories);
            listBoxOptionalMods.SelectedItems.Clear();
            listBoxAllMods.SelectedItems.Clear();
        }

        private void linkLabelSelectAllMods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectAllListBoxEntries(listBoxAllMods);
        }

        private void linkLabelDeselectAllMods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxAllMods.SelectedItems.Clear();
        }

        private void linkLabelSelectAllRequiredMods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectAllListBoxEntries(listBoxRequiredMods);
        }

        private void linkLabelDeselectAllRequiredMods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxRequiredMods.SelectedItems.Clear();
        }

        private void linkLabelSelectAllOptionalMods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectAllListBoxEntries(listBoxOptionalMods);
        }

        private void linkLabelDeselectAllOptionalMods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxOptionalMods.SelectedItems.Clear();
        }

        #endregion
    }
}
