using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3OOLibrary2;


namespace Assignment3OOConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            VendingMachine vm = new VendingMachine();
            Manager man = new Manager(vm);
            Tea tea = new Tea(vm);

            //vm.CupsMachine(1);
            vm.CupsMachine(1);
            Console.WriteLine($"cups: {vm.Cups}");
            tea.Preparation(100);

            Console.WriteLine($"ordered {man.OrderedDrink(tea)}");
            Console.WriteLine($"cups: {vm.Cups}");
            Console.WriteLine($"{man.SelectedDrink(tea)}");
            Console.WriteLine($"cups: {vm.Cups}");
            Console.WriteLine($"ordered {man.OrderedDrink(tea)}");
            man.AddInvVending(1, tea, 2);
            Console.WriteLine($"ordered {man.OrderedDrink(tea)}");
            //Console.WriteLine($"{tea.ToString()}");
            //man.SelectedDrink(tea);

            //vm.CupsMachine(1);
            //Console.WriteLine($"{tea}");
            //vm.CupsMachine(1);
            //Console.WriteLine($"{vm}");
            //vm.addBeverage(tea, 90);
            //Console.WriteLine($"{vm}"); 
            //Console.WriteLine($"{vm.Cups}");
            //Console.WriteLine($"{vm.addBeverage(tea)}");
            //Console.WriteLine($"{man.SelectedDrink(tea)}");



            Console.ReadLine();
        }
    }
}
