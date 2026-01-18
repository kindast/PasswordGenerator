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
            this.cbLower = new System.Windows.Forms.CheckBox();
            this.cbUpper = new System.Windows.Forms.CheckBox();
            this.cbSpecial = new System.Windows.Forms.CheckBox();
            this.CharLbl = new System.Windows.Forms.Label();
            this.cbLength = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.LengthLbl = new System.Windows.Forms.Label();
            this.cbDigits = new System.Windows.Forms.CheckBox();
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
            // cbLower
            // 
            resources.ApplyResources(this.cbLower, "cbLower");
            this.cbLower.Checked = true;
            this.cbLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLower.Name = "cbLower";
            this.cbLower.UseVisualStyleBackColor = true;
            // 
            // cbUpper
            // 
            resources.ApplyResources(this.cbUpper, "cbUpper");
            this.cbUpper.Checked = true;
            this.cbUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpper.Name = "cbUpper";
            this.cbUpper.UseVisualStyleBackColor = true;
            // 
            // cbSpecial
            // 
            resources.ApplyResources(this.cbSpecial, "cbSpecial");
            this.cbSpecial.Checked = true;
            this.cbSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.UseVisualStyleBackColor = true;
            // 
            // CharLbl
            // 
            resources.ApplyResources(this.CharLbl, "CharLbl");
            this.CharLbl.Name = "CharLbl";
            // 
            // cbLength
            // 
            this.cbLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbLength, "cbLength");
            this.cbLength.FormattingEnabled = true;
            this.cbLength.Items.AddRange(new object[] {
            resources.GetString("cbLength.Items"),
            resources.GetString("cbLength.Items1"),
            resources.GetString("cbLength.Items2"),
            resources.GetString("cbLength.Items3"),
            resources.GetString("cbLength.Items4"),
            resources.GetString("cbLength.Items5"),
            resources.GetString("cbLength.Items6"),
            resources.GetString("cbLength.Items7"),
            resources.GetString("cbLength.Items8"),
            resources.GetString("cbLength.Items9"),
            resources.GetString("cbLength.Items10"),
            resources.GetString("cbLength.Items11"),
            resources.GetString("cbLength.Items12"),
            resources.GetString("cbLength.Items13"),
            resources.GetString("cbLength.Items14"),
            resources.GetString("cbLength.Items15"),
            resources.GetString("cbLength.Items16"),
            resources.GetString("cbLength.Items17"),
            resources.GetString("cbLength.Items18"),
            resources.GetString("cbLength.Items19"),
            resources.GetString("cbLength.Items20"),
            resources.GetString("cbLength.Items21"),
            resources.GetString("cbLength.Items22"),
            resources.GetString("cbLength.Items23"),
            resources.GetString("cbLength.Items24"),
            resources.GetString("cbLength.Items25"),
            resources.GetString("cbLength.Items26")});
            this.cbLength.Name = "cbLength";
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            // 
            // LengthLbl
            // 
            resources.ApplyResources(this.LengthLbl, "LengthLbl");
            this.LengthLbl.Name = "LengthLbl";
            // 
            // cbDigits
            // 
            resources.ApplyResources(this.cbDigits, "cbDigits");
            this.cbDigits.Checked = true;
            this.cbDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDigits.Name = "cbDigits";
            this.cbDigits.UseVisualStyleBackColor = true;
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
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
            this.Controls.Add(this.cbLower);
            this.Controls.Add(this.cbUpper);
            this.Controls.Add(this.cbSpecial);
            this.Controls.Add(this.CharLbl);
            this.Controls.Add(this.cbLength);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.LengthLbl);
            this.Controls.Add(this.cbDigits);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.CheckBox cbLower;
        private System.Windows.Forms.CheckBox cbUpper;
        private System.Windows.Forms.CheckBox cbSpecial;
        private System.Windows.Forms.Label CharLbl;
        private System.Windows.Forms.ComboBox cbLength;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label LengthLbl;
        private System.Windows.Forms.CheckBox cbDigits;
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

