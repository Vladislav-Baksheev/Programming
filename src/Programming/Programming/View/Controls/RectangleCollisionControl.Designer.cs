namespace Programming.View.Controls
{
    partial class RectangleCollisionControl
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
            label1 = new Label();
            RectanglesListBox = new ListBox();
            RectanglesPanel = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            IDTextBox = new TextBox();
            XTextBox = new TextBox();
            YTextBox = new TextBox();
            WidthTextBox = new TextBox();
            HeightTextBox = new TextBox();
            AddButtonPictureBox = new PictureBox();
            RemoveButtonPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)AddButtonPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RemoveButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Rectangles:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(19, 46);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(216, 199);
            RectanglesListBox.TabIndex = 1;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglesPanel.BorderStyle = BorderStyle.Fixed3D;
            RectanglesPanel.Location = new Point(248, 3);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(394, 488);
            RectanglesPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 298);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 0;
            label2.Text = "Selected Rectangle:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 322);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 349);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 0;
            label4.Text = "X:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 376);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 0;
            label5.Text = "Y:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 428);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 0;
            label6.Text = "Width:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 403);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 0;
            label7.Text = "Height:";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(55, 316);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(124, 23);
            IDTextBox.TabIndex = 0;
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(55, 345);
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(124, 23);
            XTextBox.TabIndex = 0;
            XTextBox.TextChanged += XTextBox_TextChanged;
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(55, 373);
            YTextBox.Name = "YTextBox";
            YTextBox.Size = new Size(124, 23);
            YTextBox.TabIndex = 0;
            YTextBox.TextChanged += YTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(55, 400);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(124, 23);
            WidthTextBox.TabIndex = 0;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(55, 425);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(124, 23);
            HeightTextBox.TabIndex = 0;
            HeightTextBox.TextChanged += HeightTextBox_TextChanged;
            // 
            // AddButtonPictureBox
            // 
            AddButtonPictureBox.Image = Properties.Resources.rectangle_add_24x24_uncolor;
            AddButtonPictureBox.Location = new Point(32, 251);
            AddButtonPictureBox.Name = "AddButtonPictureBox";
            AddButtonPictureBox.Size = new Size(62, 28);
            AddButtonPictureBox.TabIndex = 0;
            AddButtonPictureBox.TabStop = false;
            AddButtonPictureBox.Click += AddButtonPictureBox_Click;
            AddButtonPictureBox.MouseEnter += AddButtonPictureBox_MouseEnter;
            AddButtonPictureBox.MouseLeave += AddButtonPictureBox_MouseLeave;
            // 
            // RemoveButtonPictureBox
            // 
            RemoveButtonPictureBox.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
            RemoveButtonPictureBox.Location = new Point(129, 251);
            RemoveButtonPictureBox.Name = "RemoveButtonPictureBox";
            RemoveButtonPictureBox.Size = new Size(62, 28);
            RemoveButtonPictureBox.TabIndex = 0;
            RemoveButtonPictureBox.TabStop = false;
            RemoveButtonPictureBox.Click += RemoveButtonPictureBox_Click;
            RemoveButtonPictureBox.MouseEnter += RemoveButtonPictureBox_MouseEnter;
            RemoveButtonPictureBox.MouseLeave += RemoveButtonPictureBox_MouseLeave;
            // 
            // RectangleCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RemoveButtonPictureBox);
            Controls.Add(AddButtonPictureBox);
            Controls.Add(HeightTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(YTextBox);
            Controls.Add(XTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RectanglesPanel);
            Controls.Add(RectanglesListBox);
            Controls.Add(label1);
            Name = "RectangleCollisionControl";
            Size = new Size(645, 494);
            ((System.ComponentModel.ISupportInitialize)AddButtonPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RemoveButtonPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox RectanglesListBox;
        private Panel RectanglesPanel;
        private Button AddButton;
        private Button RemoveButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox IDTextBox;
        private TextBox XTextBox;
        private TextBox YTextBox;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private PictureBox AddButtonPictureBox;
        private PictureBox RemoveButtonPictureBox;
    }
}
