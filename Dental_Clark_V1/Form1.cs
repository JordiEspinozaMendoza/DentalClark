using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clark_V1
{

    public partial class login : Form
    {
        layout home = new layout();


        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.txtPassword.Text = "";
            this.txtUsername.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loading loading = new Loading();
            this.Hide();
            loading.ShowDialog();
            home.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
