namespace OouiTestXamlApp.ViewModels
{
    using System.Windows.Input;
    using Xamarin.Forms;

    public class MainPageViewModel : BindableObject
    {
        private int count = 0;
        private string buttonText;

        public MainPageViewModel()
        {
            ButtonClickedCommand = new Command(OnButtonClicked);
            ButtonText = "Click Me!";
        }

        public ICommand ButtonClickedCommand
        {
            get;
            private set;
        }

        public string ButtonText
        {
            get { return buttonText; }
            set
            {
                buttonText = value;
                OnPropertyChanged();
            }
        }

        private void OnButtonClicked(object parameter)
        {
            count++;
            ButtonText = $"You have clicked me {count} times !";
        }
    }
}
