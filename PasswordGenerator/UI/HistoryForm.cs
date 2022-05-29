﻿using System;
using System.IO;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            richTextBox1.Text = Properties.Settings.Default.History;
        }

        private void ClearHistory(object sender, EventArgs e)
        {
            Properties.Settings.Default.History = string.Empty;
            Properties.Settings.Default.Save();

            richTextBox1.Text = string.Empty;
        }

        private void SaveHistoryToFile(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = $"txt files (*.txt)|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string FilePath = fileDialog.FileName;
                File.WriteAllText(FilePath, richTextBox1.Text);
            }
        }
    }
}
