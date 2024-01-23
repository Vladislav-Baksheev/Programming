namespace Programming;
using Programming.Model;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        EnumsListBox.SelectedIndex = 0;
        Array values = Enum.GetValues(typeof(Season));
        foreach (var value in values)
        {
            SeasonComboBox.Items.Add(value.ToString());
        }
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

    private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        IntValueTextBox.Text = ((int)ValueListBox.SelectedItem).ToString();
    }

    private void ParseButton_Click(object sender, EventArgs e)
    {
        string text = ParseTextBox.Text;

        if (Enum.TryParse(text, out Weekday weekday))
        {
            WeekdayLabel.Text = $"Это день недели ({text} = {(int)weekday})";
        }
        else
        {
            WeekdayLabel.Text = "Нет такого дня недели";
        }
    }

    private void GoButton_Click(object sender, EventArgs e)
    {
        switch (SeasonComboBox.SelectedIndex)
        {
            case 0:
                MessageBox.Show("Ура, солнце!");
                break;
            case 1:
                EnumsTabPage.BackColor = System.Drawing.Color.Yellow;
                break;
            case 2:
                EnumsTabPage.BackColor = System.Drawing.Color.Green;
                break;
            case 3:
                MessageBox.Show("Брр, холодно!");
                break;
        }
    }
}
