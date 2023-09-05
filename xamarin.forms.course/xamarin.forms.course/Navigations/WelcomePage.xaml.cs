using System;

using Xamarin.Forms;

namespace xamarin.forms.course.Navigations
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new IntroductionPage());
        }
    }
}
