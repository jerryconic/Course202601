using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap01
{
    public partial class Form1 : Form
    {
        int dy = 5, dx = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pct1.Top += dy;
            pct1.Left += dx;
            if (pct1.Top + pct1.Height + 36 >= this.Height) dy = -5;
            if (pct1.Top <= 0) dy = 5;
            if (pct1.Left + pct1.Width + 16 >= this.Width) dx = -5;

            if (pct1.Left <= 0) dx = 5;
        }
    }
}
