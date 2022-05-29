namespace PasswordGenerator
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.LowerCheckBox = new System.Windows.Forms.CheckBox();
            this.UpperCheckBox = new System.Windows.Forms.CheckBox();
            this.SpecialCheckBox = new System.Windows.Forms.CheckBox();
            this.CharLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LengthLbl = new System.Windows.Forms.Label();
            this.DigitsCheckBox = new System.Windows.Forms.CheckBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(232, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.PasswordLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordLbl.Location = new System.Drawing.Point(16, 224);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(59, 15);
            this.PasswordLbl.TabIndex = 22;
            this.PasswordLbl.Text = "Password";
            // 
            // LowerCheckBox
            // 
            this.LowerCheckBox.AutoSize = true;
            this.LowerCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LowerCheckBox.Location = new System.Drawing.Point(16, 192);
            this.LowerCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.LowerCheckBox.Name = "LowerCheckBox";
            this.LowerCheckBox.Size = new System.Drawing.Size(142, 17);
            this.LowerCheckBox.TabIndex = 21;
            this.LowerCheckBox.Text = "Lowercase Letters (a - z)";
            this.LowerCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpperCheckBox
            // 
            this.UpperCheckBox.AutoSize = true;
            this.UpperCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UpperCheckBox.Location = new System.Drawing.Point(16, 168);
            this.UpperCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpperCheckBox.Name = "UpperCheckBox";
            this.UpperCheckBox.Size = new System.Drawing.Size(145, 17);
            this.UpperCheckBox.TabIndex = 20;
            this.UpperCheckBox.Text = "Uppercase Letters (A - Z)";
            this.UpperCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpecialCheckBox
            // 
            this.SpecialCheckBox.AutoSize = true;
            this.SpecialCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SpecialCheckBox.Location = new System.Drawing.Point(16, 144);
            this.SpecialCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.SpecialCheckBox.Name = "SpecialCheckBox";
            this.SpecialCheckBox.Size = new System.Drawing.Size(151, 17);
            this.SpecialCheckBox.TabIndex = 19;
            this.SpecialCheckBox.Text = "Special Characters ($!#@)";
            this.SpecialCheckBox.UseVisualStyleBackColor = true;
            // 
            // CharLbl
            // 
            this.CharLbl.AutoSize = true;
            this.CharLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CharLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CharLbl.Location = new System.Drawing.Point(16, 96);
            this.CharLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CharLbl.Name = "CharLbl";
            this.CharLbl.Size = new System.Drawing.Size(97, 15);
            this.CharLbl.TabIndex = 18;
            this.CharLbl.Text = "Used Characters";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.comboBox1.Location = new System.Drawing.Point(16, 56);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(410, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 248);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LengthLbl
            // 
            this.LengthLbl.AutoSize = true;
            this.LengthLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LengthLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LengthLbl.Location = new System.Drawing.Point(16, 32);
            this.LengthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LengthLbl.Name = "LengthLbl";
            this.LengthLbl.Size = new System.Drawing.Size(46, 15);
            this.LengthLbl.TabIndex = 14;
            this.LengthLbl.Text = "Length";
            // 
            // DigitsCheckBox
            // 
            this.DigitsCheckBox.AutoSize = true;
            this.DigitsCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DigitsCheckBox.Location = new System.Drawing.Point(16, 120);
            this.DigitsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.DigitsCheckBox.Name = "DigitsCheckBox";
            this.DigitsCheckBox.Size = new System.Drawing.Size(76, 17);
            this.DigitsCheckBox.TabIndex = 13;
            this.DigitsCheckBox.Text = "Digits (0-9)";
            this.DigitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GenerateBtn.Location = new System.Drawing.Point(128, 280);
            this.GenerateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(88, 26);
            this.GenerateBtn.TabIndex = 12;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(443, 25);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateSettingToolStripMenuItem,
            this.languageSettingsToolStripMenuItem,
            this.resetSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // generateSettingToolStripMenuItem
            // 
            this.generateSettingToolStripMenuItem.Name = "generateSettingToolStripMenuItem";
            this.generateSettingToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.generateSettingToolStripMenuItem.Text = "Generation Settings";
            // 
            // languageSettingsToolStripMenuItem
            // 
            this.languageSettingsToolStripMenuItem.Name = "languageSettingsToolStripMenuItem";
            this.languageSettingsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.languageSettingsToolStripMenuItem.Text = "Language Settings";
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.resetSettingsToolStripMenuItem.Text = "Reset Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LowerCheckBox);
            this.Controls.Add(this.UpperCheckBox);
            this.Controls.Add(this.SpecialCheckBox);
            this.Controls.Add(this.CharLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LengthLbl);
            this.Controls.Add(this.DigitsCheckBox);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "PasswordGenerator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.CheckBox LowerCheckBox;
        private System.Windows.Forms.CheckBox UpperCheckBox;
        private System.Windows.Forms.CheckBox SpecialCheckBox;
        private System.Windows.Forms.Label CharLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LengthLbl;
        private System.Windows.Forms.CheckBox DigitsCheckBox;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
    }
}

