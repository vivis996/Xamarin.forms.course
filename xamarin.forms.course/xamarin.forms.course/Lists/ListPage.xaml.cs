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

            this.listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("D", "D")
                {
                    new Contact
                    {
                        Name = "Daniel",
                        ImageUrl = "https://bit.ly/3P5irC6",
                    },
                },
                new ContactGroup("J", "J")
                {
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
                },
            };
        }
    }
}
