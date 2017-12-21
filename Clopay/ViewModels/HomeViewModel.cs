using Clopay.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace Clopay.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public RelayCommand GoCommand
        {
            get;
        }

        public HomeViewModel()
        {
            GoCommand = new RelayCommand(() =>
            {
                //Setting the Master-Detail page to MainPage.
                RootPage rootpage = new RootPage();
                Application.Current.MainPage = rootpage;
            });
        }
    }
}
