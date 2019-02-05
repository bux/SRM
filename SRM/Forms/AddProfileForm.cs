using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SRM.Helpers;
using SRM.Logic.Classes;

namespace SRM.Forms
{
    public partial class AddProfileForm : Form
    {
        private readonly Settings _settings;

        public AddProfileForm(Settings settings)
        {
            _settings = settings;
            InitializeComponent();
        }

        public string ProfileName { get; set; }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private bool IsProfileNameValid(string newProfileName)
        {
            return ValidationHelper.IsProfileNameValid(_settings.RepoProfiles, newProfileName);
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
                MessageBox.Show("Profile Name is not valid or already used", "Validation Error");
                textBoxProfileName.BackColor = Color.RosyBrown;
                return;
            }

            ProfileName = textBoxProfileName.Text;
            DialogResult = DialogResult.OK;
            textBoxProfileName.BackColor = Color.White;
            Close();
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
