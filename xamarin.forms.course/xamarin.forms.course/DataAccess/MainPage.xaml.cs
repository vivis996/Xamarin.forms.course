using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.DataAccess
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("Name"))
                this.title.Text = Application.Current.Properties["Name"].ToString();
            if (Application.Current.Properties.ContainsKey("notificationsEnabled"))
                this.notificationsEnabled.On = (bool)Application.Current.Properties["notificationsEnabled"];
        }

        void OnChange(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = this.title.Text;
            Application.Current.Properties["notificationsEnabled"] = this.notificationsEnabled.On;

            // Just to enforce
            // Application.Current.SavePropertiesAsync();
        }

        // If I have to change view I can use this to
        // enforce the data saving
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
