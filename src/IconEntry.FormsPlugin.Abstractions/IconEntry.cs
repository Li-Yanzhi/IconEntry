using System;
using Xamarin.Forms;

namespace IconEntry.FormsPlugin.Abstractions
{
    /// <summary>
    /// IconEntry Interface
    /// </summary>
    public class IconEntry : Entry
    {
        /// <summary> 
        /// The font property 
        /// </summary> 
        public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(string), typeof(IconEntry), string.Empty);

        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
    }
}
