namespace Programming.View.Controls
{
    partial class SeasonHandleControl
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
            SeasonGroupBox = new GroupBox();
            GoButton = new Button();
            SeasonComboBox = new ComboBox();
            label2 = new Label();
            SeasonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Controls.Add(label2);
            SeasonGroupBox.Dock = DockStyle.Fill;
            SeasonGroupBox.Location = new Point(0, 0);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(405, 160);
            SeasonGroupBox.TabIndex = 3;
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
            // SeasonHandleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonGroupBox);
            Name = "SeasonHandleControl";
            Size = new Size(405, 160);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasonGroupBox;
        private Button GoButton;
        private ComboBox SeasonComboBox;
        private Label label2;
    }
}
