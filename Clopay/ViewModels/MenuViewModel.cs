using System.Collections.Generic;
using Clopay.Views;
using GalaSoft.MvvmLight;

namespace Clopay.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        private List<MenuItem> menuItem;
        public List<MenuItem> MuniItems
        {
            get { return menuItem; }
            set
            {
                if (menuItem != value)
                {
                    menuItem = value;
                    RaisePropertyChanged(nameof(MuniItems));
                }
            }
        }

        public MenuViewModel()
        {
            menuItem = new List<MenuItem>
            {
                new MenuItem {IconSource = "home.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "calendar.png", TargetType = typeof(CalendarPage)},
                new MenuItem {IconSource = "money.png", TargetType = typeof(MoneyPage)},
                new MenuItem {IconSource = "news.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "saveas.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "search.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "settings.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "clock.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "cloud.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "phone.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "map.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "share.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "shopping.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "contacts.png", TargetType = typeof(DetailsPage)},
                new MenuItem {IconSource = "download.png", TargetType = typeof(DetailsPage)}
            };
        }
    }
}
