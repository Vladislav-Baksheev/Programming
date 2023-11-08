using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит логику обработки событий окна.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Создает товары с автоматически заполненными данными.
        /// </summary>
        private ItemFactory _itemFactory;

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Задает и получает сведения о товарах.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            _itemFactory = new ItemFactory();
            foreach (Enum valueCategory in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(valueCategory);
            }
        }
        
        /// <summary>
        /// Обновляет все текстовые поля.
        /// </summary>
        private void UpdateTextboxes(Item item)
        {
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
            IDTextBox.Text = item.Id.ToString();
            CategoryComboBox.Text = item.Category.ToString(); 
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
        

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0) 
            { 
                return; 
            }
            Items.Remove(_currentItem);
            ItemsListBox.Items.Remove(_currentItem.Name);
            ItemsListBox.SelectedIndex = Items.Count > 0 ? 0 : -1;
            UpdateTextboxes(_currentItem);  
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            _currentItem = _itemFactory.CreateItem();
            Items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);
            ItemsListBox.SelectedIndex = Items.Count - 1;
            UpdateTextboxes(_currentItem);
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                CostTextBox.BackColor = AppColor.GoodBackColor;
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
            } 
            catch (Exception ex)
            { 
                CostTextBox.BackColor = AppColor.ErrorBackColor;
                if(Items.Count == 0)
                {
                    CostTextBox.BackColor = AppColor.GoodBackColor;
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = AppColor.GoodBackColor;
                _currentItem.Name = NameTextBox.Text;
                ItemsListBox.Items[Items.IndexOf(_currentItem)] = _currentItem.Name;
            }
            catch (Exception ex)
            {
                NameTextBox.BackColor = AppColor.ErrorBackColor;
                if (Items.Count == 0)
                {
                    NameTextBox.BackColor = AppColor.GoodBackColor;
                }
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DescriptionTextBox.BackColor = AppColor.GoodBackColor;
                _currentItem.Info = DescriptionTextBox.Text;
            }
            catch (Exception ex)
            {
                DescriptionTextBox.BackColor = AppColor.ErrorBackColor;
                if (Items.Count == 0)
                {
                    DescriptionTextBox.BackColor = AppColor.GoodBackColor;
                }
            }
        }

        private void CategoryComboBox_TextChanged(object sender, EventArgs e)
        {
            _currentItem.Category = (Category)CategoryComboBox.SelectedIndex;
        }
    }
}
