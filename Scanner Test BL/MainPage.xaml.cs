using Microsoft.Maui.Controls;

namespace Scanner_Test_BL;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        MyWebView.Navigating += WebView_Navigating;
        MyWebView.Navigated += WebView_Navigated;
    }

    private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
    {
        // Handle navigation event (before navigation)
        // You can log or take any other action here
    }

    private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
    {
        // Handle navigation event (after navigation)
        // You can log or take any other action here
    }
}
