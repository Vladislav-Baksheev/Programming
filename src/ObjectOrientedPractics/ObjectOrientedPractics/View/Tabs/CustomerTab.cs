using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит логику обработки событий окна.
    /// </summary>
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создает автоматически сгенерированого покупателя.
        /// </summary>
        private CustomerFactory _customerFactory;

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
                if (Customers.Count != 0)
                {
                    foreach (Customer customer in Customers)
                    {
                        CustomersListBox.Items.Add(customer.FullName);
                    }
                    CustomersListBox.SelectedIndex = 0;
                }
                
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="CustomerTab"/>
        /// </summary>
        public CustomerTab()
        {
            InitializeComponent();
            _customerFactory = new CustomerFactory();
        }
        /// <summary>
        /// Обновляет информацию в текст боксах.
        /// </summary>
        private void UpdateTextboxes(Customer customer)
        {
            FullnameTextBox.Text = customer.FullName;
            IDTextBox.Text = customer.Id.ToString();
            addressControl1.Address = customer.Address;
            IsPriorityCheckBox.Checked = customer.IsPriority;
            discountsControl1.Discounts = customer.Discounts;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();
            Customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.FullName);
            CustomersListBox.SelectedIndex = Customers.Count - 1;
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

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPriorityCheckBox.Checked == true)
            {
                _currentCustomer.IsPriority = true;
            }
        }


    }
}
