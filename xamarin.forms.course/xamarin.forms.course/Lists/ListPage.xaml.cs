using System;
using System.Collections.ObjectModel;
using System.Linq;
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

        ObservableCollection<Contact> GetContacts(string searchText = null)
        {
            var contacts = new ObservableCollection<Contact>
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
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                return new ObservableCollection<Contact>(
                    contacts.Where(c => c.Name.ToLower()
                                            .StartsWith(searchText.ToLower())));
            }

            return contacts;
        }

        void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "Ok");
        }

        async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            this.listView.SelectedItem = null;
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

        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            this._contacts = this.GetContacts(e.NewTextValue);
            this.listView.ItemsSource = this._contacts;
        }

        void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            // Execute by clic enter or Search button
            this._contacts = this.GetContacts((sender as SearchBar).Text);
            this.listView.ItemsSource = this._contacts;
        }
    }
}
