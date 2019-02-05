using System;
using System.Drawing;
using System.Windows.Forms;
using SRM.Helpers;
using SRM.Logic.Classes;

namespace SRM.Forms
{
    public partial class RenameProfileForm : Form
    {
        private readonly Settings _settings;

        public RenameProfileForm(Settings settings, string currentProfileName)
        {
            _settings = settings;
            InitializeComponent();
            textBoxProfileName.Text = currentProfileName;
        }

        public string NewProfileName { get; set; }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Result();
        }

        private void Result()
        {
            // Validation
            var valid = IsProfileNameValid(textBoxProfileName.Text);

            if (!valid)
            {
                MessageBox.Show("Profile Name is not valid", "Validation Error");
                textBoxProfileName.BackColor = Color.RosyBrown;
                return;
            }

            NewProfileName = textBoxProfileName.Text;
            DialogResult = DialogResult.OK;
            textBoxProfileName.BackColor = Color.White;
            Close();
        }

        private bool IsProfileNameValid(string newProfileName)
        {
            return ValidationHelper.IsProfileNameValid(_settings.RepoProfiles, newProfileName);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxProfileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Result();
            }
        }
    }
}
