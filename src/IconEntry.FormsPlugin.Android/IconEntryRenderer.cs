using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Xamarin.Forms;
using IconEntry.FormsPlugin.Android;
using Xamarin.Forms.Platform.Android;
using Application = Android.App.Application;
using Path = System.IO.Path;
using Resource = Android.Resource;

[assembly: ExportRenderer(typeof(IconEntry.FormsPlugin.Abstractions.IconEntry), typeof(IconEntryRenderer))]
namespace IconEntry.FormsPlugin.Android
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
                //var resId = Resources.GetIdentifier(view.Icon,"drawable", PackageName)
                //var resId = (int)typeof(Resource.Drawable).GetField(Path.GetFileNameWithoutExtension(view.Icon)).GetValue(null);

                var context = Forms.Context;
                var resId = context.Resources.GetIdentifier(Path.GetFileNameWithoutExtension(view.Icon), "drawable", context.PackageName);
                Control.SetCompoundDrawablesWithIntrinsicBounds(resId, 0, 0, 0);
            }
            else
            {
                Control.SetCompoundDrawablesWithIntrinsicBounds(0, 0, 0, 0);
            }
        }
    }
}