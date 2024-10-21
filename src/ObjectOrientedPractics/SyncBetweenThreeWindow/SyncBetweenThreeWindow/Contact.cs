namespace SyncBetweenThreeWindow
{
    public class Contact
    {
        private string _fullName;

        private string _phoneNumber;

        private string _address;

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (value != _fullName)
                {
                    var args = new ContactEventArgs()
                    {
                        FullName = value
                    };

                    _fullName = value;

                    FullNameChange?.Invoke(this, args);
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value != _phoneNumber)
                {
                    var args = new ContactEventArgs()
                    {
                        PhoneNumber = value
                    };

                    _phoneNumber = value;

                    PhoneNumberChange?.Invoke(this, args);
                }
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value != _address)
                {
                    var args = new ContactEventArgs()
                    {
                        Address = value
                    };

                    _address = value;

                    AddressChange?.Invoke(this, args);
                }
            }
        }

        public event EventHandler<ContactEventArgs> FullNameChange;

        public event EventHandler<ContactEventArgs> PhoneNumberChange;

        public event EventHandler<ContactEventArgs> AddressChange;
    }
}
