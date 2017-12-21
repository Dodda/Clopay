using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clopay.Extensions
{
    //Extension class used to set the images to control from Portable library
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source
        {
            get;
            set;
        }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            return ImageSource.FromResource(Source);
        }
    }
}
