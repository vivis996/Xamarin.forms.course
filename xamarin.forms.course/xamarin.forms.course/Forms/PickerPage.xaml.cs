using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace xamarin.forms.course.Forms
{
    public partial class PickerPage : ContentPage
    {
        private List<ContactMethod> _contactMethods;
        public PickerPage()
        {
            InitializeComponent();
            this._contactMethods = this.GetContactMethods();
            this.picker.ItemsSource = this._contactMethods;
        }

        void contactMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contactMethod = this.picker.SelectedItem as ContactMethod;
            if (contactMethod == null)
                return;

            DisplayAlert("Selection", contactMethod.Name, "Ok");
        }

        private List<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod
                {
                    Id = 1,
                    Name = "SMS",
                },
                new ContactMethod
                {
                    Id = 2,
                    Name = "Email",
                },
            };
        }
    }

    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
