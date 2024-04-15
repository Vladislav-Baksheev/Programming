namespace ProductApp
{
    partial class ProductAppForm
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
            AddButton = new Button();
            RemoveButton = new Button();
            ProductListBox = new ListBox();
            NameTextBox = new TextBox();
            ManufacturerTextBox = new TextBox();
            AmountTextBox = new TextBox();
            CategoryComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SelectedProductGroupBox = new GroupBox();
            SelectedProductGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(13, 415);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(94, 415);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 23);
            RemoveButton.TabIndex = 0;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ProductListBox
            // 
            ProductListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProductListBox.FormattingEnabled = true;
            ProductListBox.ItemHeight = 15;
            ProductListBox.Location = new Point(12, 12);
            ProductListBox.Name = "ProductListBox";
            ProductListBox.Size = new Size(235, 394);
            ProductListBox.TabIndex = 1;
            ProductListBox.SelectedIndexChanged += ProductListBox_SelectedIndexChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(97, 26);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(222, 23);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // ManufacturerTextBox
            // 
            ManufacturerTextBox.Location = new Point(97, 68);
            ManufacturerTextBox.Name = "ManufacturerTextBox";
            ManufacturerTextBox.Size = new Size(222, 23);
            ManufacturerTextBox.TabIndex = 2;
            ManufacturerTextBox.TextChanged += ManufacturerTextBox_TextChanged;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(97, 115);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(132, 23);
            AmountTextBox.TabIndex = 2;
            AmountTextBox.TextChanged += AmountTextBox_TextChanged;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(97, 155);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(132, 23);
            CategoryComboBox.TabIndex = 3;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 71);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Manufacturer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 118);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 158);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 29);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Name:";
            // 
            // SelectedProductGroupBox
            // 
            SelectedProductGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedProductGroupBox.Controls.Add(label5);
            SelectedProductGroupBox.Controls.Add(NameTextBox);
            SelectedProductGroupBox.Controls.Add(AmountTextBox);
            SelectedProductGroupBox.Controls.Add(label4);
            SelectedProductGroupBox.Controls.Add(ManufacturerTextBox);
            SelectedProductGroupBox.Controls.Add(label3);
            SelectedProductGroupBox.Controls.Add(CategoryComboBox);
            SelectedProductGroupBox.Controls.Add(label2);
            SelectedProductGroupBox.Location = new Point(281, 12);
            SelectedProductGroupBox.Name = "SelectedProductGroupBox";
            SelectedProductGroupBox.Size = new Size(507, 426);
            SelectedProductGroupBox.TabIndex = 6;
            SelectedProductGroupBox.TabStop = false;
            SelectedProductGroupBox.Text = "Selected Product";
            // 
            // ProductAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SelectedProductGroupBox);
            Controls.Add(ProductListBox);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Name = "ProductAppForm";
            Text = "Product App";
            SelectedProductGroupBox.ResumeLayout(false);
            SelectedProductGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private Button RemoveButton;
        private ListBox ProductListBox;
        private TextBox NameTextBox;
        private TextBox ManufacturerTextBox;
        private TextBox AmountTextBox;
        private ComboBox CategoryComboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox SelectedProductGroupBox;
    }
}