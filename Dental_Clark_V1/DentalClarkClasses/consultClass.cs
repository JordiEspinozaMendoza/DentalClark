using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clark_V1.DentalClarkClasses
{
    class consultClass
    {
        public int consultID { get; set; }
        public string name { get; set; }
        public string consultInfo { get; set; }
        public long phone { get; set; }
        public string email { get; set; }
        public string incharge { get; set; }

        public int patientID { get; set; }
        public DateTime date { get; set; }

        public string dateFormated { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        static string table = "consult_table";

        //Selecting data from DB
        public DataTable SelectConsults(int patientID)
        {
            //1. DB connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //2. Writing SQL Query
                string sql = $"SELECT consultID AS 'ID', date AS 'Fecha', name AS 'Paciente', consultDetail AS 'Detalles', doctor AS 'Encargado', phone AS 'Telefono', email AS 'Correo', PatientID AS 'ID Paciente' FROM {table} WHERE patientID = @patientID";
                //SQL consult
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@patientID", patientID);
                //Creating sql adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable Select()
        {
            //1. DB connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //2. Writing SQL Query
                string sql = "SELECT consultID AS 'ID', date AS 'Fecha', name AS 'Paciente', consultDetail AS 'Detalles', doctor AS 'Encargado', phone AS 'Telefono', email AS 'Correo', PatientID AS 'ID Paciente' FROM " + table;
                //SQL consult
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating sql adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable SelectConsultsForToday(string dateFormated)
        {
            
            //1. DB connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //2. Writing SQL Query
                string sql = "SELECT consultID AS 'ID', date AS 'Fecha', name AS 'Paciente', consultDetail AS 'Detalles', doctor AS 'Encargado', phone AS 'Telefono', email AS 'Correo', PatientID AS 'ID Paciente' FROM " + table + " WHERE dateFormated = @dateFormated";
                //SQL consult
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@dateFormated", dateFormated);
                //Creating sql adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable SelectConsultsByDate()
        {
            //1. DB connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //2. Writing SQL Query
                string sql = "SELECT consultID AS 'ID', date AS 'Fecha', name AS 'Paciente', consultDetail AS 'Detalles', doctor AS 'Encargado', phone AS 'Telefono', email AS 'Correo', PatientID AS 'ID Paciente' FROM " + table+ "WHERE date LIKE '%@date%'";
                //SQL consult
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", date);
                //Creating sql adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Inserting data into 
        public bool Insert(consultClass c)
        {
            //Creating a default return setting type and setting its value to false
            bool isSuccess = false;

            //1. Connect DB
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //2. Create a SQL Query to insert data into DB
                string sql = "INSERT INTO " + table + " (date, name, consultDetail, doctor, phone, email, PatientID, dateFormated) VALUES (@date, @name, @consultDetail, @doctor, @phone, @email, @PatientID, @dateFormated)";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@date", c.date);
                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@consultDetail", c.consultInfo);
                cmd.Parameters.AddWithValue("@doctor", c.incharge);
                cmd.Parameters.AddWithValue("@phone", c.phone);
                cmd.Parameters.AddWithValue("@email", c.email);
                cmd.Parameters.AddWithValue("@PatientID", c.patientID);
                cmd.Parameters.AddWithValue("@dateFormated", c.dateFormated);

                //Connection Open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of rows will be greater tan zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to update data in database from our app
        public bool Update(consultClass c)
        {
            //Create a default return type and set its default value to false
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql to update data in database
                string sql = $"UPDATE {table} SET  name=@name, consultDetail=@consultDetail, doctor=@doctor, phone=@phone, email=@email, PatientID= @PatientID WHERE consultID= @consultID";

                //Creating Sql Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating parameters to add value

                cmd.Parameters.AddWithValue("name", c.name);
                cmd.Parameters.AddWithValue("consultDetail", c.consultInfo);
                cmd.Parameters.AddWithValue("doctor", c.incharge);
                cmd.Parameters.AddWithValue("phone", c.phone);
                cmd.Parameters.AddWithValue("email", c.email);
                cmd.Parameters.AddWithValue("consultID", c.consultID);
                cmd.Parameters.AddWithValue("@PatientID", c.patientID);
                //Open DB connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be zero
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                    isSucces = false;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSucces;
        }
        //Method to Delete Data from database
        public bool Delete(consultClass c)
        {
            //Create a default return value and its value is false
            bool isSuccess = false;
            //Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Sql to delete data
                string sql = $"DELETE FROM {table} WHERE consultID=@consultID";

                //Creating  SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("consultID", c.consultID);
                //Open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query run successfully then value of rows is greater than zero else its value is 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                    //Delete failed
                    MessageBox.Show("No se ha podido eliminar la consulta");

                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                //Close connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
