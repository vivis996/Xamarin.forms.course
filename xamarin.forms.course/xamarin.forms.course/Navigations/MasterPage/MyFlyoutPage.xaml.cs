using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xamarin.forms.course.Lists;
using xamarin.forms.course.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin.forms.course.Navigations.MasterPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPage : FlyoutPage
    {
        public MyFlyoutPage()
        {
            InitializeComponent();
            FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            if (contact == null)
                return;
            var page = new ContactDetailPage(contact);
            page.Title = contact.Name;

            Detail = new NavigationPage(page);
            IsPresented = false;

            FlyoutPage.ListView.SelectedItem = null;
        }
    }
}