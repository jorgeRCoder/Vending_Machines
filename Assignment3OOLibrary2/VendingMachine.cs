using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3OOLibrary2
{
    public class VendingMachine
    {
        private int _cupsMachine;
        private List<Beverages> _drinks = new List<Beverages>();
        private string _invBeverages;

        public VendingMachine()
        { }

        public int CupsMachine(int cups)
        {
            _cupsMachine += cups;
            return _cupsMachine;
            
        }

        public int Cups
            { get { return _cupsMachine; } }



        public string addBeverage(Beverages newDrink,int amount)
        {
            StringBuilder added = new StringBuilder();
            added.Append(newDrink.ToString());
            added.Append(amount.ToString());
            _invBeverages = added.ToString();
            return _invBeverages;
        }

        public List<Beverages> removeBeverage(Beverages removeDrink)
        {
            _drinks.Remove(removeDrink);
            return _drinks;
        }

        public override string ToString()
        {
            StringBuilder drinks = new StringBuilder(); ;
            for (int i = 0; i < _drinks.Count; i++)
            {
                drinks.Append(_drinks[i]);
            }
            string drinksString = drinks.ToString();
            return $"drinks: {drinksString}, cups {_cupsMachine}, drink {_invBeverages}";
        }
    }
}
