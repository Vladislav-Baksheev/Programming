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
            seasonHandleControl1 = new View.Controls.SeasonHandleControl();
            weekdayParsingControl1 = new View.Controls.WeekdayParsingControl();
            enumerationControl1 = new View.Controls.EnumerationControl();
            RectanglesTabPage = new TabPage();
            rectangleControl1 = new View.Controls.RectangleControl();
            tabControl1.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
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
            // seasonHandleControl1
            // 
            seasonHandleControl1.Location = new Point(368, 276);
            seasonHandleControl1.Name = "seasonHandleControl1";
            seasonHandleControl1.Size = new Size(405, 160);
            seasonHandleControl1.TabIndex = 5;
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
            RectanglesTabPage.Controls.Add(rectangleControl1);
            RectanglesTabPage.Location = new Point(4, 24);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Padding = new Padding(3);
            RectanglesTabPage.Size = new Size(792, 510);
            RectanglesTabPage.TabIndex = 1;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectangleControl1
            // 
            rectangleControl1.Dock = DockStyle.Fill;
            rectangleControl1.Location = new Point(3, 3);
            rectangleControl1.Name = "rectangleControl1";
            rectangleControl1.Size = new Size(786, 504);
            rectangleControl1.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage EnumsTabPage;
        private TabPage RectanglesTabPage;
        private View.Controls.EnumerationControl enumerationControl1;
        private View.Controls.WeekdayParsingControl weekdayParsingControl1;
        private View.Controls.SeasonHandleControl seasonHandleControl1;
        private View.Controls.RectangleControl rectangleControl1;
    }
}