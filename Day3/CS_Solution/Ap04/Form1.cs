using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            int nt; 
            decimal amount; 
            int.TryParse(txtNT.Text, out nt); 
            switch (cmbCurr.Text)
            {
                case "美金": 
                    amount = nt / 31.05M; 
                    break;
                case "日圓": 
                    amount = nt / 0.1901M; 
                    break;
                case "歐元": 
                    amount = nt / 34.55M;
                    break;
                default: 
                    amount = 0; 
                    break;
            }
            txtAmount.Text = amount.ToString("#,##0.00");
        }
    }
}
