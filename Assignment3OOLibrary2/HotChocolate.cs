using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3OOLibrary2
{
    public class HotChocolate : Beverages
    {
        private const double _price = 20;
        private const int _tempWater = 90;
        private const string _stir = " degress water stir";

        public HotChocolate(VendingMachine vendingMachine, string nameDrink = "HotChocolate", double priceDrink = _price) : base(vendingMachine, nameDrink, priceDrink)
        {

        }


        public override String Ingredients()
        {
            StringBuilder ingredient = new StringBuilder();
            ingredient.Append("Cocoa,");
            string ingredientString = ingredient.ToString();
            return ingredientString;
        }

    }
}
