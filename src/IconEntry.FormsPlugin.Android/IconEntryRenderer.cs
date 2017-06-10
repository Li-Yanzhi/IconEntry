using System;
using Android.Runtime;
using Xamarin.Forms;
using IconEntry.FormsPlugin.Android;
using Xamarin.Forms.Platform.Android;
using Path = System.IO.Path;

[assembly: ExportRenderer(typeof(IconEntry.FormsPlugin.Abstractions.IconEntry), typeof(IconEntryRenderer))]
namespace IconEntry.FormsPlugin.Android
{
    /// <summary>
    /// IconEntry Renderer
    /// </summary>
    [Preserve(AllMembers = true)]
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
                //var resId = Resources.GetIdentifier(view.Icon,"drawable", PackageName)
                //var resId = (int)typeof(Resource.Drawable).GetField(Path.GetFileNameWithoutExtension(view.Icon)).GetValue(null);

                try
                {
                    var context = Forms.Context;
                    var resId = context.Resources.GetIdentifier(Path.GetFileNameWithoutExtension(view.Icon), "drawable", context.PackageName);
                    if(resId != 0)
                        Control.SetCompoundDrawablesWithIntrinsicBounds(resId, 0, 0, 0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Control.SetCompoundDrawablesWithIntrinsicBounds(0, 0, 0, 0);
            }
        }
    }
}