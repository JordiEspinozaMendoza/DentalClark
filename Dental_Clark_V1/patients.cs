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
    public partial class patients : Form
    {
        static string name;
        static string lastname;
        static int age;
        static string gender;
        static long phone;
        static string email;
        static int id;
        patientClass p = new patientClass();
        public patients()
        {
            InitializeComponent();
        }

        private void dgvConsults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            home home = new home();
            home.ShowDialog();
        }

        private void patients_Load(object sender, EventArgs e)
        {
            dgvPatients.AllowUserToAddRows = false;
            //Load data on datagridview
            DataTable dt = p.Select();
            dgvPatients.DataSource = dt;
        }
        //Method to clear fields
        public void Clear()
        {
            txtAge.Text = "";
            txtEmail.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtSex.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtLastName.Text != "" && txtPhone.Text != "" && txtSex.Text != "" && txtAge.Text != "")
            {
                p.Name = txtName.Text;
                p.LastName = txtLastName.Text;
                p.Email = txtEmail.Text;
                p.Phone = long.Parse(txtPhone.Text);
                p.Gender = txtSex.Text;
                p.Age = int.Parse(txtAge.Text);
                //Inserting data into data base using the method we created 
                bool success = p.Insert(p);
                if (success)
                {
                    //Successfully inserted
                    MessageBox.Show("Nuev@ paciente insertada");
                    Clear();
                }
                else
                {
                    //Successfully inserted
                    MessageBox.Show("Error al agregar paciente");
                }
            }
            else
            {
                MessageBox.Show("Ingresa los datos del formulario correctamente");

            }
            //Load data on datagridview
            DataTable dt = p.Select();
            dgvPatients.DataSource = dt;
        }

        private void dgvPatients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            id = int.Parse(dgvPatients.Rows[rowIndex].Cells[0].Value.ToString());
            name = dgvPatients.Rows[rowIndex].Cells[1].Value.ToString();
            lastname = dgvPatients.Rows[rowIndex].Cells[2].Value.ToString();
            email = dgvPatients.Rows[rowIndex].Cells[3].Value.ToString();
            phone = long.Parse(dgvPatients.Rows[rowIndex].Cells[4].Value.ToString());
            gender = dgvPatients.Rows[rowIndex].Cells[5].Value.ToString();
            age = int.Parse(dgvPatients.Rows[rowIndex].Cells[0].Value.ToString());

            update.Enabled = true;
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            //patient patientInfo = new patient(name, lastname, age, gender, phone, id, email);
            patient patientInfo = new patient();
            patientInfo.name = name;
            patientInfo.lastName = lastname;
            patientInfo.age = age;
            patientInfo.email = email;
            patientInfo.patientID = id;
            patientInfo.phone = phone;
            patientInfo.gender = gender;



            patientInfo.ShowDialog();
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        static string table = "patients_table";
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from txt box
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT * FROM {table} WHERE Name LIKE '%{keyword}%' OR LastName LIKE '%{keyword}%'", conn);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);

            dgvPatients.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get data from the DB
            p.patientID = id;
            bool success;
            DialogResult d = MessageBox.Show("¿Seguro que deseas eliminar a est@ paciente?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                success = p.Delete(p);
            else
                success = false;

            if (success)
            {
                //Delete successfully
                MessageBox.Show("Consulta eliminada correctamente");

                DataTable dt = p.Select();
                dgvPatients.DataSource = dt;
                Clear();
            }
        }
    }
}
