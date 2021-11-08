using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3OOLibrary2
{
    public class Beverages
    {
        private string _nameDrink;
        private double _priceDrink;
        protected string _drinkReadyString;
        private VendingMachine _vendingMachine;


        public Beverages(VendingMachine vendingMachine, string nameDrink, double priceDrink )
        {
            _nameDrink = nameDrink;
            _priceDrink = priceDrink;
            _vendingMachine = vendingMachine;
        }

        public string NameDrink
        {
            get
            { return _nameDrink; }
        }

        public double Price
        {
            get
            { return _priceDrink; }
        }

        public virtual String Preparation(int tempWater, string stir = "stir")
        {
            StringBuilder drinkReady = new StringBuilder();

                drinkReady.Append($"{_nameDrink}-");
                drinkReady.Append($"add: { Ingredients()}");
                string tempWaterString = tempWater.ToString();
                drinkReady.Append($"water at {tempWaterString} degrees, ");
                drinkReady.Append(stir);
                _drinkReadyString = drinkReady.ToString();

                return _drinkReadyString;                       
        }

        public virtual String Ingredients()
        {
            StringBuilder ingredient = new StringBuilder();
            string ingredientString = ingredient.ToString();
            return ingredientString;
        }

        public override string ToString()
        {
            return $"{_drinkReadyString}";
        }
    }
}
