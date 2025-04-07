using MauiAppNewBiAulas.Pages.TabPages;
using System.Threading.Tasks;

namespace MauiAppNewBiAulas.Pages;

public partial class DisplayPromptPage : ContentPage
{
    string nome;
    public DisplayPromptPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        nome = await DisplayPromptAsync("Nome", "Digite seu nome", "OK", "Cancelar", "Nome", 100, Keyboard.Text);

        if (nome != null)
        {
            await DisplayAlert("Nome", "Seu nome é " + nome, "OK");
        }
        else
        {
            await DisplayAlert("Nome", "Você não digitou seu nome", "OK");
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new MainTabPage());
    }

}