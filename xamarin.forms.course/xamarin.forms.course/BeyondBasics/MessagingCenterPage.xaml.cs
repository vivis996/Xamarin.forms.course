using System;

using Xamarin.Forms;

namespace xamarin.forms.course.BeyondBasics
{
    public partial class MessagingCenterPage : ContentPage
    {
        public MessagingCenterPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<TargetPage, double>(this, "SliderValueChanged", this.OnSliderValueChanged);
            // If I don't need the "event" anymore
            //MessagingCenter.Unsubscribe<MainPage>(this, "SliderValueChanged");
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TargetPage());
        }

        private void OnSliderValueChanged(TargetPage source, double newValue)
        {
            this.label.Text = newValue.ToString();
        }
    }
}
