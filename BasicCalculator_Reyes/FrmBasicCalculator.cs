using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly_Reyes;

namespace BasicCalculator_Reyes
{
    public partial class FrmBasicCalculator : Form
    {
        
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }
        

        
        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1 = (float)Convert.ToDouble(txtBox1.Text);
            float num2 = (float)Convert.ToDouble(txtBox2.Text);

            if (cbOperator.Text == "+")
            {
                float Total = BasicComputation.Addition(num1, num2);
                string totals = Total.ToString();
                lblTotal.Text = totals;
            }
            else if (cbOperator.Text == "-")
            {
                float Total = BasicComputation.Subtraction(num1, num2);
                string totals = Total.ToString();
                lblTotal.Text = totals;

            }
            else if (cbOperator.Text == "*")
            {
                float Total = BasicComputation.Multiplication(num1, num2);
                string totals = Total.ToString();
                lblTotal.Text = totals;
            }
            else if (cbOperator.Text == "/")
            {
                float Total = BasicComputation.Division(num1, num2);
                string totals = Total.ToString();
                lblTotal.Text = totals;
            }
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
        }
    }
}
