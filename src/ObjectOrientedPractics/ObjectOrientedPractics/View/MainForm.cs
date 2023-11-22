using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex == 2) 
            {
                MainCartsTab.RefreshData();
            }
        }
    }
}
