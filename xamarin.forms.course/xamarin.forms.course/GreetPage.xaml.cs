using Xamarin.Forms;

namespace xamarin.forms.course
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }

        public void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = string.Format("Value is {0:F2}", e.NewValue);
        }
    }
}
