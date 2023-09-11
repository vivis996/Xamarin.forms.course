using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using xamarin.forms.course.Lists;
using xamarin.forms.course.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin.forms.course.Navigations.MasterPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;
        private MyFlyoutPageFlyoutViewModel Model;

        public MyFlyoutPageFlyout()
        {
            InitializeComponent();
            this.Model = new MyFlyoutPageFlyoutViewModel();
            BindingContext = this.Model;
            ListView = MenuItemsListView;
        }

        void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "Ok");
        }

        //async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //}

        void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "Ok");
        }

        void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            this.Model.MenuItems.Remove(contact);
        }

        void listView_Refreshing(object sender, EventArgs e)
        {
            this.Model.GetContacts();
            //this.ListView.ItemsSource = this.Model.MenuItems;
            //this.listView.IsRefreshing = false;
            this.ListView.EndRefresh();
        }

        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Model.GetContacts(e.NewTextValue);
            //this.ListView.ItemsSource = this.Model.MenuItems;
        }

        void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            // Execute by clic enter or Search button
            this.Model.GetContacts((sender as SearchBar).Text);
            //this.ListView.ItemsSource = this.Model.MenuItems;
        }

        private class MyFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            private ObservableCollection<Contact> menuItems;

            public ObservableCollection<Contact> MenuItems
            {
                get => menuItems;
                set
                {
                    menuItems = value;
                    this.OnPropertyChanged();
                }
            }

            public MyFlyoutPageFlyoutViewModel()
            {
                this.GetContacts();
            }

            public void GetContacts(string searchText = null)
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
                    contacts = new ObservableCollection<Contact>(
                        contacts.Where(c => c.Name.ToLower()
                                                .StartsWith(searchText.ToLower())));
                }

                this.MenuItems = contacts;
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}