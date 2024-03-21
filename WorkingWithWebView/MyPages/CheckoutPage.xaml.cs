using WorkingWithWebview;

namespace WorkingWithWebView.MyPages;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class CheckoutPage : ContentPage
{
	public CheckoutPage()
	{
		InitializeComponent();
    }

    private void onClickCheckout(object sender, EventArgs e)
    {
       Navigation.PushAsync(new Cashfree());
    }
}