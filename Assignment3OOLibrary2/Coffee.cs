using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3OOLibrary2
{
    public class Coffee : Beverages
    {
        private const double _price = 10;
        private const int _tempWater = 120;
        private const string _stir = " degress water stir";

        public Coffee(VendingMachine vendingMachine, string nameDrink = "Coffee", double priceDrink = _price) : base(vendingMachine, nameDrink, priceDrink)
        {

        }


        public override String Ingredients()
        {
            StringBuilder ingredient = new StringBuilder();
            ingredient.Append("Coffee Beans,");
            ingredient.Append("Sugar,");
            string ingredientString = ingredient.ToString();
            return ingredientString;
        }

    }
}
