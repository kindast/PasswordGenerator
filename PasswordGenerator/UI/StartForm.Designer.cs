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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
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
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CopyPasswordToClipboard);
            // 
            // PasswordLbl
            // 
            resources.ApplyResources(this.PasswordLbl, "PasswordLbl");
            this.PasswordLbl.Name = "PasswordLbl";
            // 
            // LowerCheckBox
            // 
            resources.ApplyResources(this.LowerCheckBox, "LowerCheckBox");
            this.LowerCheckBox.Checked = true;
            this.LowerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowerCheckBox.Name = "LowerCheckBox";
            this.LowerCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpperCheckBox
            // 
            resources.ApplyResources(this.UpperCheckBox, "UpperCheckBox");
            this.UpperCheckBox.Checked = true;
            this.UpperCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpperCheckBox.Name = "UpperCheckBox";
            this.UpperCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpecialCheckBox
            // 
            resources.ApplyResources(this.SpecialCheckBox, "SpecialCheckBox");
            this.SpecialCheckBox.Checked = true;
            this.SpecialCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpecialCheckBox.Name = "SpecialCheckBox";
            this.SpecialCheckBox.UseVisualStyleBackColor = true;
            // 
            // CharLbl
            // 
            resources.ApplyResources(this.CharLbl, "CharLbl");
            this.CharLbl.Name = "CharLbl";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9"),
            resources.GetString("comboBox1.Items10"),
            resources.GetString("comboBox1.Items11"),
            resources.GetString("comboBox1.Items12"),
            resources.GetString("comboBox1.Items13"),
            resources.GetString("comboBox1.Items14"),
            resources.GetString("comboBox1.Items15"),
            resources.GetString("comboBox1.Items16"),
            resources.GetString("comboBox1.Items17"),
            resources.GetString("comboBox1.Items18"),
            resources.GetString("comboBox1.Items19"),
            resources.GetString("comboBox1.Items20"),
            resources.GetString("comboBox1.Items21"),
            resources.GetString("comboBox1.Items22")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // LengthLbl
            // 
            resources.ApplyResources(this.LengthLbl, "LengthLbl");
            this.LengthLbl.Name = "LengthLbl";
            // 
            // DigitsCheckBox
            // 
            resources.ApplyResources(this.DigitsCheckBox, "DigitsCheckBox");
            this.DigitsCheckBox.Checked = true;
            this.DigitsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DigitsCheckBox.Name = "DigitsCheckBox";
            this.DigitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateBtn
            // 
            resources.ApplyResources(this.GenerateBtn, "GenerateBtn");
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.Generate);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            resources.ApplyResources(this.historyToolStripMenuItem, "historyToolStripMenuItem");
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.OpenHistory);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateSettingToolStripMenuItem,
            this.languageSettingsToolStripMenuItem,
            this.resetSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // generateSettingToolStripMenuItem
            // 
            this.generateSettingToolStripMenuItem.Name = "generateSettingToolStripMenuItem";
            resources.ApplyResources(this.generateSettingToolStripMenuItem, "generateSettingToolStripMenuItem");
            this.generateSettingToolStripMenuItem.Click += new System.EventHandler(this.OpenGenerationSettings);
            // 
            // languageSettingsToolStripMenuItem
            // 
            this.languageSettingsToolStripMenuItem.Name = "languageSettingsToolStripMenuItem";
            resources.ApplyResources(this.languageSettingsToolStripMenuItem, "languageSettingsToolStripMenuItem");
            this.languageSettingsToolStripMenuItem.Click += new System.EventHandler(this.OpenLanguageSettings);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            resources.ApplyResources(this.resetSettingsToolStripMenuItem, "resetSettingsToolStripMenuItem");
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.ResetSettings);
            // 
            // StartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "StartForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
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

