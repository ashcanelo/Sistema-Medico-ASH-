using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedicoAshly
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CitasC.Rows.Add(nametxt.Text, lnametxt.Text, Sicktxt.Text, Habtxt.Text);
            nametxt.Text = "";
            lnametxt.Text = "";
            Sicktxt.Text = "";
            Habtxt.Text = "";

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            if (CitasC == null)
                return;
            CitasC.Rows.Remove(CitasC.CurrentRow);
        }

        private void closebtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
