using System;
using System.Collections.ObjectModel;
using xamarin.forms.course.Models;
using Xamarin.Forms;

namespace xamarin.forms.course.Lists
{
    public partial class ListPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        public ListPage()
        {
            InitializeComponent();

            this._contacts = this.GetContacts();

            this.listView.ItemsSource = this._contacts;
        }

        ObservableCollection<Contact> GetContacts()
        {
            return new ObservableCollection<Contact>
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

        void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "Ok");
        }

        void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            this._contacts.Remove(contact);
        }

        void listView_Refreshing(object sender, EventArgs e)
        {
            this._contacts = this.GetContacts();
            this.listView.ItemsSource = this._contacts;
            //this.listView.IsRefreshing = false;
            this.listView.EndRefresh();
        }
    }
}
