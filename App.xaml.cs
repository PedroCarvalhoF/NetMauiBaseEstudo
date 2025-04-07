using MauiAppNewBiAulas.Pages;
using MauiAppNewBiAulas.Pages.TabPages;

namespace MauiAppNewBiAulas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new DisplayPromptPage());
        }
    }
}