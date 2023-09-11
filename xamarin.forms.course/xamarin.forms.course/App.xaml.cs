using Xamarin.Forms;

namespace xamarin.forms.course
{
    public partial class App : Application
    {
        #region Application Properties
        private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationsEnabled";

        public string Title
        {
            get => this.GetObject(TitleKey, string.Empty).ToString();
            set => Properties[TitleKey] = value;
        }

        public bool NotificationsEnabled
        {
            get => (bool)this.GetObject(NotificationsEnabledKey, false);
            set => Properties[NotificationsEnabledKey] = value;
        }
        #endregion

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BeyondBasics.MessagingCenterPage());
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

        #region My methods
        private object GetObject(string key, object @default)
        {
            if (Properties.ContainsKey(key))
                return Properties[key];
            return @default;
        }
        #endregion
    }
}
