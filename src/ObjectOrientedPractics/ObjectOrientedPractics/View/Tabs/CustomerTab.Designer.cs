namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
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
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.ButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.SelectedCustomersPanel = new System.Windows.Forms.Panel();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.FullnameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SelectedCustomersLabel = new System.Windows.Forms.Label();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomersPanel.SuspendLayout();
            this.ButtonTableLayoutPanel.SuspendLayout();
            this.SelectedCustomersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersPanel.Controls.Add(this.ButtonTableLayoutPanel);
            this.CustomersPanel.Controls.Add(this.CustomersListBox);
            this.CustomersPanel.Controls.Add(this.CustomersLabel);
            this.CustomersPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(248, 416);
            this.CustomersPanel.TabIndex = 0;
            // 
            // ButtonTableLayoutPanel
            // 
            this.ButtonTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonTableLayoutPanel.ColumnCount = 3;
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.GenerateButton, 2, 0);
            this.ButtonTableLayoutPanel.Location = new System.Drawing.Point(4, 345);
            this.ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            this.ButtonTableLayoutPanel.RowCount = 1;
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTableLayoutPanel.Size = new System.Drawing.Size(238, 68);
            this.ButtonTableLayoutPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(73, 62);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(82, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(73, 62);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenerateButton.Location = new System.Drawing.Point(161, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(74, 62);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 26);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(241, 316);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(4, 4);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(75, 15);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // SelectedCustomersPanel
            // 
            this.SelectedCustomersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomersPanel.Controls.Add(this.IsPriorityCheckBox);
            this.SelectedCustomersPanel.Controls.Add(this.addressControl1);
            this.SelectedCustomersPanel.Controls.Add(this.FullnameTextBox);
            this.SelectedCustomersPanel.Controls.Add(this.IDTextBox);
            this.SelectedCustomersPanel.Controls.Add(this.FullnameLabel);
            this.SelectedCustomersPanel.Controls.Add(this.IDLabel);
            this.SelectedCustomersPanel.Controls.Add(this.SelectedCustomersLabel);
            this.SelectedCustomersPanel.Location = new System.Drawing.Point(254, 4);
            this.SelectedCustomersPanel.Name = "SelectedCustomersPanel";
            this.SelectedCustomersPanel.Size = new System.Drawing.Size(583, 416);
            this.SelectedCustomersPanel.TabIndex = 1;
            // 
            // addressControl1
            // 
            this.addressControl1.Address = null;
            this.addressControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControl1.Location = new System.Drawing.Point(10, 131);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(494, 207);
            this.addressControl1.TabIndex = 8;
            // 
            // FullnameTextBox
            // 
            this.FullnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullnameTextBox.Location = new System.Drawing.Point(78, 61);
            this.FullnameTextBox.Name = "FullnameTextBox";
            this.FullnameTextBox.Size = new System.Drawing.Size(275, 20);
            this.FullnameTextBox.TabIndex = 5;
            this.FullnameTextBox.TextChanged += new System.EventHandler(this.FullnameTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.Location = new System.Drawing.Point(78, 33);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 4;
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.Location = new System.Drawing.Point(7, 61);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(52, 13);
            this.FullnameLabel.TabIndex = 2;
            this.FullnameLabel.Text = "Fullname:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(7, 33);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID:";
            // 
            // SelectedCustomersLabel
            // 
            this.SelectedCustomersLabel.AutoSize = true;
            this.SelectedCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomersLabel.Location = new System.Drawing.Point(7, 0);
            this.SelectedCustomersLabel.Name = "SelectedCustomersLabel";
            this.SelectedCustomersLabel.Size = new System.Drawing.Size(128, 15);
            this.SelectedCustomersLabel.TabIndex = 0;
            this.SelectedCustomersLabel.Text = "Selected Customer";
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(78, 97);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(68, 17);
            this.IsPriorityCheckBox.TabIndex = 9;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // CustomerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedCustomersPanel);
            this.Controls.Add(this.CustomersPanel);
            this.Name = "CustomerTab";
            this.Size = new System.Drawing.Size(840, 416);
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            this.ButtonTableLayoutPanel.ResumeLayout(false);
            this.SelectedCustomersPanel.ResumeLayout(false);
            this.SelectedCustomersPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonTableLayoutPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.Panel SelectedCustomersPanel;
        private System.Windows.Forms.TextBox FullnameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label SelectedCustomersLabel;
        private System.Windows.Forms.Button GenerateButton;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
    }
}
