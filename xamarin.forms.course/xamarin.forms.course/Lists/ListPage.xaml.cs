using System;
using System.Collections.Generic;
using xamarin.forms.course.Models;
using Xamarin.Forms;

namespace xamarin.forms.course.Lists
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            this.listView.ItemsSource = new List<Contact>
            {
                new Contact
                {
                    Name = "Daniel",
                    ImageUrl = "https://bit.ly/3P5irC6",
                },
                new Contact
                {
                    Name = "John",
                    ImageUrl = "https://bit.ly/3P5irC6",
                    Status = "Hey!, let's talk",
                },
                new Contact
                {
                    Name = "Joana",
                    ImageUrl = "https://bit.ly/3P5irC6",
                    Status = "I'm new here",
                },
            };
        }

        void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "Ok");
        }

        void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "Ok");
            listView.SelectedItem = null;
        }
    }
}
