namespace OouiTestXamlApp
{
    using OouiTestXamlApp.ViewModels;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
	{
        public MainPage()
		{
			InitializeComponent();
            BindingContext = new MainPageViewModel();
		}
    }
}
