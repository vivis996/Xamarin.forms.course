using System;

using Xamarin.Forms;

namespace xamarin.forms.course.BeyondBasics
{
    public partial class MessagingCenterPage : ContentPage
    {
        public MessagingCenterPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            var page = new TargetPage();
            page.SliderValueChanged += OnSliderValueChanged;
            this.Navigation.PushAsync(page);
        }

        private void OnSliderValueChanged(object source, double newValue)
        {
            this.label.Text = newValue.ToString();
        }
    }
}
