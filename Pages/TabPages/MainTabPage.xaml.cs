namespace MauiAppNewBiAulas.Pages.TabPages;

public partial class MainTabPage : TabbedPage
{
    public MainTabPage()
    {
        InitializeComponent();

        var urlVideoYouTube = "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/m3Znx2m3FgQ?si=B9e8vl4yJplHvqMQ\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>";

        webViewPersonalizado.Source = new HtmlWebViewSource
        {
            Html = urlVideoYouTube
        };
    }

    private void btnVoltarInicio_Clicked(object sender, EventArgs e)
    {
        if (App.Current == null)
            return;



        App.Current.MainPage = new NavigationPage(new DisplayPromptPage());
    }
}