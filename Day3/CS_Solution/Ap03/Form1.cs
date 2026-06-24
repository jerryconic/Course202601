using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int score;
            int.TryParse(txtScore.Text, out score);
            if(score < 60)
            {
                txtResult.Text = "不及格";
                txtResult.ForeColor = Color.LightYellow;
                txtResult.BackColor = Color.Red;
            }
            else
            {
                txtResult.Text = "不及格";
                txtResult.ForeColor = Color.White;
                txtResult.BackColor = Color.Blue;
            }

        }
    }
}
