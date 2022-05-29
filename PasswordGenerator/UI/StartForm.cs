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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            Properties.Settings.Default.Reset();
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
        }
    }
}
