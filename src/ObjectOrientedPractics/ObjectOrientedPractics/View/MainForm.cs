using ObjectOrientedPractics.Model;
using System;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        Store _store;
        public MainForm()
        {
            _store = new Store();
            InitializeComponent();

            MainItemsTab.Items = _store.Items;
            MainCustomersTab.Customers = _store.Customers;
            MainCartsTab.Items = _store.Items;
            MainCartsTab.Customers = _store.Customers;
            MainOrdersTab.Customers = _store.Customers;

            MainItemsTab.ItemsChanged += ItemsTab_ItemsChanged;
            MainCustomersTab.CustomersChanged += ItemsTab_ItemsChanged;
            MainCartsTab.CartsChanged += ItemsTab_ItemsChanged;
        }

        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            MainCartsTab.RefreshData();
            MainOrdersTab.RefreshData();
        }
    }
}
