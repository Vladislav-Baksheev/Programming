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
            ClassesTabPage = new TabPage();
            filmsControl1 = new View.Controls.FilmsControl();
            rectangleControl1 = new View.Controls.RectangleControl();
            tabPage1 = new TabPage();
            rectangleCollisionControl1 = new View.Controls.RectangleCollisionControl();
            tabControl1.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EnumsTabPage);
            tabControl1.Controls.Add(ClassesTabPage);
            tabControl1.Controls.Add(tabPage1);
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
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(filmsControl1);
            ClassesTabPage.Controls.Add(rectangleControl1);
            ClassesTabPage.Location = new Point(4, 24);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(792, 510);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // filmsControl1
            // 
            filmsControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            filmsControl1.Location = new Point(365, 3);
            filmsControl1.Name = "filmsControl1";
            filmsControl1.Size = new Size(419, 504);
            filmsControl1.TabIndex = 1;
            // 
            // rectangleControl1
            // 
            rectangleControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rectangleControl1.Location = new Point(3, 3);
            rectangleControl1.Name = "rectangleControl1";
            rectangleControl1.Size = new Size(356, 504);
            rectangleControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rectangleCollisionControl1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 510);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Rectangles";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionControl1
            // 
            rectangleCollisionControl1.Dock = DockStyle.Fill;
            rectangleCollisionControl1.Location = new Point(3, 3);
            rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            rectangleCollisionControl1.Size = new Size(786, 504);
            rectangleCollisionControl1.TabIndex = 0;
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
            ClassesTabPage.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage EnumsTabPage;
        private TabPage ClassesTabPage;
        private View.Controls.EnumerationControl enumerationControl1;
        private View.Controls.WeekdayParsingControl weekdayParsingControl1;
        private View.Controls.SeasonHandleControl seasonHandleControl1;
        private View.Controls.RectangleControl rectangleControl1;
        private View.Controls.FilmsControl filmsControl1;
        private TabPage tabPage1;
        private View.Controls.RectangleCollisionControl rectangleCollisionControl1;
    }
}