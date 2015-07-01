using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segment_5_Pasan.Infrastructure
{
    public class Database
    {
        SqlConnection connection;

        public Database()
        {
            connection = ConnectionManager.GetConnection();
        }

        public DataSet FillGrid()
        {
            DataSet ds = new DataSet();
            try
            {
                if (connection.State.ToString() == "Closed")
                {
                    connection.Open();
                }

                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "Select_Table";

                SqlDataAdapter sqlDataAdaptor = new SqlDataAdapter(sqlCommand);
                sqlDataAdaptor.Fill(ds, "Registration");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        public bool AddNewStudent(string name,string dob,double gradepoint,int active)
        {
            bool status = false;
            
            try 
            {
                if (connection.State.ToString() == "Closed")
                {
                    connection.Open();
                }
                SqlCommand sqlCommand = new SqlCommand("Insert_Student",connection);
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlCommand.CommandText="insert into registration (Name,DOB,GreadePointAverage,Active) values('"+ name +"','"+ dob +"',"+ gradepoint +","+ active +");";
                sqlCommand.Parameters.Add(new SqlParameter("@std_Name", SqlDbType.VarChar)).Value = name;
                sqlCommand.Parameters.Add(new SqlParameter("@std_DOB", SqlDbType.VarChar)).Value = dob;
                sqlCommand.Parameters.Add(new SqlParameter("@std_Gread", SqlDbType.VarChar)).Value = gradepoint;
                sqlCommand.Parameters.Add(new SqlParameter("@std_active", SqlDbType.VarChar)).Value = active;

                sqlCommand.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return status;
        }
    }
}
