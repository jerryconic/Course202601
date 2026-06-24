using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double a, b;
            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            txtAns.Text = (a * b).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a, b;
            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            txtAns.Text = (a + b).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double a, b;
            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            txtAns.Text = (a - b).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a, b;
            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            txtAns.Text = (a / b).ToString();
        }
    }
}
