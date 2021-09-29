using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Reciet
{
    public partial class backgroundForm : Form
    {
        DateTime thisDay = DateTime.Today;
        //Global varibles
        double pStrings = 16.50;
        double pTennisBall = 7.00;
        double pOverGrip = 4.25;
        int strings = 0;
        int tennisBall = 0;
        int overGrip = 0;
        double subTotal;
        double tTax = .13;
        double tax;
        double total;
        double tendered = 0;
        double change;
        int i;
        public backgroundForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {



            calculateChangeButton.Enabled = Enabled;
            strings = Convert.ToInt32(stringsTextBox.Text);
            tennisBall = Convert.ToInt32(tennisBallsTextBox.Text);
            overGrip = Convert.ToInt32(overGripTextBox.Text);

            //calculating subtotal, tax and total
            subTotal = (strings * pStrings) + (overGrip * pOverGrip) + (tennisBall * pTennisBall);
            tax = tTax * subTotal;
            total = tax + subTotal;
            //displays subtotal, tax and total
            realTotalLabel.Text = $"{subTotal.ToString("C")}\n\n{tax.ToString("C")}\n\n{total.ToString("c")}";
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            // the inital starting code which gets everything set up for the program to run
            costTypeLabel.Text = $"SubTotal:\n\nTax:\n\nTotal:";
            calculateChangeButton.Enabled = false;
            stringsTextBox.Text = $"0";
            overGripTextBox.Text = $"0";
            tennisBallsTextBox.Text = $"0";
            tenderedTextBox.Text = "0";
            receiptLabel.Enabled = false;
            centerReceiptTextLabel.Enabled = false;
            rightReceiptTextLabel.Enabled = false;
            leftReceiptTextLabel.Enabled = false;
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            // calculates and displays change 
            tendered = Convert.ToDouble(tenderedTextBox.Text);
            if (tendered < total)
            {
                // incase the customer is short
                changeTypeLabel.Text = $"You are short:";
                changeLabel.Text = $"{(total - tendered).ToString("C")}";
            }
            else
            {
                change = total - tendered*(-1);
                changeLabel.Text = $"{change.ToString("C")}";
            }

        }
        //Upgreads to the text boxs making them much easier to use
        private void stringsTextBox_Enter(object sender, EventArgs e)
        {
            stringsTextBox.Text = "";
        }

        private void stringsTextBox_Leave(object sender, EventArgs e)
        {
            if(stringsTextBox.Text == "")
            {
                stringsTextBox.Text = "0";
            }
        }

        private void overGripTextBox_Enter(object sender, EventArgs e)
        {
            overGripTextBox.Text = ""; 
        }

        private void overGripTextBox_Leave(object sender, EventArgs e)
        {
            if (overGripTextBox.Text == "")
            {
                overGripTextBox.Text = "0";
            }
        }

        private void tennisBallsTextBox_Enter(object sender, EventArgs e)
        {
            tennisBallsTextBox.Text = "";
        }

        private void tennisBallsTextBox_Leave(object sender, EventArgs e)
        {
            if (tennisBallsTextBox.Text == "")
            {
                tennisBallsTextBox.Text = "0";
            }
        }

        private void tenderedTextBox_Enter(object sender, EventArgs e)
        {
            tenderedTextBox.Text = ""; 
        }

        private void tenderedTextBox_Leave(object sender, EventArgs e)
        {
            if (tenderedTextBox.Text == "")
            {
                tenderedTextBox.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            centerReceiptTextLabel.Text = $"\nCustomer Receipt\n ------------------------------------------ \nOrder number: \n{thisDay.ToString("D")}";
            leftReceiptTextLabel.Text = $"Strings:" +
                $"\nOvergrip:" +
                $"\nTennis Balls:" +
                $"\n\nSubtotal:" +
                $"\nTax:" +
                $"\nTotal:" +
                $"\n\nTendered:" +
                $"\nChange:" +
                $"\n\nHave a nice day:";
            rightReceiptTextLabel.Text = $"{strings}x @{pStrings.ToString()}" +
               $"\n{overGrip}x @{pOverGrip.ToString()}" +
               $"\n{tennisBall}x @{pTennisBall.ToString("0.00")}" +
               $"\n\n{subTotal.ToString("C")}" +
               $"\n{tax.ToString("C")}" +
               $"\n{total.ToString("C")}" +
               $"\n\n{tendered.ToString("C")}" +
               $"\n{change.ToString("C")}";
            //makes receipt visable 
            receiptLabel.Enabled = true;
            centerReceiptTextLabel.Enabled = true;
            rightReceiptTextLabel.Enabled = true;
            leftReceiptTextLabel.Enabled = true;
            //prints receipt out 
            for ( i = 0; i < 108; i++)
            {
                receiptLabel.Size = new Size(193, i);
                centerReceiptTextLabel.Size = new Size(186, i);
                rightReceiptTextLabel.Size = new Size(59, i -218);
                leftReceiptTextLabel.Size = new Size(59, i - 218);
                Refresh();
                Thread.Sleep(3);
            }
            for (i = i; i < 277; i++)
            {
                receiptLabel.Size = new Size(193, i);
                rightReceiptTextLabel.Size = new Size(71, i - 93);
                leftReceiptTextLabel.Size = new Size(113, i - 93);
                Refresh();
                Thread.Sleep(3); 
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
             strings = 0;
             tennisBall = 0;
             overGrip = 0;
             tax = 0;
             total = 0;
             tendered = 0;
             change = 0;
            
        }
    }
}

