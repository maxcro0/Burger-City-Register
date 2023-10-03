using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MoneeRegister
{
    public partial class Form1 : Form 
    {

        double Tax = 0.13;
        double taxAmount = 0;
        double Total = 0;
        double Subtotal = 0;
        double totalTender = 0;
        double burgerPrice = 3.49;
        int burgerAmount = 0;
        double friesPrice = 2.90;
        int friesAmount = 0;
        double drinkPrice = 2.50;
        int drinkAmount = 0;
        double Change = 0;
        bool TotalCalc = false;
        bool ChangeCalc = false;
        SoundPlayer receiptPrint = new SoundPlayer(Properties.Resources.Receipt_printing);


        public Form1()
        {
            InitializeComponent();




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeLabel_Click(object sender, EventArgs e)
        {

        }

        private void tenderedInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //inputs
            try
            { 
            burgerAmount = int.Parse(burgerInput.Text); 
            friesAmount = int.Parse(friesInput.Text);
            drinkAmount = int.Parse(drinkInput.Text);
            }
            catch
            {
            subtotalOut.Text = "Error";
            }

            Subtotal = (burgerPrice * burgerAmount) + (friesPrice * friesAmount) + (drinkPrice * drinkAmount);
            taxAmount = Subtotal * Tax;
            Total = Subtotal + taxAmount;

            subtotalOut.Text = Subtotal.ToString("C");
            taxOut.Text = taxAmount.ToString("C");
            totalOut.Text = Total.ToString("C");
            TotalCalc = true; 

        }

        private void changeCalculatebutton_Click(object sender, EventArgs e)
        {
            totalTender = int.Parse(tenderedInput.Text);
            if (Total > totalTender)
            {

                changeOut.Text = "Error";
                receiptBox.Text = "Insignificant Funds.\nPlease Try Again";
            }
            else
            {
                Change = totalTender - Total;
                changeOut.Text = Change.ToString("C");
                ChangeCalc = true;
            }

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int orderNum = rnd.Next(0, 2000);
            if (TotalCalc == true && ChangeCalc == true)
            {
                receiptPrint.Play(); 
                receiptBox.Text = $"     Burger City\n\nOrder Number {orderNum}\n\n\nBurgers  x{burgerAmount} @ {burgerPrice.ToString("C")}\nFries    x{friesAmount} @ {friesPrice.ToString("C")}\nDrink    x{drinkAmount} @ {drinkPrice.ToString("C")}\n\n\nSubtotal      {Subtotal.ToString("C")}\nTax           {taxAmount.ToString("C")}\nTotal         {Total.ToString("C")}\n\nTendered      {totalTender.ToString("C")}\nChange        {Change.ToString("C")}\n\nThank You!\nCome Again!";
            }
            else
            { receiptBox.Text = "Finish Previous Steps Before Getting Receipt";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) 
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Tax = 0.13;
             taxAmount = 0;
             Total = 0;
             Subtotal = 0;
             totalTender = 0;
             burgerPrice = 3.49;
             burgerAmount = 0;
             friesPrice = 2.90;
             friesAmount = 0;
             drinkPrice = 2.50;
             drinkAmount = 0;
             Change = 0;
             TotalCalc = false;
             ChangeCalc = false;
             burgerInput.Text = "";
            friesInput.Text = "";
            drinkInput.Text = "";
            tenderedInput.Text = "";
            subtotalOut.Text = "";
            totalOut.Text = "";
            taxOut.Text = "";
            changeOut.Text = "";
            receiptBox.Text = ""; 
            

        }
    }
}
