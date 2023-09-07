using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Forms
{
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            label.IsVisible = e.Value;
        }
    }
}
