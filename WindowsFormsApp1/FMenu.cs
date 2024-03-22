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
    public partial class FMenu : Form
    {
        SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.cnnString);
        public FMenu()
        {
            InitializeComponent();
            loadMenuList();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtNameMenu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }


        private void loadMenuList()
        {
            string sql = "SELECT* FROM Menu";
            sqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon);
            dap.Fill(dt);
            this.dataGridView1.DataSource = dt;
            sqlCon.Close();
        }
        private void txtSearchMenu_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchMenu.Text == null)
            {
                loadMenuList();
            }
            else
            {
                string sql = "SELECT* FROM Menu";
                sqlCon.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon);
                dap.Fill(dt);
                DataView dv = dt.DefaultView;
                dv.RowFilter = "nameMenu Like '%" + txtSearchMenu.Text+ "%'";
                this.dataGridView1.DataSource = dv.ToTable();
                sqlCon.Close();
            }
        }
    }
}
