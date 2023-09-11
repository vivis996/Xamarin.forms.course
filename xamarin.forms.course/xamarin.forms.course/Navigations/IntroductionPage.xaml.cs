using System;

using Xamarin.Forms;

namespace xamarin.forms.course.Navigations
{
    public partial class IntroductionPage : ContentPage
    {
        public IntroductionPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            // This is demo only, to prevent
            // go back with the Cellphone's Back Button
            return false;
        }
    }
}
