using Xamarin.Forms;

namespace xamarin.forms.course
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Forms.PickerPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
