using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if(FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void CheeseCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseCb.Checked == true)
            {
                CheeseTb.Enabled = true;
            }
            if (CheeseCb.Checked == false)
            {
                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void PancakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakesCb.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            if (PancakesCb.Checked == false)
            {
                PancakesTb.Enabled = false;
                PancakesTb.Text = "0";
            }
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Declare ubit price to different meanl and drinks
        double friesup = 5, burgerup = 8, saladup = 5, sandwichup = 7, cheeseup = 2, chickenup = 7;

        private void button2_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            CheeseCb.Checked = false;
            TeaCb.Checked = false;
            WaterCb.Checked = false;
            OrangeCb.Checked = false;
            PancakesCb.Checked = false;
            ChocolateCb.Checked = false;
            ColaCb.Checked = false;
        }

        double waterup = 1, teaup = 2, colaup = 2, chocolateup = 4, pancakesup = 4, orangeup = 2;
        //Declare variable to hold total price for each drinks and meals
        double friestp, burgertp, saladtp, sandwichtp, cheesetp, watertp, teatp, colatp, chocolatetp, chickentp, pancakestp, orangetp;
        double Subtotal = 0,tax,grdtotal;
        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);
            //drinks
            watertp = waterup * Convert.ToDouble(WaterTb.Text);
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            colatp = colaup * Convert.ToDouble(ColaTb.Text);
            chocolatetp = chocolateup * Convert.ToDouble(ChocolateTb.Text);
            pancakestp = pancakesup * Convert.ToDouble(PancakesTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);

            //recipt
            ReceiptTb.Clear();
            Subtotal = 0;
            //tax = 0;
            //grdtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tCODESPACE RESTAURANT\t\t" + Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t*************************************"+Environment.NewLine);
            if(FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tFries:\t" + friestp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + burgertp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad:\t" + saladtp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + saladtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SandwichCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich:\t" + sandwichtp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + sandwichtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken:\t" + chickentp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + chickentp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\tWater:\t" + watertp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + watertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:\t" + teatp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + teatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCola:\t" + colatp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + colatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChocolate:\t" + chocolatetp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + chocolatetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if(PancakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPancakes:\t" + pancakestp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + pancakestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (OrangeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tOrange:\t" + orangetp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + orangetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (CheeseCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCheese:\t" + cheesetp + " Cad" + Environment.NewLine);
                Subtotal = Subtotal + cheesetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            tax = Subtotal * 0.12;
            grdtotal = Subtotal + tax;
            taxlbl.Text = "Cad " + tax;
            Grdtotallbl.Text = "Cad " + grdtotal;
        }
    }
}
