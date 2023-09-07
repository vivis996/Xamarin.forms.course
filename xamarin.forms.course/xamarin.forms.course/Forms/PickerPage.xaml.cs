using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace xamarin.forms.course.Forms
{
    public partial class PickerPage : ContentPage
    {
        private IList<ContactMethod> _contactMethods;
        public PickerPage()
        {
            InitializeComponent();
            this._contactMethods = this.GetContactMethods();
            foreach (var method in this._contactMethods)
            {
                this.picker.Items.Add(method.Name);
            }
        }

        void contactMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = this.picker.Items[picker.SelectedIndex];
            var contactMethod = this._contactMethods
                                        .Single(cm => cm.Name == name);
            DisplayAlert("Selection", contactMethod.Name, "Ok");
        }

        private IList<ContactMethod> GetContactMethods()
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
