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

            this.btn.ImageSource = ImageSource.FromFile("clock.png");
        }
    }
}
