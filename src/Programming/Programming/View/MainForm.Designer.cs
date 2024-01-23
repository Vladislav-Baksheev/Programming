namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnumsGroupBox = new GroupBox();
            EnumsListBox = new ListBox();
            IntValueTextBox = new TextBox();
            ValueListBox = new ListBox();
            IntValueLabel = new Label();
            ChooseValueLabel = new Label();
            EnumsLabel = new Label();
            tabControl1 = new TabControl();
            EnumsTabPage = new TabPage();
            SeasonGroupBox = new GroupBox();
            GoButton = new Button();
            SeasonComboBox = new ComboBox();
            label2 = new Label();
            ParsingGroupBox = new GroupBox();
            WeekdayLabel = new Label();
            ParseButton = new Button();
            ParseTextBox = new TextBox();
            label1 = new Label();
            EnumsGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            ParsingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsGroupBox
            // 
            EnumsGroupBox.Controls.Add(EnumsListBox);
            EnumsGroupBox.Controls.Add(IntValueTextBox);
            EnumsGroupBox.Controls.Add(ValueListBox);
            EnumsGroupBox.Controls.Add(IntValueLabel);
            EnumsGroupBox.Controls.Add(ChooseValueLabel);
            EnumsGroupBox.Controls.Add(EnumsLabel);
            EnumsGroupBox.Location = new Point(3, 6);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(776, 266);
            EnumsGroupBox.TabIndex = 0;
            EnumsGroupBox.TabStop = false;
            EnumsGroupBox.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" });
            EnumsListBox.Location = new Point(6, 50);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(147, 184);
            EnumsListBox.TabIndex = 3;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // IntValueTextBox
            // 
            IntValueTextBox.Location = new Point(348, 50);
            IntValueTextBox.Name = "IntValueTextBox";
            IntValueTextBox.Size = new Size(100, 23);
            IntValueTextBox.TabIndex = 5;
            // 
            // ValueListBox
            // 
            ValueListBox.FormattingEnabled = true;
            ValueListBox.ItemHeight = 15;
            ValueListBox.Location = new Point(181, 50);
            ValueListBox.Name = "ValueListBox";
            ValueListBox.Size = new Size(145, 184);
            ValueListBox.TabIndex = 4;
            ValueListBox.SelectedIndexChanged += ValueListBox_SelectedIndexChanged;
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(348, 32);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(55, 15);
            IntValueLabel.TabIndex = 2;
            IntValueLabel.Text = "Int value:";
            // 
            // ChooseValueLabel
            // 
            ChooseValueLabel.AutoSize = true;
            ChooseValueLabel.Location = new Point(181, 32);
            ChooseValueLabel.Name = "ChooseValueLabel";
            ChooseValueLabel.Size = new Size(81, 15);
            ChooseValueLabel.TabIndex = 1;
            ChooseValueLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            EnumsLabel.AutoSize = true;
            EnumsLabel.Location = new Point(6, 32);
            EnumsLabel.Name = "EnumsLabel";
            EnumsLabel.Size = new Size(121, 15);
            EnumsLabel.TabIndex = 0;
            EnumsLabel.Text = "Choose enumeration:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EnumsTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 538);
            tabControl1.TabIndex = 1;
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.BackColor = Color.Transparent;
            EnumsTabPage.Controls.Add(SeasonGroupBox);
            EnumsTabPage.Controls.Add(ParsingGroupBox);
            EnumsTabPage.Controls.Add(EnumsGroupBox);
            EnumsTabPage.Location = new Point(4, 24);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(792, 510);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Controls.Add(label2);
            SeasonGroupBox.Location = new Point(361, 280);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(397, 151);
            SeasonGroupBox.TabIndex = 2;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(249, 49);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 23);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(7, 49);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(224, 23);
            SeasonComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 30);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 0;
            label2.Text = "Choose season:";
            // 
            // ParsingGroupBox
            // 
            ParsingGroupBox.Controls.Add(WeekdayLabel);
            ParsingGroupBox.Controls.Add(ParseButton);
            ParsingGroupBox.Controls.Add(ParseTextBox);
            ParsingGroupBox.Controls.Add(label1);
            ParsingGroupBox.Location = new Point(3, 278);
            ParsingGroupBox.Name = "ParsingGroupBox";
            ParsingGroupBox.Size = new Size(352, 153);
            ParsingGroupBox.TabIndex = 1;
            ParsingGroupBox.TabStop = false;
            ParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayLabel
            // 
            WeekdayLabel.AutoSize = true;
            WeekdayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WeekdayLabel.ForeColor = SystemColors.ButtonShadow;
            WeekdayLabel.Location = new Point(6, 87);
            WeekdayLabel.Name = "WeekdayLabel";
            WeekdayLabel.Size = new Size(16, 15);
            WeekdayLabel.TabIndex = 5;
            WeekdayLabel.Text = "...";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(261, 50);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(75, 23);
            ParseButton.TabIndex = 4;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParseTextBox
            // 
            ParseTextBox.Location = new Point(6, 50);
            ParseTextBox.Name = "ParseTextBox";
            ParseTextBox.Size = new Size(235, 23);
            ParseTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 2;
            label1.Text = "Type value for parsing:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            EnumsGroupBox.ResumeLayout(false);
            EnumsGroupBox.PerformLayout();
            tabControl1.ResumeLayout(false);
            EnumsTabPage.ResumeLayout(false);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            ParsingGroupBox.ResumeLayout(false);
            ParsingGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumsGroupBox;
        private ListBox ValueListBox;
        private ListBox EnumsListBox;
        private Label IntValueLabel;
        private Label ChooseValueLabel;
        private Label EnumsLabel;
        private TextBox IntValueTextBox;
        private TabControl tabControl1;
        private TabPage EnumsTabPage;
        private GroupBox ParsingGroupBox;
        private Label WeekdayLabel;
        private Button ParseButton;
        private TextBox ParseTextBox;
        private Label label1;
        private GroupBox SeasonGroupBox;
        private Button GoButton;
        private ComboBox SeasonComboBox;
        private Label label2;
    }
}