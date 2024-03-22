using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInfoEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FEmployee fret = new FEmployee();
            fret.ShowDialog();
            fret = null;
            this.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOder fret = new FOder();
            fret.ShowDialog();
            fret = null;
            this.Show();
        }

        private void btnInfoMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMenu fret = new FMenu();
            fret.ShowDialog();
            fret = null;
            this.Show();
        }


    }
}
