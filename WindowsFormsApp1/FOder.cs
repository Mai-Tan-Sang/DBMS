using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FOder : Form
    {
        SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.cnnString);
        public FOder()
        {
            InitializeComponent();
            string sql = "SELECT* FROM Menu";
            sqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon);
            dap.Fill(dt);
            this.dataGridView1.DataSource = dt;

            string sql2 = "SELECT* FROM Orders";
            DataTable dt2 = new DataTable();
            SqlDataAdapter dap2 = new SqlDataAdapter(sql2, sqlCon);
            dap2.Fill(dt2);
            this.dataGridView2.DataSource = dt2;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtNameMenu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
