using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Navigations
{
    public partial class PopupMainPage : ContentPage
    {
        public PopupMainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");

            if (response)
            {
                await DisplayAlert("Done", "Your response will be saved!", "ok");
            }
        }

        async void MoreOptions_Clicked(System.Object sender, System.EventArgs e)
        {
            var options = new[] { "Copy link", "Message", "Email" };

            var response = await DisplayActionSheet("Title test", "Cancel", "Delete", options);
            await DisplayAlert("Reponse", response, "Ok");
        }
    }
}
