namespace OouiTestXamlApp
{
    using Ooui;
    using Xamarin.Forms;

    class Program
    {
        static void Main(string[] args)
        {
            Forms.Init();
            var page = new MainPage();
            UI.Publish("/", page.GetOouiElement());
        }
    }
}
