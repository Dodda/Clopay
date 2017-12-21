using Xamarin.Forms;

namespace Clopay.Views
{
    public partial class MenuPage : ContentPage
    {
        public ListView ListView { get { return listView; }}

        public MenuPage()
        {
            InitializeComponent();

            //Setting the BindingContext to MenuViewModel from the ViewModelLocator.
            BindingContext = App.Locator.MenuViewModel;
        }
    }
}
