using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Forms
{
    public partial class TableViewPage : ContentPage
    {
        public TableViewPage()
        {
            InitializeComponent();
        }

        void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Changing switch", e.Value.ToString(), "Ok");
        }
    }
}
