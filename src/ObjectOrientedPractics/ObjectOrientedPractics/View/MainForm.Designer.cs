namespace ObjectOrientedPractics
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.MainOrdersTabPage = new System.Windows.Forms.TabPage();
            this.PriorityOrdersTabPage = new System.Windows.Forms.TabPage();
            this.MainItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.MainCustomersTab = new ObjectOrientedPractics.View.Tabs.CustomerTab();
            this.MainCartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.MainOrdersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.priorityOrdersTab1 = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.MainTabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.MainOrdersTabPage.SuspendLayout();
            this.PriorityOrdersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ItemsTabPage);
            this.MainTabControl.Controls.Add(this.CustomersTabPage);
            this.MainTabControl.Controls.Add(this.CartsTabPage);
            this.MainTabControl.Controls.Add(this.MainOrdersTabPage);
            this.MainTabControl.Controls.Add(this.PriorityOrdersTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1228, 652);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.MainItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(1220, 626);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.MainCustomersTab);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(1121, 626);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.MainCartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartsTabPage.Size = new System.Drawing.Size(1121, 626);
            this.CartsTabPage.TabIndex = 2;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainOrdersTabPage
            // 
            this.MainOrdersTabPage.Controls.Add(this.MainOrdersTab);
            this.MainOrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.MainOrdersTabPage.Name = "MainOrdersTabPage";
            this.MainOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainOrdersTabPage.Size = new System.Drawing.Size(1121, 626);
            this.MainOrdersTabPage.TabIndex = 3;
            this.MainOrdersTabPage.Text = "Orders";
            this.MainOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTabPage
            // 
            this.PriorityOrdersTabPage.Controls.Add(this.priorityOrdersTab1);
            this.PriorityOrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.PriorityOrdersTabPage.Name = "PriorityOrdersTabPage";
            this.PriorityOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PriorityOrdersTabPage.Size = new System.Drawing.Size(1121, 626);
            this.PriorityOrdersTabPage.TabIndex = 4;
            this.PriorityOrdersTabPage.Text = "Priority Orders";
            this.PriorityOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // MainItemsTab
            // 
            this.MainItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainItemsTab.Location = new System.Drawing.Point(3, 3);
            this.MainItemsTab.Name = "MainItemsTab";
            this.MainItemsTab.Size = new System.Drawing.Size(1214, 620);
            this.MainItemsTab.TabIndex = 0;
            // 
            // MainCustomersTab
            // 
            this.MainCustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainCustomersTab.Location = new System.Drawing.Point(3, 3);
            this.MainCustomersTab.Name = "MainCustomersTab";
            this.MainCustomersTab.Size = new System.Drawing.Size(1115, 620);
            this.MainCustomersTab.TabIndex = 0;
            // 
            // MainCartsTab
            // 
            this.MainCartsTab.CurrentCustomer = null;
            this.MainCartsTab.CurrentItem = null;
            this.MainCartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainCartsTab.Location = new System.Drawing.Point(3, 3);
            this.MainCartsTab.Name = "MainCartsTab";
            this.MainCartsTab.Size = new System.Drawing.Size(1115, 620);
            this.MainCartsTab.TabIndex = 0;
            // 
            // MainOrdersTab
            // 
            this.MainOrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainOrdersTab.Location = new System.Drawing.Point(3, 3);
            this.MainOrdersTab.Name = "MainOrdersTab";
            this.MainOrdersTab.Size = new System.Drawing.Size(1115, 620);
            this.MainOrdersTab.TabIndex = 0;
            // 
            // priorityOrdersTab1
            // 
            this.priorityOrdersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityOrdersTab1.Location = new System.Drawing.Point(3, 3);
            this.priorityOrdersTab1.Name = "priorityOrdersTab1";
            this.priorityOrdersTab1.Size = new System.Drawing.Size(1115, 620);
            this.priorityOrdersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 652);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.MainTabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.MainOrdersTabPage.ResumeLayout(false);
            this.PriorityOrdersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private View.Tabs.ItemsTab MainItemsTab;
        private View.Tabs.CustomerTab MainCustomersTab;
        private System.Windows.Forms.TabPage CartsTabPage;
        private View.Tabs.CartsTab MainCartsTab;
        private System.Windows.Forms.TabPage MainOrdersTabPage;
        private View.Tabs.OrdersTab MainOrdersTab;
        private System.Windows.Forms.TabPage PriorityOrdersTabPage;
        private View.Tabs.PriorityOrdersTab priorityOrdersTab1;
    }
}

