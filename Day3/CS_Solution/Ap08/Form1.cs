using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            string[] files = {"dices/d1.png", "dices/d2.png", "dices/d3.png",
                              "dices/d4.png", "dices/d5.png", "dices/d6.png"};
            int n;
            Random rnd = new Random();
            n = rnd.Next(0, 6);
            pct1.Image = Image.FromFile(files[n]);
            n = rnd.Next(0, 6);
            pct2.Image = Image.FromFile(files[n]);
            n = rnd.Next(0, 6);
            pct3.Image = Image.FromFile(files[n]);
            n = rnd.Next(0, 6);
            pct4.Image = Image.FromFile(files[n]);


        }
    }
}
