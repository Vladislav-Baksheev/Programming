using ProductApp.Model;

namespace ProductApp
{
    public partial class ProductAppForm : Form
    {
        public List<Product> Products = new List<Product>();

        private Product _currentProduct;

        public ProductAppForm()
        {
            InitializeComponent();
            Products = Serializator.Load();
            var category = Enum.GetValues(typeof(Category));

            foreach (var value in category)
            {
                CategoryComboBox.Items.Add(value);
            }
            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            ProductListBox.Items.Clear();
            foreach (var value in Products)
            {
                ProductListBox.Items.Add(value.Name);
            }
            var index = Products.IndexOf(_currentProduct);
            ProductListBox.SelectedIndex = Convert.ToInt32(index);
        }

        private void UpdateSelectedProduct(Product product)
        {
            NameTextBox.Text = product.Name;
            ManufacturerTextBox.Text = product.Manufacturer;
            AmountTextBox.Text = product.Amount.ToString();
            CategoryComboBox.SelectedIndex = (int)product.Category;

            foreach (Control control in SelectedProductGroupBox.Controls)
            {
                SelectedProductGroupBox.
                    Controls[SelectedProductGroupBox.Controls.IndexOf(control)].Enabled = true;
            }

        }

        private void ClearTextBoxes()
        {
            NameTextBox.Text = string.Empty;
            ManufacturerTextBox.Text = string.Empty;
            AmountTextBox.Text = string.Empty;
            CategoryComboBox.Text = string.Empty;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentProduct = new Product();
            Products.Add(_currentProduct);
            UpdateTextBoxes();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ProductListBox.SelectedIndex == -1)
            {
                return;
            }

            if (Products.Count > 0)
            {
                ProductListBox.Items.RemoveAt(Products.IndexOf(_currentProduct));
                Products.RemoveAt(Products.IndexOf(_currentProduct));
                ProductListBox.SelectedIndex = Products.Count > 0 ? 0 : -1;
            }
            UpdateSelectedProduct(_currentProduct);
        }


        private List<Product> SortName(List<Product> product)
        {
            var sortedProducts = from value in product
                                 orderby value.Name
                                 select value;
            product = sortedProducts.ToList();

            return product;
        }
        private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductListBox.SelectedIndex == -1) return;

            _currentProduct = Products[ProductListBox.SelectedIndex];
            UpdateSelectedProduct(_currentProduct);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Colors.NormalColor;
                _currentProduct.Name = NameTextBox.Text;
                ProductListBox.Items[Products.IndexOf(_currentProduct)] = _currentProduct.Name;
            }
            catch
            {
                NameTextBox.BackColor = Colors.BadColor;
            }
        }

        private void ManufacturerTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ManufacturerTextBox.BackColor = Colors.NormalColor;
                _currentProduct.Manufacturer = ManufacturerTextBox.Text;
            }
            catch
            {
                ManufacturerTextBox.BackColor = Colors.BadColor;
            }
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AmountTextBox.BackColor = Colors.NormalColor;
                _currentProduct.Amount = Convert.ToInt32(AmountTextBox.Text);
            }
            catch
            {
                AmountTextBox.BackColor = Colors.BadColor;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentProduct.Category = (Category)CategoryComboBox.SelectedItem;
        }

        private void ProductAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializator.Save(Products);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            Products = SortName(Products);
            UpdateTextBoxes();
        }
    }
}