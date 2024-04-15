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

            var category = Enum.GetValues(typeof(Category));

            foreach (var value in category)
            {
                CategoryComboBox.Items.Add(value);
            }
        }

        private void UpdateTextBoxes()
        {
            ProductListBox.Items.Clear();
            Products = SortName(Products);
            foreach (var value in Products)
            {
                ProductListBox.Items.Add(value.OutputInformation());
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
            MessageBox.Show("sdf");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sdf");
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
            _currentProduct = Products[ProductListBox.SelectedIndex];
            UpdateSelectedProduct(_currentProduct);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentProduct.Name = NameTextBox.Text;
            UpdateTextBoxes();
        }

        private void ManufacturerTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentProduct.Manufacturer = ManufacturerTextBox.Text;
            UpdateTextBoxes();
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentProduct.Amount = Convert.ToInt32(AmountTextBox.Text);
            UpdateTextBoxes();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentProduct.Category = (Category)CategoryComboBox.SelectedItem;
            UpdateTextBoxes();
        }
    }
}