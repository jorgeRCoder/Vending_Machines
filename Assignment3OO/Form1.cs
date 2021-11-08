using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment3OOLibrary2;

namespace Assignment3OO
{
    public partial class FormVendingMachine : Form
    {
        VendingMachine vm = new VendingMachine();

        public FormVendingMachine()
        {
            InitializeComponent();

            vm.CupsMachine(3);
        }

        private void rbTea_Click(object sender, EventArgs e)
        {
            Manager man = new Manager(vm);

            Tea tea = new Tea(vm);
            tea.Preparation(1);

            btnBuy.Enabled = true;
            lblDrinkSelected.Text = man.SelectedDrink(tea);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            Manager man = new Manager(vm);
            Coffee coffee = new Coffee(vm);
            coffee.Preparation(120);

            HotChocolate hotChocolate = new HotChocolate(vm);
            hotChocolate.Preparation(90);

            Tea tea = new Tea(vm);
            tea.Preparation(100);

            if (rbCoffee.Checked == true)
            {
                lblAskedPrep.Text = man.OrderedDrink(coffee);
            }

            else if (rbHotChocolate.Checked == true)
            {
                lblAskedPrep.Text = man.OrderedDrink(hotChocolate);
            }

            else if (rbTea.Checked == true)
            {
                lblAskedPrep.Text = man.OrderedDrink(tea);
            }
            else
            {
                lblAskedPrep.Text = "check";
            }
        }

        private void rbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            Manager man = new Manager(vm);
            Coffee coffee = new Coffee(vm);
            coffee.Preparation(120);

            btnBuy.Enabled = true;
            lblDrinkSelected.Text = man.SelectedDrink(coffee);
        }

        private void rbHotChocolate_CheckedChanged(object sender, EventArgs e)
        {
            Manager man = new Manager(vm);
            HotChocolate hotChocolate = new HotChocolate(vm);
            hotChocolate.Preparation(90);

            btnBuy.Enabled = true;
            lblDrinkSelected.Text = man.SelectedDrink(hotChocolate);
        }
    }
}
