using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MinimalistAlphabet
{
    public partial class Letters : ContentPage
    {
        String initSymbol;

        public Letters(string which)
        {
            InitializeComponent();            

            switch (which)
            {
                case "Upper":
                    initSymbol = "A";
                    this.BackgroundColor = Color.FromHex("#0398fc");
                    break;
                case "Lower":
                    initSymbol = "a";
                    this.BackgroundColor = Color.FromHex("#ff8400");
                    break;
                case "Numbers":
                    initSymbol = "1";
                    this.BackgroundColor = Color.FromHex("#1bcf51");
                    break;
                default:
                    initSymbol = "A";
                    break;
            }

            Symbol.Text = initSymbol;
            BackButton.Clicked += BackButton_Clicked;

        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void OnSwipedLeft(object sender, SwipedEventArgs e)
        {
            if (initSymbol == "A" || initSymbol == "a")
            {
                if (Helpers.NextLetterInRange(Symbol.Text.ToCharArray()[0] + 1))
                {
                    Symbol.Text = Convert.ToChar(Symbol.Text.ToCharArray()[0] + 1).ToString();
                }
            }
            else
            {
                Symbol.Text = (Convert.ToInt32(Symbol.Text) + 1) < 21 ? (Convert.ToInt32(Symbol.Text) + 1).ToString() : Symbol.Text;                               
            }
        }        

        private void OnSwipedRight(object sender, SwipedEventArgs e)
        {
            if (initSymbol == "A" || initSymbol == "a")
            {
                if (Helpers.NextLetterInRange(Symbol.Text.ToCharArray()[0] - 1))
                {
                    Symbol.Text = Convert.ToChar(Symbol.Text.ToCharArray()[0] - 1).ToString();
                }
            }
            else
            {
                int next = Convert.ToInt32(Symbol.Text) - 1;
                if (next > 0)
                    Symbol.Text = next.ToString();
            }
        }
    }
}
