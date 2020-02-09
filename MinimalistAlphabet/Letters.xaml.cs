using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MinimalistAlphabet
{
    public partial class Letters : ContentPage
    {
        public Letters(string which)
        {
            InitializeComponent();
            
            switch (which)
            {
                case "Upper":
                    Symbol.Text = "A";
                    break;
                case "Lower":
                    Symbol.Text = "a";
                    break;
                case "Numbers":
                    Symbol.Text = "1";
                    break;
            }

        }

        private void OnSwipedLeft(object sender, SwipedEventArgs e)
        {
            if (Helpers.NextValueInRange(Symbol.Text))
            {
                Symbol.Text = Convert.ToChar(Symbol.Text.ToCharArray()[0] + 1).ToString();
            }
        }        

        private void OnSwipedRight(object sender, SwipedEventArgs e)
        {

        }
    }
}
