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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private ItemFactory _item;

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem = null;

        /// <summary>
        /// Возвращает и задает приоритетный заказ.
        /// </summary>
        private PriorityOrder PriorityOrder { get; set; }

        private List<string> _valueOfString
            = new List<string> {
                "None", "9:00-11:00", "11:00-13:00", "13:00-15:00",
                "15:00-17:00", "17:00-19:00", "19:00-21:00"
            };
        public PriorityOrdersTab()
        {
            InitializeComponent();
            _item = new ItemFactory();

            PriorityOrder = new PriorityOrder(DateTime.Now);

            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }

            DeliveryTimeComboBox.Items.AddRange(_valueOfString.ToArray());

            OrderItemsListBox.Items.AddRange(PriorityOrder.Items.ToArray());
            UpdateInfo();
        }
        /// <summary>
        /// ОБновляет информацию в текстовых полях.
        /// </summary>
        private void UpdateInfo()
        {
            Clear();
            TotalCostLabel.Text = "0.0";
            IDTextBox.Text = PriorityOrder.Id.ToString();
            CreatedTextBox.Text = PriorityOrder.OrderCreationDate;
            PriorityOrdersTabAddressControl.Address = PriorityOrder.DeliveryAddress;
            DeliveryTimeComboBox.SelectedItem = PriorityOrder.DesiredDeliveryTime;
            StatusComboBox.SelectedItem = PriorityOrder.OrderStatus;
            OrderItemsListBox.Items.AddRange(PriorityOrder.Items.ToArray());
            TotalCostLabel.Text = PriorityOrder.TotalCost.ToString();
        }
        /// <summary>
        /// Очищает данные в текстбоксах выбранного заказа.
        /// </summary>
        private void Clear()
        {
            IDTextBox.Clear();
            CreatedTextBox.Clear();
            StatusComboBox.SelectedIndex = -1;
            PriorityOrdersTabAddressControl.Clear();
            TotalCostLabel.Text = "0.0";
            OrderItemsListBox.Items.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = _item.CreateItem();


            PriorityOrder.Items.Add(_currentItem);
            OrderItemsListBox.Items.Add(_currentItem.Name);

            OrderItemsListBox.SelectedIndex = PriorityOrder.Items.Count - 1;
            TotalCostLabel.Text = PriorityOrder.TotalCost.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.Items.Count == 0) return;

            int index = OrderItemsListBox.SelectedIndex;

            OrderItemsListBox.Items.RemoveAt(index);
            PriorityOrder.Items.RemoveAt(index);

            OrderItemsListBox.SelectedIndex = PriorityOrder.Items.Count > 0 ? 0 : -1;
            TotalCostLabel.Text = PriorityOrder.TotalCost.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PriorityOrder = null;
            Clear();

            PriorityOrder = new PriorityOrder(DateTime.Now);
            UpdateInfo();
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.SelectedIndex == -1) return;

            PriorityOrder.DesiredDeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex == -1) return;

            PriorityOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }
    }
}
