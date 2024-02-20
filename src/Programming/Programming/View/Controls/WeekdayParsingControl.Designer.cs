namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            ParsingGroupBox = new GroupBox();
            WeekdayLabel = new Label();
            ParseButton = new Button();
            ParseTextBox = new TextBox();
            label1 = new Label();
            ParsingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ParsingGroupBox
            // 
            ParsingGroupBox.Controls.Add(WeekdayLabel);
            ParsingGroupBox.Controls.Add(ParseButton);
            ParsingGroupBox.Controls.Add(ParseTextBox);
            ParsingGroupBox.Controls.Add(label1);
            ParsingGroupBox.Dock = DockStyle.Fill;
            ParsingGroupBox.Location = new Point(0, 0);
            ParsingGroupBox.Name = "ParsingGroupBox";
            ParsingGroupBox.Size = new Size(386, 176);
            ParsingGroupBox.TabIndex = 2;
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
            // WeekdayParsingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ParsingGroupBox);
            Name = "WeekdayParsingControl";
            Size = new Size(386, 176);
            ParsingGroupBox.ResumeLayout(false);
            ParsingGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ParsingGroupBox;
        private Label WeekdayLabel;
        private Button ParseButton;
        private TextBox ParseTextBox;
        private Label label1;
    }
}
