using Xamarin.Forms;

namespace xamarin.forms.course.BeyondBasics
{
    public partial class TargetPage : ContentPage
    {
        public TargetPage()
        {
            InitializeComponent();
        }

        void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MessagingCenter.Send(this, "SliderValueChanged", e.NewValue);
        }
    }
}
