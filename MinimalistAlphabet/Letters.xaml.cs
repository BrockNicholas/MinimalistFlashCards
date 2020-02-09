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
            Symbol.Text = Symbol.Text;
        }

        private void OnSwipedRight(object sender, SwipedEventArgs e)
        {

        }
    }
}
