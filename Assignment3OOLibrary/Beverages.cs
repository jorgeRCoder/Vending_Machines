using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Assignment3OO
{
    class Beverages
    {
        private string _nameDrink;
        private double _priceDrink;
        private string _radioButtonDrink;
        private string _drinkReadyString;

        public Beverages()
        {

        }

        public Beverages(string nameDrink, double priceDrink, string radioButtonDrink)
        {
            _nameDrink = nameDrink;
            _priceDrink = priceDrink;
            _radioButtonDrink = radioButtonDrink;
        }

        public virtual String Preparation(string ingredients, int tempWater, string stir)
        {
            StringBuilder drinkReady = new StringBuilder();
            drinkReady.Append(ingredients);
            string tempWaterString= tempWater.ToString();
            drinkReady.Append(tempWaterString);
            drinkReady.Append(stir);
            _drinkReadyString= drinkReady.ToString();

            return _drinkReadyString;
        }

        public override string ToString()
        {
            return $"{_nameDrink} prepared {_drinkReadyString}";
        }
    }
}
