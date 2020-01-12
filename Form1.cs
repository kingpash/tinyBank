using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bautista_HW_2_Tiny_Bank
{
    public partial class tinyBankForm : Form
    {
        public tinyBankForm()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            summaryBox.Visible = false;

            checkingStartTextBox.Text = "0.00";
            checkingStartTextBox.SelectAll();

            checkingInTextBox.Text = "0.00";

            checkingOutTextBox.Text = "0.00";

            savingsStartTextBox.Text = "0.00";

            savingsInTextBox.Text = "0.00";

            savingsOutTextBox.Text = "0.00";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            activityTextBox.Clear();

            checkingStartTextBox.Clear();
            checkingInTextBox.Clear();
            checkingOutTextBox.Clear();

            savingsStartTextBox.Clear();
            savingsInTextBox.Clear();
            savingsOutTextBox.Clear();

            summaryBox.Visible = false;
            cEnd.Visible = false;
            sEnd.Visible = false;
        }

        private void balanceButton_Click(object sender, EventArgs e)
        {
            summaryBox.Visible = true;

            double cStartIn;
            double cDepIn;
            double cWIn;


            double sStartIn;
            double sDepIn;
            double sWIn;


            double totalStart;
            double totalEnd;
            double gain;


            cStartIn = double.Parse(checkingStartTextBox.Text);
            cDepIn = double.Parse(checkingInTextBox.Text);
            cWIn = double.Parse(checkingOutTextBox.Text);

            sStartIn = double.Parse(savingsStartTextBox.Text);
            sDepIn = double.Parse(savingsInTextBox.Text);
            sWIn = double.Parse(savingsOutTextBox.Text);


            double cEnding = cStartIn + cDepIn - cWIn;
            double sEnding = sStartIn + sDepIn - sWIn;

            totalStart = cStartIn + sStartIn;
            totalEnd = cStartIn + sStartIn + cDepIn + sDepIn - cWIn - sWIn;
            gain = cDepIn + sDepIn - cWIn - sWIn;

            if (gain > 0)
            {
                gainLabel.Text = "(Gain):";
            }else
            {
                gainLabel.Text = "(Loss):";
            }

            cEnd.Text = "$" + cEnding;
            cEnd.BackColor = Color.White;

            sEnd.Text = "$" + sEnding;
            sEnd.BackColor = Color.White;

            accountTotalLabel.Text = "$" + totalStart;
            accountTotalLabel.BackColor = Color.White;

            accountEndLabel.Text = "$" + totalEnd;
            accountEndLabel.BackColor = Color.White;

            accountGainLabel.Text = "$" + gain;
            accountGainLabel.BackColor = Color.White;

            cEnd.Visible = true;
            sEnd.Visible = true;

        }

    }
}
