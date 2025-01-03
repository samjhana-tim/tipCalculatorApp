namespace TipCalculatorApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        try
        {
            double bill = Convert.ToDouble(BillEntry.Text);
            double tipPercentage = Convert.ToDouble(TipPercentageEntry.Text);
            double tip = bill * tipPercentage / 100;
            double total = bill + tip;

            TotalLabel.Text = $"Total: ${total:F2}";
        }
        catch (Exception)
        {
            TotalLabel.Text = "Please enter valid numbers.";
        }
    }
}
