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
    public partial class layout : Form
    {
        Form currentChildForm;

        public layout()
        {
            InitializeComponent();
        }
        
        public void changeChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            currentForm.Controls.Add(childForm);
            currentForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void layout_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            changeChildForm(new history());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            changeChildForm(new patients());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            changeChildForm(new home());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void currentForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
