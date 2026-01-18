using PasswordGenerator.Properties;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class StartForm : Form
    {
        private readonly Classes.PasswordGenerator _passwordGenerator;

        public StartForm()
        {
            if (string.IsNullOrEmpty(Settings.Default.Language))
            {
                Settings.Default.Reset();

                string culture = CultureInfo.CurrentUICulture.Name;

                if (culture.StartsWith("ru"))
                    Settings.Default.Language = "ru";
                else
                    Settings.Default.Language = "en";

                Settings.Default.Save();
            }

            Thread.CurrentThread.CurrentCulture = new CultureInfo(Settings.Default.Language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.Language);

            InitializeComponent();
            _passwordGenerator = new Classes.PasswordGenerator(Settings.Default.Digits,
                Settings.Default.Lowercase, Settings.Default.Uppercase, Settings.Default.Special);

            cbLength.SelectedIndex = 0;
        }



        private void OpenHistory(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void OpenSettings(int TabControlIndex)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.tabControl1.SelectedIndex = TabControlIndex;
            settingsForm.ShowDialog();
        }

        private void OpenGenerationSettings(object sender, EventArgs e)
        {
            OpenSettings(0);
        }

        private void OpenLanguageSettings(object sender, EventArgs e)
        {
            OpenSettings(1);
        }


        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.History = "";
            Settings.Default.Save();
        }

        private void CopyPasswordToClipboard(object sender, EventArgs e)
        {
            if (tbPassword.Text == string.Empty)
                tbPassword.Text = GeneratePassword();

            Clipboard.SetText(tbPassword.Text);
        }

        private void Generate(object sender, EventArgs e)
        {
            tbPassword.Text = GeneratePassword();
        }

        private string GeneratePassword()
        {
            string password = _passwordGenerator.Generate(int.Parse(cbLength.Text),
                cbDigits.Checked, cbLower.Checked, cbUpper.Checked, cbSpecial.Checked);
            Settings.Default.History += password + "\n";
            return password;
        }

        private void ResetSettings(object sender, EventArgs e)
        {
            Settings.Default.Language = "";
            Settings.Default.Save();

            Application.Restart();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
