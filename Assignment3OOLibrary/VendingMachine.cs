using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment3OO
{
    class VendingMachine
    {
       private int _cupsMachine;
       private List<Beverages> _drinks= new List<Beverages>();
        private double _price;

        public VendingMachine()
        {

        }

        public int CupsMachine
        {
            get
            { return _cupsMachine; }
            set
            { _cupsMachine = value; }
        }

        public List<Beverages> addBeverage(Beverages newDrink)
        {
            _drinks.Add(newDrink);
            return _drinks;
        }

        public List<Beverages> removeBeverage(Beverages removeDrink)
        {
            _drinks.Remove(removeDrink);
            return _drinks;
        }
    }
}
