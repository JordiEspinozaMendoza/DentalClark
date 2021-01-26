
using Dental_Clark_V1.DentalClarkClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clark_V1
{
    public partial class patient : Form
    {
        public string name;
        public string lastName;
        public int age;
        public string gender;
        public long phone;
        public int patientID;
        public string email;

        patientClass patientInfo = new patientClass();
        consultClass consults = new consultClass();

        public patient()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the data from txtboxes
            patientInfo.Name = txtName.Text;
            patientInfo.LastName = txtLastName.Text;
            patientInfo.Age = int.Parse(txtAge.Text);
            patientInfo.Email = txtEmail.Text;
            patientInfo.Gender = txtSex.Text;

            //Update Data in data base
            bool success = patientInfo.Update(patientInfo);
            if (success)
            {
                //Update successfully
                MessageBox.Show("Paciente actualizad@ correctamente");
            }
            else
            {
                //Update failed
                MessageBox.Show("No se ha podido actualizar");
            }

        }

        private void patient_Load(object sender, EventArgs e)
        {
            dgvConsults.AllowUserToAddRows = false;

            patientInfo.Name = name;
            patientInfo.LastName = lastName;
            patientInfo.Age = age;
            patientInfo.Phone = phone;
            patientInfo.Gender = gender;
            patientInfo.patientID = patientID;
            patientInfo.Email = email;

            txtName.Text = name;
            txtLastName.Text = lastName;
            txtEmail.Text = email;
            txtAge.Text = age.ToString();
            txtSex.Text = gender;
            txtPhone.Text = phone.ToString();

            DataTable dt = consults.SelectConsults(patientID);
            dgvConsults.DataSource = dt;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            patients patients = new patients();
            patients.ShowDialog();
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        static string table = "consult_table";
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from txt box
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT * FROM {table} WHERE Name LIKE '%{keyword}%' OR consultDetail LIKE '%{keyword}%'", conn);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);

            dgvConsults.DataSource = dt;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("¿Seguro que deseas cerrar sesión?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                login login = new login();
                login.ShowDialog();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            history history = new history();
            history.ShowDialog();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patients patients = new patients();
            patients.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            home home = new home();
            this.Hide();

            home.ShowDialog();
        }

        private void exit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
