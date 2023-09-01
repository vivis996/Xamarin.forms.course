using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Images
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            const string imagePath = "https://wallpapers.com/images/featured/hd-a5u9zq0a0ymy2dug.jpg";
            //this.image.Source = (UriImageSource)ImageSource.FromUri(new Uri(imagePath));
            var imageSource = new UriImageSource { Uri = new Uri(imagePath) };
            imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            this.image.Source = imageSource;
            //this.image.Aspect = Aspect.AspectFill;
            //this.image.Source = imagePath;
        }
    }
}
