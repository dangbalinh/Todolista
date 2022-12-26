using Prism.Navigation;
using System.Windows.Input;
using ToDoApp.Views;
using Xamarin.Forms;

namespace ToDoApp.ViewModels
{
    public class WelcomePageViewModel: BaseViewModel
    {
        

        public ICommand GetStartedCommand { get; set; }

      

    

        public WelcomePageViewModel(
            INavigationService navigationService) : base(navigationService)
        { 
            GetStartedCommand = new Command(GetStartedCommandHandler);
        }

       

      

        private async void GetStartedCommandHandler()
        {
            await _navigationService.NavigateAsync(nameof(AuthPage));
        }

        
    }
}
