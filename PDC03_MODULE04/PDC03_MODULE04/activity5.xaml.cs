using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity5 : ContentPage
    {
        List<Contacts> contacts;
        public activity5()
        {
            InitializeComponent();

            SetupData();
            ListView.ItemsSource = contacts;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (ListView.SelectedItem != null)
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                ListView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contacts>();

            contacts.Add(new Contacts
            {
                Name = "Andres Bonifacio",
                Age = 35,
                Occupation = "Analyst",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Tandang Sora",
                Age = 60,
                Occupation = "Developer",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Heneral Luna",
                Age = 25,
                Occupation = "Tester",
                Country = "Japan"
            });

            contacts.Add(new Contacts
            {
                Name = "Josie Rizal",
                Age = 24,
                Occupation = "Programmer",
                Country = "Korea"
            });

            contacts.Add(new Contacts
            {
                Name = "Douglas McArthur",
                Age = 21,
                Occupation = "UI/UX",
                Country = "USA"
            });
        }

    }
}