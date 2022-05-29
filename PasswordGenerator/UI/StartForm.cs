using System;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                Properties.Settings.Default.Reset();

                string Culture = System.Globalization.CultureInfo.CurrentUICulture.Name;

                if (Culture.StartsWith("ru"))
                    Properties.Settings.Default.Language = "ru";
                else
                    Properties.Settings.Default.Language = "en";

                Properties.Settings.Default.Save();
            }

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.Language);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.Language);

            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }
        
        

        private void OpenHistory(object sender, EventArgs e)
        {
            HistoryForm History = new HistoryForm();
            History.ShowDialog();
        }

        private void OpenSettings(int TabControlIndex)
        {
            SettingsForm settings = new SettingsForm();
            settings.tabControl1.SelectedIndex = TabControlIndex;
            settings.ShowDialog();
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
            Properties.Settings.Default.History = "";
            Properties.Settings.Default.Save();
        }

        private void CopyPasswordToClipboard(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                textBox1.Text = GeneratePassword();

            Clipboard.SetText(textBox1.Text);
        }

        private string GeneratePassword()
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            while (password.Length < Convert.ToInt32(comboBox1.Text))
            {
                int choiceTypeOfChar = random.Next(1, 5);
                int choiceChar;
                switch (choiceTypeOfChar)
                {
                    case 1:
                        if (DigitsCheckBox.Checked)
                        {
                            choiceChar = random.Next(0, Properties.Settings.Default.Digits.Length);
                            password.Append(Properties.Settings.Default.Digits[choiceChar]);
                        }
                        break;

                    case 2:
                        if (SpecialCheckBox.Checked)
                        {
                            choiceChar = random.Next(0, Properties.Settings.Default.Special.Length);
                            password.Append(Properties.Settings.Default.Special[choiceChar]);
                        }
                        break;

                    case 3:
                        if (UpperCheckBox.Checked)
                        {
                            choiceChar = random.Next(0, Properties.Settings.Default.Uppercase.Length);
                            password.Append(Properties.Settings.Default.Uppercase[choiceChar]);
                        }
                        break;

                    case 4:
                        if (LowerCheckBox.Checked)
                        {
                            choiceChar = random.Next(0, Properties.Settings.Default.Lowercase.Length);
                            password.Append(Properties.Settings.Default.Lowercase[choiceChar]);
                        }
                        break;
                }
            }

            Properties.Settings.Default.History += $"{password.ToString()}\n";
            return password.ToString();
        }

        private void Generate(object sender, EventArgs e)
        {
            textBox1.Text = GeneratePassword();
        }

        private void ResetSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "";
            Properties.Settings.Default.Save();

            Application.Restart();
        }
    }
}
