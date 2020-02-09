using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MinimalistAlphabet
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Upper.Clicked += Upper_Clicked;
            Lower.Clicked += Lower_Clicked;
            Numbers.Clicked += Numbers_Clicked;
        }

        private void Upper_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Letters("Upper"));
        }

        private void Lower_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Letters("Lower"));
        }

        private void Numbers_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Letters("Numbers"));
        }        

        
    }
}
