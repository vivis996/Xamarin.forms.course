using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin.forms.course
{
    // This is just if you have to skip it
    //[XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }
    }
}
