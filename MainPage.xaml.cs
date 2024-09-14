namespace TipCalculator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        
        Title = "Tip Calculator";
    }

    private void CalcualteTip(float billAmount, float tipPercent)
    {
        float tipAmount = billAmount * tipPercent;
        lblShowTipAmount.Text = tipAmount.ToString("c");

        float total = billAmount + tipAmount;
        lblShowTotal.Text = total.ToString("c");
    }

    private float GrabBillAmount()
    {
        float billAmount;
        float.TryParse(txtBillAmount.Text, out billAmount);
        return billAmount;
    }
    
    private void FifteenPercent_OnClicked(object sender, EventArgs e)
    {
        CalcualteTip(GrabBillAmount(), .15f);
        lblShowPercent.Text = lblFifteenPercent.Text;
    }

    private void TwentyPercent_OnClicked(object sender, EventArgs e)
    {
        CalcualteTip(GrabBillAmount(), .20f);
        lblShowPercent.Text = lblTwentyPercent.Text;
    }


    private void TwentyfivePercent_OnClicked(object sender, EventArgs e)
    {
        CalcualteTip(GrabBillAmount(), .25f);
        lblShowPercent.Text = lblTwentyfivePercent.Text;
    }
}