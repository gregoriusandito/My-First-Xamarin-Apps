using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnFirstButtonXaml(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new View.HOL1Page());
        }

    }
}
