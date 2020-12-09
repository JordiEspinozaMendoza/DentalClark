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
    public partial class home : Form
    {
        public DateTime dateUpdate;
        public home()
        {
            InitializeComponent();
        }
        consultClass c = new consultClass();
        static string dateFormated = DateTime.Now.ToString("dd-MM-yyyy");
        private void home_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'dataSet3.patients_table' Puede moverla o quitarla según sea necesario.
            //this.patients_tableTableAdapter2.Fill(this.dataSet3.patients_table);
            dgvConsults.AllowUserToAddRows = false;
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.patients_table' Puede moverla o quitarla según sea necesario.
            //this.patients_tableTableAdapter1.Fill(this.dataSet2.patients_table);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.patients_table' Puede moverla o quitarla según sea necesario.
            //this.patients_tableTableAdapter.Fill(this.dataSet1.patients_table);
            //Load data on datagridview

            DataTable dt = c.SelectConsultsForToday(dateFormated);
            dgvConsults.DataSource = dt;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            if (txtUsername.Text != "" && txtPhone.Text != "" && txtConsultInfo.Text != "" && txtIncharge.Text != "")
            {
                c.name = txtUsername.Text;
                c.phone = long.Parse(txtPhone.Text);
                c.date = DateTime.Now;
                c.consultInfo = txtConsultInfo.Text;
                c.incharge = txtIncharge.Text;
                c.email = txtEmail.Text;
                c.patientID = int.Parse(txtUsername.SelectedValue.ToString());
                c.dateFormated = DateTime.Now.ToString("dd-MM-yyyy");

                //Inserting data into data base using the method we created 
                bool success = c.Insert(c);
                if (success)
                {
                    //Successfully inserted
                    MessageBox.Show("Nueva consulta insertada");
                    Clear();
                }
                else
                {
                    //Successfully inserted
                    MessageBox.Show("Error al agregar consulta");
                }
            }
            else
            {
                MessageBox.Show("Ingresa los datos del formulario correctamente");
            }
            //Load data on datagridview

            DataTable dt = c.SelectConsultsForToday(dateFormated);
            dgvConsults.DataSource = dt;

        }
        //Method to clear fields
        public void Clear()
        {
            txtConsultInfo.Text = "";
            txtEmail.Text = "";
            txtIncharge.Text = "";
            txtPhone.Text = "";
            txtUsername.Text = "";
            txtDate.Text = "";
            txtConsultID.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            //Get the data from txtboxes
            c.consultID = int.Parse(txtConsultID.Text);
            c.name = txtUsername.Text;
            c.consultInfo = txtConsultInfo.Text;
            c.email = txtEmail.Text;
            c.phone = int.Parse(txtPhone.Text);
            c.incharge = txtIncharge.Text;


            //Update Data in data base
            bool success = c.Update(c);
            if (success)
            {
                //Update successfully
                MessageBox.Show("Consulta actualizada correctamente");
                Clear();
            }
            else
            {
                //Update failed
                MessageBox.Show("No se ha podido actualizar la consulta");
            }

            DataTable dt = c.SelectConsultsForToday(dateFormated);
            dgvConsults.DataSource = dt;

        }

        private void dgvConsults_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from data grid view and load it to the textboxes respectively
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtConsultID.Text = dgvConsults.Rows[rowIndex].Cells[0].Value.ToString();
            txtDate.Text = dgvConsults.Rows[rowIndex].Cells[1].Value.ToString();
            txtUsername.Text = dgvConsults.Rows[rowIndex].Cells[2].Value.ToString();
            txtConsultInfo.Text = dgvConsults.Rows[rowIndex].Cells[3].Value.ToString();
            txtIncharge.Text = dgvConsults.Rows[rowIndex].Cells[4].Value.ToString();
            txtPhone.Text = dgvConsults.Rows[rowIndex].Cells[5].Value.ToString();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get data from the DB
            c.consultID = int.Parse(txtConsultID.Text);
            bool success;
            DialogResult d = MessageBox.Show("¿Seguro que deseas eliminar esta consulta?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                success = c.Delete(c);
            else
                success = false;

            if (success)
            {
                //Delete successfully
                MessageBox.Show("Consulta eliminada correctamente");

                DataTable dt = c.SelectConsultsForToday(dateFormated);
                dgvConsults.DataSource = dt;
                Clear();
            }
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        static string table = "consult_table";
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from txt box
            SqlConnection conn = new SqlConnection(myconnstrng);
            string keyword = txtSearch.Text;
            string sql = $"SELECT consultID AS 'ID', date AS 'Fecha', name AS 'Paciente', consultDetail AS 'Detalles', doctor AS 'Encargado', phone AS 'Telefono', email AS 'Correo', PatientID AS 'ID Paciente' FROM {table} WHERE (name LIKE '%{keyword}%' OR consultDetail LIKE '%{keyword}%' OR doctor LIKE '%{keyword}%' OR email LIKE '%{keyword}%') AND dateFormated = @dateFormated";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@dateFormated", dateFormated);
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);

            dgvConsults.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            patients patients = new patients();
            patients.ShowDialog();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            conn.Open();
            if (txtUsername.Text != "" && txtUsername.SelectedValue.ToString() != "")
            {
                SqlCommand cmd = new SqlCommand($"SELECT Email, Phone FROM patients_table WHERE patientID = @patientID", conn);
                cmd.Parameters.AddWithValue("@patientID", int.Parse(txtUsername.SelectedValue.ToString()));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtEmail.Text = da.GetValue(0).ToString();
                    txtPhone.Text = da.GetValue(1).ToString();
                }
                conn.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            history history = new history();
            history.ShowDialog();

        }
    }
}
