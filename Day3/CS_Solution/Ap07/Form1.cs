using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            pct1.Image = Image.FromFile("Animals/dog.jpg");
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            pct1.Image = Image.FromFile("Animals/cat.jpg");
        }

        private void btnLion_Click(object sender, EventArgs e)
        {
            pct1.Image = Image.FromFile("Animals/lion.jpg");
        }
    }
}
