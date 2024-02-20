namespace Programming.View.Controls
{
    partial class EnumerationControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
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
            EnumsGroupBox.SuspendLayout();
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
            EnumsGroupBox.Dock = DockStyle.Fill;
            EnumsGroupBox.Location = new Point(0, 0);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(494, 270);
            EnumsGroupBox.TabIndex = 1;
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
            // EnumerationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumsGroupBox);
            Name = "EnumerationControl";
            Size = new Size(494, 270);
            EnumsGroupBox.ResumeLayout(false);
            EnumsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumsGroupBox;
        private ListBox EnumsListBox;
        private TextBox IntValueTextBox;
        private ListBox ValueListBox;
        private Label IntValueLabel;
        private Label ChooseValueLabel;
        private Label EnumsLabel;
    }
}
