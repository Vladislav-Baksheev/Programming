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
            EnumsGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            EnumsTabPage.SuspendLayout();
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
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 1;
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.Controls.Add(EnumsGroupBox);
            EnumsTabPage.Location = new Point(4, 24);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(792, 422);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            EnumsGroupBox.ResumeLayout(false);
            EnumsGroupBox.PerformLayout();
            tabControl1.ResumeLayout(false);
            EnumsTabPage.ResumeLayout(false);
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
    }
}