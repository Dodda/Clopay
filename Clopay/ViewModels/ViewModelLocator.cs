using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace Clopay.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<MenuViewModel>();
        }

        public HomeViewModel HomeViewModel => ServiceLocator.Current.GetInstance<HomeViewModel>();

        public MenuViewModel MenuViewModel => ServiceLocator.Current.GetInstance<MenuViewModel>();
    }
}
