using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            LoadSettings();
        }

        private void LoadSettings()
        {
            DigitsTextBox.Text = Properties.Settings.Default.Digits.ToString();
            SpecialTextBox.Text = Properties.Settings.Default.Special;
            UppercaseTextBox.Text = Properties.Settings.Default.Uppercase;
            LowerTextBox.Text = Properties.Settings.Default.Lowercase;

            if (Properties.Settings.Default.Language == "ru")
                radioButton2.Checked = true;
            else
                radioButton1.Checked = true;
        }

        private void SaveGenerationSettings(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Digits = DigitsTextBox.Text;
            Properties.Settings.Default.Special = SpecialTextBox.Text;
            Properties.Settings.Default.Uppercase = UppercaseTextBox.Text;
            Properties.Settings.Default.Lowercase = LowerTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void SaveLanguageSettings(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                Properties.Settings.Default.Language = "ru";
            else
                Properties.Settings.Default.Language = "en";

            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
