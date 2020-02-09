using System;
using Xamarin.Forms;

namespace MinimalistAlphabet
{
    public static class Helpers
    {

        internal static bool NextValueInRange(string str)
        {
            int val = str.ToCharArray()[0] + 1;

            if (val >= 65 && val <= 90)
            {
                return true;
            }

            if (val >= 97 && val <= 122)
            {
                return true;
            }

            if (val >= 65 && val <= 90)
            {
                return true;
            }

            return false;
        }
    }
}
