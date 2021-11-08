using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OO
{
    class Manager

    {
        private string _invStock;
        private string _invVending;

        public Manager()
        {


        }

        public string AddInvStock(int cups, int teaLeaves,int teaBags)
        {
            StringBuilder stock= new StringBuilder();
            Stock addInv = new Stock();
            addInv.AddCups(cups);
            addInv.AddTeaLeaves(teaLeaves);
            addInv.AddTeaBags(teaBags);
            stock.Append(cups);
            stock.Append(teaLeaves);
            stock.Append(teaBags);
            _invStock = stock.ToString();

            return _invStock;
        }

        public void AddInvVending(int cups, Beverages drinkname, int teaLeaves, int teaBags)
        {
            Stock removeInv = new Stock();
            removeInv.RemoveCups(cups);
            removeInv.RemoveTeaLeaves(teaLeaves);
            removeInv.RemoveTeaBags(teaLeaves);

            VendingMachine addInv = new VendingMachine();
            addInv.CupsMachine += cups;
            addInv.addBeverage(drinkname);
        }

        public string SelectedDrink(Beverages drink)
        {
            StringBuilder drinkPrice = new StringBuilder();
            drinkPrice.Append(drink);
            Tea priceDrink=new Tea();
            drinkPrice.Append(priceDrink.Price.ToString());
            string drinkPriceString=drinkPrice.ToString();
            return drinkPriceString;
        }
        
        public string OrderedDrink(Beverages drink)
        {
            VendingMachine removeInv = new VendingMachine();
            removeInv.removeBeverage(drink);
            StringBuilder drinkPrep = new StringBuilder();
            drinkPrep.Append(drink);
            Tea drinkPrep2 = new Tea();
            drinkPrep.Append(drinkPrep2.Preparation());
            string drinkPrepString = drinkPrep.ToString();
            return drinkPrepString;
        }



    }
}
