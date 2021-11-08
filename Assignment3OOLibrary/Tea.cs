using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OO
{
    class Tea:Beverages
    {
        private string _nameDrink;
        private double _priceDrink;
        private string _radioButtonDrink;
        private string _drinkReadyString;
        private const double _price = 15;
        private const int _tempWater = 100;
        private const string _stir = "stir";

        public Tea()
        {

        }
        public Tea(string nameDrink= "Tea", double priceDrink=_price, string radioButtonDrink= "rbTea")
        {
            _nameDrink = nameDrink;
            _priceDrink = priceDrink;
            _radioButtonDrink = radioButtonDrink;
        }

        public double Price
        {
            get
            { return _price; }
        }
            
        public String Preparation( int tempWater=_tempWater, string stir=_stir)
        {         
            StringBuilder drinkReady = new StringBuilder();
            drinkReady.Append(Ingredients());
            string tempWaterString = tempWater.ToString();
            drinkReady.Append(tempWaterString);
            drinkReady.Append(stir);
            _drinkReadyString = drinkReady.ToString();

            return _drinkReadyString;
        }

        public String Ingredients()
        {
            StringBuilder ingredient = new StringBuilder();
            ingredient.Append("Tea Leaves");
            ingredient.Append("Tea bag");
            string ingredientString = ingredient.ToString();
            return ingredientString;
        }

        public override string ToString()
        {
            return$"{_nameDrink}, preparing {_drinkReadyString}";
        }
    }
}
