using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using IconEntry.FormsPlugin.iOS;

[assembly: ExportRenderer(typeof(IconEntry.FormsPlugin.Abstractions.IconEntry), typeof(IconEntryRenderer))]
namespace IconEntry.FormsPlugin.iOS
{
    /// <summary>
    /// IconEntry Renderer
    /// </summary>
    public class IconEntryRenderer : EntryRenderer
    {
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
                Control.LeftViewMode = UITextFieldViewMode.Always;
                Control.LeftView = new UIImageView(UIImage.FromBundle(view.Icon));
            }
            else
            {
                Control.LeftViewMode = UITextFieldViewMode.Never;
                Control.LeftView = null;
            }
        }
    }
}
