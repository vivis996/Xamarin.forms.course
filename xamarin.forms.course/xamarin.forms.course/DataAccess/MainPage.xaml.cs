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
            BindingContext = Application.Current;

            //var app = Application.Current as App;
            //this.title.Text = app.Title;
            //this.notificationsEnabled.On = app.NotificationsEnabled;
        }

        //void OnChange(object sender, EventArgs e)
        //{
        //    var app = Application.Current as App;
        //    app.Title = this.title.Text;
        //    app.NotificationsEnabled = this.notificationsEnabled.On;

        //    // Just to enforce
        //    // Application.Current.SavePropertiesAsync();
        //}

        // If I have to change view I can use this to
        // enforce the data saving
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
