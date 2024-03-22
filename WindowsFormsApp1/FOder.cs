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
        int price = 0;
        public FOder()
        {
            InitializeComponent();
            string sql = "SELECT* FROM Menu";
            sqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon);
            dap.Fill(dt);
            this.dataGridView1.DataSource = dt;

            // Thêm các cột vào DataGridView
            dataGridView2.Columns.Add("NameMenuColumn", "NameMenu");
            dataGridView2.Columns.Add("NumberColumn", "Number");
            dataGridView2.Columns.Add("PriceColumn", "Price");

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtNameMenu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNameMenu.Text != "" && txtNumber.Text != "")
            {
                // Thêm dữ liệu từ TextBox vào DataGridView
                dataGridView2.Rows.Add(txtNameMenu.Text, txtNumber.Text, int.Parse(lblPrice.Text)* int.Parse(txtNumber.Text));

                // Clear các TextBox sau khi thêm dữ liệu
                txtNameMenu.Text = "";
                txtNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter both NameMenu and Number.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FPay fret = new FPay();
            fret.ShowDialog();
            fret = null;
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
