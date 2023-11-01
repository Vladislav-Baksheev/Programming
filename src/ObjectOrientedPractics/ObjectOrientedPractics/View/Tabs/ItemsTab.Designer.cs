namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.SelectItemsPanel = new System.Windows.Forms.Panel();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.TableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SelectedItemsLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ItemsPanel.SuspendLayout();
            this.SelectItemsPanel.SuspendLayout();
            this.TableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.Controls.Add(this.TableLayoutPanelButtons);
            this.ItemsPanel.Controls.Add(this.ItemsListBox);
            this.ItemsPanel.Controls.Add(this.ItemsLabel);
            this.ItemsPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(250, 404);
            this.ItemsPanel.TabIndex = 0;
            // 
            // SelectItemsPanel
            // 
            this.SelectItemsPanel.Controls.Add(this.DescriptionTextBox);
            this.SelectItemsPanel.Controls.Add(this.DescriptionLabel);
            this.SelectItemsPanel.Controls.Add(this.NameTextBox);
            this.SelectItemsPanel.Controls.Add(this.CostTextBox);
            this.SelectItemsPanel.Controls.Add(this.IDTextBox);
            this.SelectItemsPanel.Controls.Add(this.NameLabel);
            this.SelectItemsPanel.Controls.Add(this.CostLabel);
            this.SelectItemsPanel.Controls.Add(this.IDLabel);
            this.SelectItemsPanel.Controls.Add(this.SelectedItemsLabel);
            this.SelectItemsPanel.Location = new System.Drawing.Point(256, 0);
            this.SelectItemsPanel.Name = "SelectItemsPanel";
            this.SelectItemsPanel.Size = new System.Drawing.Size(345, 404);
            this.SelectItemsPanel.TabIndex = 1;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(3, 3);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(42, 15);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 21);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(241, 316);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // TableLayoutPanelButtons
            // 
            this.TableLayoutPanelButtons.ColumnCount = 3;
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.95F));
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.05F));
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TableLayoutPanelButtons.Controls.Add(this.AddButton, 0, 0);
            this.TableLayoutPanelButtons.Controls.Add(this.RemoveButton, 1, 0);
            this.TableLayoutPanelButtons.Location = new System.Drawing.Point(6, 343);
            this.TableLayoutPanelButtons.Name = "TableLayoutPanelButtons";
            this.TableLayoutPanelButtons.RowCount = 1;
            this.TableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelButtons.Size = new System.Drawing.Size(241, 57);
            this.TableLayoutPanelButtons.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 51);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(84, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(73, 51);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SelectedItemsLabel
            // 
            this.SelectedItemsLabel.AutoSize = true;
            this.SelectedItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemsLabel.Location = new System.Drawing.Point(3, 5);
            this.SelectedItemsLabel.Name = "SelectedItemsLabel";
            this.SelectedItemsLabel.Size = new System.Drawing.Size(102, 15);
            this.SelectedItemsLabel.TabIndex = 0;
            this.SelectedItemsLabel.Text = "Selected Items";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(6, 34);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(6, 66);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(31, 13);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 121);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(70, 34);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 4;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(70, 63);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(3, 146);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(339, 96);
            this.NameTextBox.TabIndex = 6;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 249);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(4, 266);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(338, 131);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectItemsPanel);
            this.Controls.Add(this.ItemsPanel);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(604, 404);
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.SelectItemsPanel.ResumeLayout(false);
            this.SelectItemsPanel.PerformLayout();
            this.TableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelButtons;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Panel SelectItemsPanel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label SelectedItemsLabel;
    }
}
