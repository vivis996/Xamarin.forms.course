using System;

using Xamarin.Forms;

namespace xamarin.forms.course.BeyondBasics
{
    public partial class TargetPage : ContentPage
    {
        public event EventHandler<double> SliderValueChanged;

        public TargetPage()
        {
            InitializeComponent();
        }

        void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.SliderValueChanged?.Invoke(this, e.NewValue);
        }
    }
}
