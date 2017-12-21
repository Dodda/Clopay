using Xamarin.Forms;

namespace Clopay.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            //Setting the BindingContext to HomeViewModel from the ViewModelLocator.
            BindingContext = App.Locator.HomeViewModel;
        }
    }
}
