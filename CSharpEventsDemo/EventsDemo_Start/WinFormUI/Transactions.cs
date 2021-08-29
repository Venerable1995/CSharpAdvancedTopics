using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Transactions : Form
    {
        private Customer _customer;
      

        public Transactions(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            
            customerText.Text = _customer.CustomerName;
            customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }
               

        private void CheckingAccount_OverdraftEvent(object sender, OverdraftEventArgs e)
        {
            errorMessage.Visible = true;
        }

        private void makePurchaseButton_Click(object sender, EventArgs e)
        {
            bool paymentResult = _customer.CheckingAccount.MakePayment("Credit Card Purchase", amountValue.Value, _customer.SavingsAccount);
            amountValue.Value = 0;
            
        }

        private void errorMessage_Click(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }

        private void denyOverdraft_CheckedChanged(object sender, EventArgs e)
        {
            denyOverdraft.Checked = true;
        }
    }
}
