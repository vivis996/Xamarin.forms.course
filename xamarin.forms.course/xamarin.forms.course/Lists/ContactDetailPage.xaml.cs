using System;
using xamarin.forms.course.Models;
using Xamarin.Forms;

namespace xamarin.forms.course.Lists
{
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException();
            BindingContext = contact;

            InitializeComponent();
        }

        public ContactDetailPage()
            : this(new Contact { Name = "Undefined" })
        {

        }
    }
}
