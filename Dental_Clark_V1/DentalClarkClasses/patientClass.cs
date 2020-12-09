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
    class patientClass
    {
        public int patientID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        static string table = "patients_table";
        //Selecting data from DB
        public DataTable Select()
        {
            //1. DB connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //2. Writing SQL Query
                string sql = "SELECT PatientID as 'ID', Name AS 'Nombre', LastName AS 'Apellidos', Email AS 'Correo', Phone AS 'Teléfono', Gender AS 'Sexo', Age AS 'Edad' FROM " + table;
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
        //Inserting data into 
        public bool Insert(patientClass c)
        {
            //Creating a default return setting type and setting its value to false
            bool isSuccess = false;

            //1. Connect DB
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //2. Create a SQL Query to insert data into DB
                string sql = "INSERT INTO " + table + " (Name, LastName, Email, Phone, Gender, Age, FullName) VALUES (@Name, @LastName, @Email, @Phone, @Gender, @Age, @FullName)";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Age", c.Age);
                cmd.Parameters.AddWithValue("@FullName", c.Name + " " + c.LastName);

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
        public bool Update(patientClass p)
        {
            //Create a default return type and set its default value to false
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql to update data in database
                string sql = $"UPDATE {table} SET Name=@Name, LastName = @LastName, Email=@Email, Phone=@Phone, Gender =@Gender, Age=@Age WHERE PatientID=@PatientID";

                //Creating Sql Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating parameters to add value
                cmd.Parameters.AddWithValue("Name", p.Name);
                cmd.Parameters.AddWithValue("LastName", p.LastName);
                cmd.Parameters.AddWithValue("Email", p.Email);
                cmd.Parameters.AddWithValue("Phone", p.Phone);
                cmd.Parameters.AddWithValue("Gender", p.Gender);
                cmd.Parameters.AddWithValue("Age", p.Age);
                cmd.Parameters.AddWithValue("@PatientID", p.patientID);

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
        public bool Delete(patientClass p)
        {
            //Create a default return value and its value is false
            bool isSuccess = false;
            //Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Sql to delete data
                string sql = $"DELETE FROM {table} WHERE patientID=@patientID";

                //Creating  SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("patientID", p.patientID);
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
                    MessageBox.Show("No se ha podido eliminar al paciente");
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
