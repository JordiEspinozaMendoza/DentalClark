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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        static string table = "consult_table";
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            //Get the value from txt box
            string keyword = dateTimePicker1.Text;
            MessageBox.Show(keyword);
            string sql = $"SELECT * FROM {table} WHERE dateFormated LIKE '%{keyword}%'"; ;
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sqlData.Fill(dt);

            dgvConsults.DataSource = dt;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.ShowDialog();
            this.Close();

        }

        private void history_Load(object sender, EventArgs e)
        {
            consultClass c = new consultClass();
            DataTable dt = c.Select();
            dgvConsults.DataSource = dt;
        }
    }
}
