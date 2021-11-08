using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3OOLibrary2
{
    public class Tea : Beverages
    {
        private const double _price = 15;
        private const int _tempWater = 100;
        private const string _stir = " degress water stir";    

        public Tea(VendingMachine vendingMachine,string nameDrink="Tea", double priceDrink= _price ) : base(vendingMachine,nameDrink, priceDrink )
        {

        }
        

        public override String Ingredients()
        {
            StringBuilder ingredient = new StringBuilder();
            ingredient.Append("Tea Leaves,");
            ingredient.Append("Tea bag,");
            string ingredientString = ingredient.ToString();
            return ingredientString;
        }

    }
}
