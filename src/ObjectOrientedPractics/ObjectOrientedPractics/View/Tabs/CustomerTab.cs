using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {

        private List<Customer> _customers = new List<Customer>();

        private Customer _currentCustomer;

        private CustomerFactory _customerFactory;
        private List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                if (Customers.Count != 0)
                {
                    foreach (Customer customer in Customers)
                    {
                        CustomersListBox.Items.Add(customer.FullName);
                    }
                }
                CustomersListBox.SelectedIndex = 0;
            }
        }
        public CustomerTab()
        {
            InitializeComponent();
            _customerFactory = new CustomerFactory();
        }
        private void UpdateTextboxes(Customer customer)
        {
            FullnameTextBox.Text = customer.FullName;
            AddressTextBox.Text = customer.Address;
            IDTextBox.Text = customer.Id.ToString();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();
            Customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.FullName);
            UpdateTextboxes(_currentCustomer);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(Customers.Count == 0)
            {
                return;
            }
            Customers.Remove(_currentCustomer);
            CustomersListBox.Items.Remove(_currentCustomer.FullName);
            CustomersListBox.SelectedIndex = Customers.Count > 0 ? 0 : -1;
            UpdateTextboxes(_currentCustomer);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = _customerFactory.CreateCustomer();
            Customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.FullName);
            CustomersListBox.SelectedIndex = Customers.Count - 1;
            UpdateTextboxes(_currentCustomer);
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if(index == -1)
            {
                return;
            }
            _currentCustomer = Customers[index];
            UpdateTextboxes(_currentCustomer);
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullnameTextBox.BackColor = AppColor.GoodBackColor;
                _currentCustomer.FullName = FullnameTextBox.Text;
                CustomersListBox.Items[Customers.IndexOf(_currentCustomer)] = _currentCustomer.FullName;
            }
            catch(Exception ex)
            {
                FullnameTextBox.BackColor= AppColor.ErrorBackColor;
                if (Customers.Count == 0)
                {
                    FullnameTextBox.BackColor = AppColor.GoodBackColor;
                }
            }
            
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = AppColor.GoodBackColor;
                _currentCustomer.Address = AddressTextBox.Text;
            }
            catch (Exception ex)
            {
                AddressTextBox.BackColor = AppColor.ErrorBackColor;
                if (Customers.Count == 0)
                {
                    AddressTextBox.BackColor = AppColor.GoodBackColor;
                }
            }
        }
    }
}
