using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Возвращает и задает список заказов;
        /// </summary>
        private List<Order> Orders { get; set; }

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _selectedOrder;

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            Customers = new List<Customer>();
            Orders = new List<Order>();

            foreach (Enum orderStatus in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(orderStatus);
            }

        }
        /// <summary>
        /// Обновляет данные в таблице заказов.
        /// </summary>
        private void UpdateOrders()
        {
            dataGridView1.Rows.Clear();

            if (Customers.Count == 0)
            {
                return;
            }

            foreach (var customer in Customers)
            {
                foreach (var order in customer.Orders)
                {
                    Orders.Add(order);
                    dataGridView1.Rows.Add(order.Id, order.OrderCreationDate, order.OrderStatus,
                        customer.FullName, order.DeliveryAddress.AddressToString(), order.TotalCost);
                }
            }
        }
        /// <summary>
        /// Очищает данные в текстбоксах выбранного заказа.
        /// </summary>
        private void ClearSelectedOrder()
        {
            IDTextBox.Clear();
            CreatedTextBox.Clear();
            addressControl1.Clear();
            StatusComboBox.SelectedIndex = -1;
            TotalCostLabel.Text = "0";

            OrderItemsListBox.Items.Clear();
            StatusComboBox.Enabled = false;
            _selectedOrder = null;
        }

        /// <summary>
        /// Обновляет данные вкладки при переходе на нее.
        /// </summary>
        public void RefreshData()
        {
            ClearSelectedOrder();
            UpdateOrders();
        }

        /// <summary>
        /// Обновляет информацию о выбранном заказе.
        /// </summary>
        /// <param name="id"></param>
        private void UpdateSelectedOrders(int id)
        {
            ClearSelectedOrder();

            _selectedOrder = Orders.Find(order => order.Id == id);

            StatusComboBox.Enabled = true;

            _selectedOrder = Orders.Find(order => order.Id == id);

            IDTextBox.Text = _selectedOrder.Id.ToString();
            CreatedTextBox.Text = _selectedOrder.OrderCreationDate;
            StatusComboBox.SelectedItem = _selectedOrder.OrderStatus;
            addressControl1.Address = _selectedOrder.DeliveryAddress;
            TotalCostLabel.Text = _selectedOrder.TotalCost.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 ||
                dataGridView1.SelectedCells[0].FormattedValue.ToString() == "")
                return;

            UpdateSelectedOrders(Convert.ToInt32(dataGridView1.SelectedCells[0].FormattedValue));
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex == -1) return;

            int index = dataGridView1.CurrentCell.RowIndex;

            _selectedOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedIndex;
            dataGridView1.Rows[index].Cells[2].Value = (OrderStatus)StatusComboBox.SelectedIndex;
        }
    }
}
