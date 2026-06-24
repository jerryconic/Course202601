using System;
using System.Windows.Forms;

namespace Ap13
{
    public partial class Form1 : Form
    {
        double number1 = 0;
        string op = "";
        bool isNewNumber = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 如果剛按過 + - * /，下一次輸入要清空畫面
            if (isNewNumber)
            {
                txtDisplay.Clear();
                isNewNumber = false;
            }

            // 避免小數點重複輸入
            if (btn.Text == "." && txtDisplay.Text.Contains("."))
            {
                return;
            }

            txtDisplay.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            number1 = 0;
            op = "";
            isNewNumber = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveNumberAndOperator("+");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            SaveNumberAndOperator("-");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            SaveNumberAndOperator("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            SaveNumberAndOperator("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "" || op == "")
            {
                return;
            }

            double number2 = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (op)
            {
                case "+":
                    result = number1 + number2;
                    break;

                case "-":
                    result = number1 - number2;
                    break;

                case "*":
                    result = number1 * number2;
                    break;

                case "/":
                    if (number2 == 0)
                    {
                        MessageBox.Show("除數不可為 0");
                        txtDisplay.Clear();
                        return;
                    }

                    result = number1 / number2;
                    break;
            }

            txtDisplay.Text = result.ToString();

            // 清除運算子，避免重複按 = 出問題
            op = "";
            isNewNumber = true;
        }

        private void SaveNumberAndOperator(string operatorText)
        {
            if (txtDisplay.Text == "")
            {
                return;
            }

            number1 = double.Parse(txtDisplay.Text);
            op = operatorText;
            isNewNumber = true;
        }
    }
}