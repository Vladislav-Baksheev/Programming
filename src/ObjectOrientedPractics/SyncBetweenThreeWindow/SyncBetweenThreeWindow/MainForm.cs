namespace SyncBetweenThreeWindow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var contact = new Contact();

            Form form1 = new EventForm()
            {
                Text = "Main Window", Contact = contact
            };
            Form form2 = new EventForm()
            {
                Text = "Secondary Window", Contact = contact
            };
            Form form3 = new EventForm()
            {
                Text = "Third Window", Contact = contact
            };
            form1.Show();
            form2.Show();
            form3.Show();
        }
    }
}
