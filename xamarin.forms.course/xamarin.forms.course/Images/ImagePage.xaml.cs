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

            const string imagePath = "xamarin.forms.course.files.images.background.jpg";
            this.image.Source = ImageSource.FromResource(imagePath);
        }
    }
}
