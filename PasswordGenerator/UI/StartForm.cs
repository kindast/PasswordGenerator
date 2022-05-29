using System;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            Properties.Settings.Default.Reset();
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

        private void GeneratePassword(object sender, EventArgs e)
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < Convert.ToInt32(comboBox1.Text); i++)
            {
                int choiceTypeOfChar = random.Next(1, 5);
                int choiceChar;
                switch (choiceTypeOfChar)
                {
                    case 1:
                        choiceChar = random.Next(0, Properties.Settings.Default.Digits.Length);
                        password.Append(Properties.Settings.Default.Digits[choiceChar]);
                        break;

                    case 2:
                        choiceChar = random.Next(0, Properties.Settings.Default.Special.Length);
                        password.Append(Properties.Settings.Default.Special[choiceChar]);
                        break;

                    case 3:
                        choiceChar = random.Next(0, Properties.Settings.Default.Uppercase.Length);
                        password.Append(Properties.Settings.Default.Uppercase[choiceChar]);
                        break;

                    case 4:
                        choiceChar = random.Next(0, Properties.Settings.Default.Lowercase.Length);
                        password.Append(Properties.Settings.Default.Lowercase[choiceChar]);
                        break;
                }
            }

            Properties.Settings.Default.History += $"{password.ToString()}\n";
            textBox1.Text = password.ToString();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.History = "";
            Properties.Settings.Default.Save();
        }
    }
}
