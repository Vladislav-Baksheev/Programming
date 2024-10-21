namespace SyncBetweenThreeWindow
{
    partial class EventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            PhoneTextBox = new TextBox();
            CloseButton = new Button();
            label3 = new Label();
            AddressTextBox = new TextBox();
            NameTextBox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PhoneTextBox);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(AddressTextBox);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 348);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PhoneTextBox.Location = new Point(6, 91);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(288, 23);
            PhoneTextBox.TabIndex = 2;
            PhoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.Location = new Point(214, 266);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 142);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 0;
            label3.Text = "Address:";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(6, 160);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(288, 23);
            AddressTextBox.TabIndex = 2;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(6, 28);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(288, 23);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 73);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "Phone Number:";
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 356);
            Controls.Add(panel1);
            Name = "EventForm";
            Text = "EventForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox PhoneTextBox;
        private Button CloseButton;
        private Label label3;
        private TextBox AddressTextBox;
        private TextBox NameTextBox;
        private Label label2;
    }
}