using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Navigations
{
    public partial class ToolbarMainPage : ContentPage
    {
        public ToolbarMainPage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Ativated", "ToolbarItem Activated", "Ok");
        }

        void ToolbarItemSecondary_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Ativated", "ToolbarItem Secondary Activated", "Ok");
        }
    }
}

