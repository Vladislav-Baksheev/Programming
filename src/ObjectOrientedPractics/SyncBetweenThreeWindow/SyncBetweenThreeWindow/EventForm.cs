namespace SyncBetweenThreeWindow
{
    public partial class EventForm : Form
    {
        private Contact _contact = new Contact();

        public Contact Contact
        {
            get
            {
                return _contact;
            }

            set
            {
                _contact = value;

                _contact.FullNameChange += FullNameChanged;
                _contact.PhoneNumberChange += PhoneNumberChanged;
                _contact.AddressChange += AddressChanged;
            }
        }

        public EventForm()
        {
            InitializeComponent();
        }

        private void FullNameChanged(object sender, ContactEventArgs e)
        {
            NameTextBox.Text = e.FullName;
        }

        private void PhoneNumberChanged(object sender, ContactEventArgs e)
        {
            PhoneTextBox.Text = e.PhoneNumber;
        }
        private void AddressChanged(object sender, ContactEventArgs e)
        {
            AddressTextBox.Text = e.Address;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.FullName = NameTextBox.Text;
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.PhoneNumber = PhoneTextBox.Text;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.Address = AddressTextBox.Text;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();

            _contact.FullNameChange -= FullNameChanged;
            _contact.PhoneNumberChange -= PhoneNumberChanged;
            _contact.AddressChange -= AddressChanged;

            Dispose();
        }
    }
}
