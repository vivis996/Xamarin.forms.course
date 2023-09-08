using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Forms
{
    public partial class ContactMethodsPage : ContentPage
    {
        public ListView ContactMethods { get => this.listView; }

        public ContactMethodsPage()
        {
            InitializeComponent();

            this.listView.ItemsSource = this.GetItems();
        }

        List<string> GetItems()
        {
            return new List<string>
            {
                "None",
                "Email",
                "SMS",
            };
        }
    }
}
