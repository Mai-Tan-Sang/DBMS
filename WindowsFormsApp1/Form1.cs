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
    public partial class Flogin : Form
    {
        SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.cnnString);
        public Flogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            string sql = "SELECT * from Account where idAccount='" + txtUserName.Text + "' and Apassword='" + txtPassWord.Text + "'";
            DataTable dtlg = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlCon);
            adapter.Fill(dtlg);
            sqlCon.Close();
            if (dtlg.Rows.Count == 1)
            {
                this.Hide();
                Form2 fret = new Form2();
                fret.ShowDialog();
                fret = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong password or username!");
            }

        }
    }

}
