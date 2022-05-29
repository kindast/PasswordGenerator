using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void SaveGenerationSettings(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Digits = DigitsTextBox.Text;
            Properties.Settings.Default.Special = SpecialTextBox.Text;
            Properties.Settings.Default.Uppercase = UppercaseTextBox.Text;
            Properties.Settings.Default.Lowercase = LowerTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
