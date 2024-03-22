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

namespace WindowsFormsApp1
{
    public partial class FEmployee : Form
    {

        SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.cnnString);
        public FEmployee()
        {
            InitializeComponent();
            loadMenuList();
        }
        private void loadMenuList()
        {
            string sql = "SELECT* FROM Employee";
            sqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon);
            dap.Fill(dt);
            this.dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtNameEmployee.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDateofBirth.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtGender.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            texPhoneNumber.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textIdEmployee.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text == null)
            {
                loadMenuList();
            }
            else
            {
                string sql = "SELECT* FROM Employee";
                sqlCon.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon);
                dap.Fill(dt);
                DataView dv = dt.DefaultView;
                dv.RowFilter = "Ename Like '%" + txtSearchEmployee.Text + "%'";
                this.dataGridView1.DataSource = dv.ToTable();
                sqlCon.Close();
            }
        }
    }
}
