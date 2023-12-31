﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;

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
            DiscountsCheckedListBox.Items.Clear();

            foreach (var item in CurrentCustomer.Cart.Items)
            {
                CartListBox.Items.Add(item.Name);
            }
            foreach (var discount in CurrentCustomer.Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount.Info);
                DiscountsCheckedListBox.SetItemChecked(DiscountsCheckedListBox.Items.IndexOf(discount.Info), true);
            }

            CalculatedDiscount();

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
            UpdateCartListBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1
                || CurrentCustomer == null || CartListBox.Items.Count == 0)
                return;
            CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
            SumCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            UpdateCartListBox();
        }

        /// <summary>
        /// Применяет скидку к заказу.
        /// </summary>
        /// <returns>возвращает </returns>
        private double ApplyDiscount()
        {
            double value = 0;

            foreach (var discount in CurrentCustomer.Discounts)
            {
                int index = DiscountsCheckedListBox.Items.IndexOf(discount.Info);

                if (DiscountsCheckedListBox.GetItemChecked(index))
                {
                    value += discount.Calculate(CurrentCustomer.Cart.Items);
                }

                discount.Update(CurrentCustomer.Cart.Items);
            }

            return value;
        }

        /// <summary>
        /// Подсчитывает скидку и обновляет стоимость в Label.
        /// </summary>
        private void CalculatedDiscount()
        {
            double value = 0;

            foreach (var discount in CurrentCustomer.Discounts)
            {
                int index = DiscountsCheckedListBox.Items.IndexOf(discount.Info);

                if (DiscountsCheckedListBox.GetItemChecked(index))
                {
                    value += discount.Calculate(CurrentCustomer.Cart.Items);
                }
            }

            DiscountAmountLabel.Text = value.ToString();
            TotalLabel.Text = (CurrentCustomer.Cart.Amount - value).ToString();
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
            UpdateCartListBox();
            if (CurrentCustomer.IsPriority == true)
            {
                PriorityOrder Order = new PriorityOrder(DateTime.Now);
                Order.Items.AddRange(CurrentCustomer.Cart.Items);
                Order.DeliveryAddress = CurrentCustomer.Address;
                Order.DiscountAmount = ApplyDiscount();
                CurrentCustomer.Orders.Add(Order);  
            }
            else
            {
                Order Order = new Order();
                Order.Items.AddRange(CurrentCustomer.Cart.Items);
                Order.DeliveryAddress = CurrentCustomer.Address;
                Order.DiscountAmount = ApplyDiscount();
                CurrentCustomer.Orders.Add(Order);
            }           
            CurrentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            SumCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            
            
        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DiscountsCheckedListBox.Items.Count == 0) return;
            CalculatedDiscount();
        }
    }
}
