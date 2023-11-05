namespace Programming;
using Programming.Model;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }


    private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        ValueListBox.Items.Clear();

        Type type = Type.GetType($"Programming.Model.{EnumsListBox.SelectedItem}");

        var values = Enum.GetValues(type);

        foreach (var value in values)
        {
            ValueListBox.Items.Add(value);
        }

        IntValueTextBox.Text = "";
    }
}
