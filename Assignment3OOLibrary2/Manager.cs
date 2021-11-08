using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3OOLibrary2
{
    public class Manager

    {
        private string _drinkPriceString;
        private VendingMachine _vendingMachine;

        public Manager(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public void AddInvVending(int cups, Beverages drinkname,int stock)
        {
            _vendingMachine.CupsMachine(cups);
            _vendingMachine.addBeverage(drinkname,stock);
        }

        public string SelectedDrink(Beverages drink)
        {
            StringBuilder drinkPrice = new StringBuilder();
            drinkPrice.Append(drink.NameDrink);
            drinkPrice.Append(", Price: ");
            drinkPrice.Append(drink.Price.ToString());

            _drinkPriceString = drinkPrice.ToString();
            return _drinkPriceString;
        }

        public string OrderedDrink(Beverages drink)
        {

            _vendingMachine.removeBeverage(drink);
            StringBuilder drinkPrep = new StringBuilder();

            if (_vendingMachine.Cups == 0 || _vendingMachine.Cups < 0)
            {
                drinkPrep.Append(":there are no cups in machine");
                _drinkPriceString = drinkPrep.ToString();
                return _drinkPriceString;
            }

            else if (_vendingMachine.Cups > 0)
            {
                _vendingMachine.CupsMachine(-1);
                drinkPrep.Append(drink);
                _drinkPriceString = drinkPrep.ToString();
                return _drinkPriceString;
            }
            return _drinkPriceString;
        }

        public override string ToString()
        {
            return $"{_drinkPriceString}" + "";
        }


    }
}
