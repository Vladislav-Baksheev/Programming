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
            tabControl1 = new TabControl();
            EnumsTabPage = new TabPage();
            weekdayParsingControl1 = new View.Controls.WeekdayParsingControl();
            enumerationControl1 = new View.Controls.EnumerationControl();
            RectanglesTabPage = new TabPage();
            RectanglesGroupBox = new GroupBox();
            ColorTextBox = new TextBox();
            LengthTextBox = new TextBox();
            WidthTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            RectanglesListBox = new ListBox();
            seasonHandleControl1 = new View.Controls.SeasonHandleControl();
            tabControl1.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EnumsTabPage);
            tabControl1.Controls.Add(RectanglesTabPage);
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
            EnumsTabPage.Controls.Add(seasonHandleControl1);
            EnumsTabPage.Controls.Add(weekdayParsingControl1);
            EnumsTabPage.Controls.Add(enumerationControl1);
            EnumsTabPage.Location = new Point(4, 24);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(792, 510);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            // 
            // weekdayParsingControl1
            // 
            weekdayParsingControl1.Location = new Point(6, 276);
            weekdayParsingControl1.Name = "weekdayParsingControl1";
            weekdayParsingControl1.Size = new Size(356, 176);
            weekdayParsingControl1.TabIndex = 4;
            // 
            // enumerationControl1
            // 
            enumerationControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            enumerationControl1.Location = new Point(-4, 0);
            enumerationControl1.Name = "enumerationControl1";
            enumerationControl1.Size = new Size(796, 270);
            enumerationControl1.TabIndex = 3;
            // 
            // RectanglesTabPage
            // 
            RectanglesTabPage.Controls.Add(RectanglesGroupBox);
            RectanglesTabPage.Location = new Point(4, 24);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Padding = new Padding(3);
            RectanglesTabPage.Size = new Size(792, 510);
            RectanglesTabPage.TabIndex = 1;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(LengthTextBox);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(label4);
            RectanglesGroupBox.Controls.Add(label5);
            RectanglesGroupBox.Controls.Add(label3);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Dock = DockStyle.Fill;
            RectanglesGroupBox.Location = new Point(3, 3);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(786, 504);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(150, 128);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(100, 23);
            ColorTextBox.TabIndex = 2;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(150, 40);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(100, 23);
            LengthTextBox.TabIndex = 2;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(150, 84);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 22);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 1;
            label4.Text = "Length:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 110);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 1;
            label5.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 66);
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
            RectanglesListBox.Size = new Size(139, 214);
            RectanglesListBox.TabIndex = 0;
            // 
            // seasonHandleControl1
            // 
            seasonHandleControl1.Location = new Point(368, 276);
            seasonHandleControl1.Name = "seasonHandleControl1";
            seasonHandleControl1.Size = new Size(405, 160);
            seasonHandleControl1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            tabControl1.ResumeLayout(false);
            EnumsTabPage.ResumeLayout(false);
            RectanglesTabPage.ResumeLayout(false);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage EnumsTabPage;
        private TabPage RectanglesTabPage;
        private GroupBox RectanglesGroupBox;
        private TextBox ColorTextBox;
        private TextBox LengthTextBox;
        private TextBox WidthTextBox;
        private Label label4;
        private Label label5;
        private Label label3;
        private ListBox RectanglesListBox;
        private View.Controls.EnumerationControl enumerationControl1;
        private View.Controls.WeekdayParsingControl weekdayParsingControl1;
        private View.Controls.SeasonHandleControl seasonHandleControl1;
    }
}