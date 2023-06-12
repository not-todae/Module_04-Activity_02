using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MODULE04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Openactivity5(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new activity5());
        }
    }
}
