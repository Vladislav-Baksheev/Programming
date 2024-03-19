namespace Programming.View.Controls
{
    partial class FilmsControl
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
            FilmsGroupBox = new GroupBox();
            FindButton = new Button();
            YearTextBox = new TextBox();
            NameTextBox = new TextBox();
            DurationTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            FilmsListBox = new ListBox();
            label1 = new Label();
            GenreTextBox = new TextBox();
            label2 = new Label();
            RatingTextBox = new TextBox();
            FindMovieButton = new Button();
            FilmsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FilmsGroupBox
            // 
            FilmsGroupBox.Controls.Add(FindMovieButton);
            FilmsGroupBox.Controls.Add(FindButton);
            FilmsGroupBox.Controls.Add(RatingTextBox);
            FilmsGroupBox.Controls.Add(GenreTextBox);
            FilmsGroupBox.Controls.Add(YearTextBox);
            FilmsGroupBox.Controls.Add(NameTextBox);
            FilmsGroupBox.Controls.Add(DurationTextBox);
            FilmsGroupBox.Controls.Add(label4);
            FilmsGroupBox.Controls.Add(label2);
            FilmsGroupBox.Controls.Add(label1);
            FilmsGroupBox.Controls.Add(label5);
            FilmsGroupBox.Controls.Add(label3);
            FilmsGroupBox.Controls.Add(FilmsListBox);
            FilmsGroupBox.Dock = DockStyle.Fill;
            FilmsGroupBox.Location = new Point(0, 0);
            FilmsGroupBox.Name = "FilmsGroupBox";
            FilmsGroupBox.Size = new Size(425, 452);
            FilmsGroupBox.TabIndex = 2;
            FilmsGroupBox.TabStop = false;
            FilmsGroupBox.Text = "Films";
            // 
            // FindButton
            // 
            FindButton.Location = new Point(162, 468);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(75, 23);
            FindButton.TabIndex = 3;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(150, 128);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(100, 23);
            YearTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(150, 40);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 2;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(150, 84);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(100, 23);
            DurationTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 22);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 1;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 110);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 1;
            label5.Text = "Year of release:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 66);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 1;
            label3.Text = "Duration:";
            // 
            // FilmsListBox
            // 
            FilmsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FilmsListBox.FormattingEnabled = true;
            FilmsListBox.ItemHeight = 15;
            FilmsListBox.Location = new Point(6, 22);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(138, 424);
            FilmsListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 154);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(150, 172);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(100, 23);
            GenreTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 198);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Rating:";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(150, 216);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(100, 23);
            RatingTextBox.TabIndex = 2;
            // 
            // FindMovieButton
            // 
            FindMovieButton.Location = new Point(160, 423);
            FindMovieButton.Name = "FindMovieButton";
            FindMovieButton.Size = new Size(75, 23);
            FindMovieButton.TabIndex = 4;
            FindMovieButton.Text = "Find";
            FindMovieButton.UseVisualStyleBackColor = true;
            FindMovieButton.Click += FindMovieButton_Click;
            // 
            // FilmsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilmsGroupBox);
            Name = "FilmsControl";
            Size = new Size(425, 452);
            FilmsGroupBox.ResumeLayout(false);
            FilmsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox FilmsGroupBox;
        private Button FindButton;
        private TextBox YearTextBox;
        private TextBox NameTextBox;
        private TextBox DurationTextBox;
        private Label label4;
        private Label label5;
        private Label label3;
        private ListBox FilmsListBox;
        private TextBox RatingTextBox;
        private TextBox GenreTextBox;
        private Label label2;
        private Label label1;
        private Button FindMovieButton;
    }
}
