using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Forms
{
    public partial class SliderPage : ContentPage
    {
        public SliderPage()
        {
            InitializeComponent();
        }

        void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // e.NewValue
            // e.OldValue
        }
    }
}
