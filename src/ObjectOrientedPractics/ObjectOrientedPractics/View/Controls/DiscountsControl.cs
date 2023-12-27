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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class DiscountsControl : UserControl
    {
        /// <summary>
        /// Список скидок.
        /// </summary>
        private List<IDiscount> _discounts = new List<IDiscount>();

        /// <summary>
        /// Возвращает и задает список скидок.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<IDiscount> Discounts
        {
            get { return _discounts; }
            set
            {
                _discounts = value;

                UpdateDiscounts();
            }
        }
        public DiscountsControl()
        {
            InitializeComponent();
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddPercentDiscountForm addPercentDiscountForm = new AddPercentDiscountForm();
            if(addPercentDiscountForm.ShowDialog() == DialogResult.OK)
            {
                Discounts.Add(addPercentDiscountForm.PercentDiscount);
                UpdateDiscounts();
            }          
            addPercentDiscountForm.Dispose();
        }
        public void UpdateDiscounts()
        {
            DiscountsListBox.Items.Clear();

            if (Discounts != null)
            {
                foreach (var discount in Discounts)
                {
                    DiscountsListBox.Items.Add(discount.Info);
                }
            }
            else
            {
                DiscountsListBox.Items.Clear();
            }
        }
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex == -1 || DiscountsListBox.SelectedIndex == 0) return;

            Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
            UpdateDiscounts();
        }
    }
}
