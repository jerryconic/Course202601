using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        string connstr = @"Server=.; 
                           Database=db01; 
                           Trusted_Connection=true;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connstr);
            cn.Open();
            cn.Close();
            MessageBox.Show("Connect OK", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connstr);
            SqlCommand cmd = cn.CreateCommand(); 
            cmd.CommandText = @"INSERT INTO dbo.Product(prdt_id, prdt_name, price) 
                                VALUES(@id, @name, @price);"; 
            cmd.Parameters.AddWithValue("@id", txtID.Text); 
            cmd.Parameters.AddWithValue("@name", txtName.Text); 
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Insert OK", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
