using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using IconEntry.FormsPlugin.Android;
using IconEntrySample.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using IconEntrySample;

[assembly: ExportRenderer(typeof(MyIconEntry), typeof(MyIconEntryRenderer))]
namespace IconEntrySample.Droid
{
    public class MyIconEntryRenderer : IconEntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null || e.OldElement != null) return;

            Control.Background.SetColorFilter(Android.Graphics.Color.Blue, PorterDuff.Mode.SrcAtop);
        }

        
    }
}

