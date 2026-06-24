using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap11
{
    public partial class Form1 : Form
    {
        int ans, guess;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int.TryParse(txtGuess.Text, out guess);
            if (guess < ans)
                MessageBox.Show("高一點");
            else if (guess > ans)
                MessageBox.Show("低一點");
            else
            {
                MessageBox.Show("猜對了");
                txtGuess.Clear();
                grpGuess.Enabled = false;
                btnStart.Enabled = true;
                btnGuess.Enabled = false;                
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpGuess.Enabled = false;
            btnStart.Enabled = true;
            btnGuess.Enabled = false;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ans = rnd.Next(1, 100);
            Text = ans.ToString();
            grpGuess.Enabled = true;
            btnStart.Enabled = false;
            btnGuess.Enabled = true;
            txtGuess.Select();
        }
    }
}
