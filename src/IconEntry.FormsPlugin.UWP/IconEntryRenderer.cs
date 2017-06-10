using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using IconEntry.FormsPlugin.UWP;

[assembly: ExportRenderer(typeof(IconEntry.FormsPlugin.Abstractions.IconEntry), typeof(IconEntryRenderer))]
namespace IconEntry.FormsPlugin.UWP
{
    public class IconEntryRenderer : EntryRenderer
    {
        public async static void Init()
        {
            var temp = DateTime.Now;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var view = (Abstractions.IconEntry)Element;

            if (view != null)
            {
                SetIcon(view);
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var view = (Abstractions.IconEntry)Element;
            if (e.PropertyName == Abstractions.IconEntry.IconProperty.PropertyName)
                SetIcon(view);
        }

        private void SetIcon(Abstractions.IconEntry view)
        {
            if (!string.IsNullOrEmpty(view.Icon))
            {
                var ib = new ImageBrush
                {
                    ImageSource = new BitmapImage
                    {
                        UriSource = new Uri($"ms-appx:///Assets/{view.Icon}")
                    },
                    Stretch = Stretch.None,
                    AlignmentX = AlignmentX.Left
                };
                Control.Background = ib;

                //Should merge IconEntryStyle in Application Resource Dictionaries firstly
                var style = Windows.UI.Xaml.Application.Current.Resources["IconTextBoxStyle"];
                if (style != null)
                    Control.Style = (Windows.UI.Xaml.Style) style;
            }
        }
    }
}
