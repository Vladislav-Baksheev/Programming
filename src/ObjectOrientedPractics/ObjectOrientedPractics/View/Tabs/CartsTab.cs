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
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Хранит список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Хранит список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Ткущий пользователь.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задает текущего пользователя.
        /// </summary>
        public Customer CurrentCustomer { get; set; }

        /// <summary>
        /// Возвращает и задает текущий товар.
        /// </summary>
        public Item CurrentItem { get; set; }

        /// <summary>
        /// Возвращает и задает список товаров.
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

                if (_items != null)
                {
                    foreach (var item in Items)
                    {
                        ItemsListBox.Items.Add(item.Name);
                    }

                    ItemsListBox.SelectedIndex = -1;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    foreach (var customer in _customers)
                    {
                        CustomersComboBox.Items.Add(customer.FullName);
                    }

                    CustomersComboBox.SelectedIndex = -1;
                }
            }
        }
        public CartsTab()
        {
            InitializeComponent();
        }

        private void UpdateCartListBox()
        {
            CartListBox.Items.Clear();

            foreach (var item in CurrentCustomer.Cart.Items)
            {
                CartListBox.Items.Add(item.Name);
            }

            SumCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex == -1)
                return;

            CurrentCustomer = Customers[CustomersComboBox.SelectedIndex];

            UpdateCartListBox();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1
                || CurrentCustomer == null)
                return;

            CurrentItem = Items[ItemsListBox.SelectedIndex];
            CurrentCustomer.Cart.Items.Add(CurrentItem);
            CartListBox.Items.Add(CurrentItem.Name);
            SumCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1
                || CurrentCustomer == null || CartListBox.Items.Count == 0)
                return;
            CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
            SumCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Обновляет данные о товарах и покупателях.
        /// </summary>
        public void RefreshData()
        {
            ItemsListBox.Items.Clear();
            CustomersComboBox.Items.Clear();
            foreach (var item in Items)
            {
                ItemsListBox.Items.Add(item.Name);

            }
            foreach (var customer in Customers)
            {
                CustomersComboBox.Items.Add(customer.FullName);
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if(CurrentCustomer.IsPriority == true)
            {
                PriorityOrder priorityOrder = new PriorityOrder(DateTime.Now);
                priorityOrder.Items.AddRange(CurrentCustomer.Cart.Items);
                priorityOrder.DeliveryAddress = CurrentCustomer.Address;
                CurrentCustomer.Orders.Add(priorityOrder);
            }
            else
            {
                Order order = new Order();
                order.Items.AddRange(CurrentCustomer.Cart.Items);
                order.DeliveryAddress = CurrentCustomer.Address;
                CurrentCustomer.Orders.Add(order);
            }           
            CurrentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            SumCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            UpdateCartListBox();
        }
    }
}
