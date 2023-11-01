using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
        }
        private List<Item> _items = new List<Item>();

        private Item _currentItem;

        public List<Item> Items 
        { 
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                if (Items.Count != 0)
                {
                    foreach (Item item in Items)
                    {
                        ItemsListBox.Items.Add(item.Name);
                    }
                }
                ItemsListBox.SelectedIndex = 0;
            }
        }
        private void UpdateTextboxes(Item item)
        {
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
            IDTextBox.Text = item.Id.ToString();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();
            Items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);
            UpdateTextboxes(_currentItem);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            _currentItem = Items[index];
            UpdateTextboxes(_currentItem);
        }
        public event EventHandler<EventArgs> ItemsChanged;

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
