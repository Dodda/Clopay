using System;
using Xamarin.Forms;

namespace Clopay.Views
{
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            InitializeComponent();
            menuPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        /// <summary>
        ///  On each menu item selection we will change the Detail page to corresponsing,
        ///  page from MenuItem TargetType.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                menuPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            //Unsubscribe the event to avoid memory leaks
            menuPage.ListView.ItemSelected -= ListView_ItemSelected;
        }
    }
}
