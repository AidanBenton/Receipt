using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reciet
{
    public partial class Form1 : Form
    {
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
        int I;
        int II;
        int III;
        public Form1()
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
            costTypeLabel.Text = $"SubTotal:\n\nTax:\n\nTotal:";
            calculateChangeButton.Enabled = false;
            stringsTextBox.Text = $"0";
            overGripTextBox.Text = $"0";
            tennisBallsTextBox.Text = $"0";
            tenderedTextBox.Text = "0";
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(tenderedTextBox.Text);
            if (tendered < total)
            {
                changeTypeLabel.Text = $"You are short:";
                changeLabel.Text = $"{(total - tendered).ToString("C")}";
            }
            else
            {
                change = total - tendered;
                changeLabel.Text = $"{change.ToString("C")}";
            }

        }
        //Upgreads to the text boxs making them much easyer to use
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
    }
}

