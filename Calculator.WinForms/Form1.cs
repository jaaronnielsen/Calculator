using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcLib;

namespace Calculator.WinForms
{
    public partial class Form1 : Form
    {
        List<SimpleCalculator> calcList;
        public Form1()
        {
            InitializeComponent();
            calcList = new List<SimpleCalculator>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tabPage2)
            {
                dataGridView1.Rows.Clear();
                foreach (var c in calcList)
                {
                    dataGridView1.Rows.Add(c.firstNumber, c.secondNumber, c.result);
                }
            }
        }

        private void btnClickAdd_Click(object sender, EventArgs e)
        {
            var calc = new SimpleCalculator();
            if (double.TryParse(txtNum1.Text, out double firstNum) && double.TryParse(txtNum2.Text, out double secondNum))
            {
                calc.firstNumber = firstNum;
                calc.secondNumber = secondNum;
            }

            calc.result = calc.AddNumbers();
            txtResult.Text = calc.result.ToString("n");
            calcList.Add(calc);
        }

        private void btnCalculateSub_Click_Click(object sender, EventArgs e)
        {
            var calc = new SimpleCalculator();
            if (double.TryParse(txtNum1.Text, out double firstNum) && double.TryParse(txtNum2.Text, out double secondNum))
            {
                calc.firstNumber = firstNum;
                calc.secondNumber = secondNum;
            }

            calc.result = calc.SubtractNumbers();
            txtResult.Text = calc.result.ToString("n");
            calcList.Add(calc);
        }

        private void btnCalculateMult_Click_Click(object sender, EventArgs e)
        {
            var calc = new SimpleCalculator();
            if (double.TryParse(txtNum1.Text, out double firstNum) && double.TryParse(txtNum2.Text, out double secondNum))
            {
                calc.firstNumber = firstNum;
                calc.secondNumber = secondNum;
            }

            calc.result = calc.MulitplyNumbers();
            txtResult.Text = calc.result.ToString("n");
            calcList.Add(calc);
        }

        private void btnCalculateDiv_Click_Click(object sender, EventArgs e)
        {
            var calc = new SimpleCalculator();
            if (double.TryParse(txtNum1.Text, out double firstNum) && double.TryParse(txtNum2.Text, out double secondNum))
            {
                calc.firstNumber = firstNum;
                calc.secondNumber = secondNum;
            }

           calc.result = calc.DivideNumbers();
           txtResult.Text = calc.result.ToString("n");
            calcList.Add(calc);
        }

        private void btnCalculatePow_Click_Click(object sender, EventArgs e)
        {
            var calc = new SimpleCalculator();
            if (double.TryParse(txtNum1.Text, out double firstNum) && double.TryParse(txtNum2.Text, out double pow))
            {
                calc.firstNumber = firstNum;
                calc.secondNumber = pow;
            }

            calc.result = calc.RaiseToPower();

            txtResult.Text = calc.result.ToString("n");
            calcList.Add(calc);
        }
    }
}
