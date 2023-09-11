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

        void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                this.contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }
    }
}
