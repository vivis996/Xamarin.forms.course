using Xamarin.Forms;
using System;

namespace xamarin.forms.course.BeyondBasics
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //this.Resources = new ResourceDictionary();
            //this.Resources["borderRadius"] = 20;
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            this.Resources["buttonBackgroundColor"] = Color.Pink;
        }
    }
}
