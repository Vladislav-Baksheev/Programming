namespace Programming.View.Controls
{
    partial class RectangleControl
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
            RectanglesGroupBox = new GroupBox();
            FindButton = new Button();
            ColorTextBox = new TextBox();
            YTextBox = new TextBox();
            XTextBox = new TextBox();
            LengthTextBox = new TextBox();
            WidthTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            RectanglesListBox = new ListBox();
            label6 = new Label();
            IDTextBox = new TextBox();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(FindButton);
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(YTextBox);
            RectanglesGroupBox.Controls.Add(XTextBox);
            RectanglesGroupBox.Controls.Add(IDTextBox);
            RectanglesGroupBox.Controls.Add(LengthTextBox);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(label2);
            RectanglesGroupBox.Controls.Add(label1);
            RectanglesGroupBox.Controls.Add(label6);
            RectanglesGroupBox.Controls.Add(label4);
            RectanglesGroupBox.Controls.Add(label5);
            RectanglesGroupBox.Controls.Add(label3);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Dock = DockStyle.Fill;
            RectanglesGroupBox.Location = new Point(0, 0);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(514, 501);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // FindButton
            // 
            FindButton.Location = new Point(150, 298);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(75, 23);
            FindButton.TabIndex = 3;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(150, 170);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(100, 23);
            ColorTextBox.TabIndex = 2;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(150, 257);
            YTextBox.Name = "YTextBox";
            YTextBox.Size = new Size(100, 23);
            YTextBox.TabIndex = 2;
            YTextBox.TextChanged += LengthTextBox_TextChanged;
            YTextBox.KeyPress += YTextBox_KeyPress;
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(150, 213);
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(100, 23);
            XTextBox.TabIndex = 2;
            XTextBox.TextChanged += LengthTextBox_TextChanged;
            XTextBox.KeyPress += XTextBox_KeyPress;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(150, 82);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(100, 23);
            LengthTextBox.TabIndex = 2;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(150, 126);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 2;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 239);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Y:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 196);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "X:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 64);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 1;
            label4.Text = "Length:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 152);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 1;
            label5.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 108);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "Width:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(5, 22);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(139, 469);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 22);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 1;
            label6.Text = "ID:";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(150, 40);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(100, 23);
            IDTextBox.TabIndex = 2;
            IDTextBox.KeyPress += IDTextBox_KeyPress;
            // 
            // RectangleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "RectangleControl";
            Size = new Size(514, 501);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private TextBox ColorTextBox;
        private TextBox LengthTextBox;
        private TextBox WidthTextBox;
        private Label label4;
        private Label label5;
        private Label label3;
        private ListBox RectanglesListBox;
        private Button FindButton;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private Label label2;
        private Label label1;
        private TextBox IDTextBox;
        private Label label6;
    }
}
