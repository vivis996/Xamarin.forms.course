using Xamarin.Forms;

namespace xamarin.forms.course
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    Padding = new Thickness(10, 20, 0, 0);
                    break;
            }

            // Is deprecated
            // Device.OnPlatform();
        }
    }
}
