using Xamarin.Forms;

namespace xamarin.forms.course
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "Ok");
        }
    }
}
