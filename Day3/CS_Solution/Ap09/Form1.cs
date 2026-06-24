using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!\nHello world!\nHello world!", "Greeting",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Yes on No", "Ask", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (ans == DialogResult.Yes)
                txtAns.Text = "Yep!";
            else if (ans == DialogResult.No)
                txtAns.Text = "Nooooooooooooooo!!";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("你確定嗎","離開",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ans == DialogResult.Yes)
                Close();
        }
    }
}
