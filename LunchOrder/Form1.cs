using System;
using System.Windows.Forms;

namespace LunchOrderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearTotals()
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtOrderTotal.Clear();
        }

        private void ClearAddOns()
        {
            chkLettuceTomatoOnions.Checked = false;
            chkKetchupMustardMayo.Checked = false;
            chkFrenchFries.Checked = false;
        }

        private void MainCourse_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();

            if (rdoHamburger.Checked)
            {
                chkLettuceTomatoOnions.Text = "Lettuce, tomato, and onions";
                chkKetchupMustardMayo.Text = "Ketchup, mustard, and mayo";
                chkFrenchFries.Text = "French fries";
            }
            else if (rdoPizza.Checked)
            {
                chkLettuceTomatoOnions.Text = "Pepperoni";
                chkKetchupMustardMayo.Text = "Sausage";
                chkFrenchFries.Text = "Olives";
            }
            else if (rdoSalad.Checked)
            {
                chkLettuceTomatoOnions.Text = "Croutons";
                chkKetchupMustardMayo.Text = "Bacon bits";
                chkFrenchFries.Text = "Bread sticks";
            }
        }

        private void AddOn_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            const decimal TAX_RATE = 0.0775m;

            if (rdoHamburger.Checked)
                subtotal = 6.95m;
            else if (rdoPizza.Checked)
                subtotal = 5.95m;
            else if (rdoSalad.Checked)
                subtotal = 4.95m;

            if (chkLettuceTomatoOnions.Checked)
                subtotal += 0.75m;
            if (chkKetchupMustardMayo.Checked)
                subtotal += 0.75m;
            if (chkFrenchFries.Checked)
                subtotal += 0.75m;

            decimal tax = subtotal * TAX_RATE;
            decimal orderTotal = subtotal + tax;

            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtOrderTotal.Text = orderTotal.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
