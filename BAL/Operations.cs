using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace BAL
{
    public class Operations
    {
        public DbConnection db = new DbConnection();
        public Informations info = new Informations();

        public int InsertStudent(Informations info)
        {
            SqlCommand sqlCmd = new SqlCommand("spAddStudent", db.getCon());
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "Save");
            sqlCmd.Parameters.AddWithValue("@FirstName", info.FirstName);
            sqlCmd.Parameters.AddWithValue("@LastName", info.Surname);
            sqlCmd.Parameters.AddWithValue("@Email", info.Email);
            sqlCmd.Parameters.AddWithValue("@Phone", info.Phone);
            sqlCmd.Parameters.AddWithValue("@AddressLine1", info.AddressLine1);
            sqlCmd.Parameters.AddWithValue("@AddressLine2", info.AddressLine2);
            sqlCmd.Parameters.AddWithValue("@City", info.City);
            sqlCmd.Parameters.AddWithValue("@County", info.County);
            sqlCmd.Parameters.AddWithValue("@GradLevel", info.Level);
            sqlCmd.Parameters.AddWithValue("@Course", info.Course);
            sqlCmd.Parameters.AddWithValue("StudentNumber", info.StudentNumber);
            try
            {
                db.getCon();
                int rowRes = db.ExeNonQuery(sqlCmd);
                return rowRes;
            }
            catch (Exception ex)
            {

                throw new Exception("Error..." + ex.Message);
            }
            finally
            {
                db.closeCon();
            }
        }

        public int UpdateStudent(Informations info)
        {
            SqlCommand sqlCmd = new SqlCommand("spUpdateStudent", db.getCon());
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "Edit");
            sqlCmd.Parameters.AddWithValue("@Email", info.Email);
            sqlCmd.Parameters.AddWithValue("@Phone", info.Phone);
            sqlCmd.Parameters.AddWithValue("@AddressLine1", info.AddressLine1);
            sqlCmd.Parameters.AddWithValue("@AddressLine2", info.AddressLine2);
            sqlCmd.Parameters.AddWithValue("@City", info.City);
            sqlCmd.Parameters.AddWithValue("@County", info.County);
            sqlCmd.Parameters.AddWithValue("@GradLevel", info.Level);
            sqlCmd.Parameters.AddWithValue("StudentNumber", info.StudentNumber);
            try
            {
                db.getCon();
                int rowRes = db.ExeNonQuery(sqlCmd);
                return rowRes;
            }
            catch (Exception ex)
            {

                throw new Exception("Error..." + ex.Message);
            }
            finally
            {
                db.closeCon();
            }
        }

        public int DeleteStudent(int studentNumber)
        {
            SqlCommand sqlCmd = new SqlCommand("spDeleteRecord", db.getCon());
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "Delete");
            sqlCmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
            try
            {
                db.getCon();
                int numRes = db.ExeNonQuery(sqlCmd);
                return numRes;

            }
            catch (Exception ex)
            {

                throw new Exception("Error..." + ex.Message);
            }
            finally
            {
                db.closeCon();
            }
            
             

        }

        public DataTable FetchStudentRecords(Informations info)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT FirstName, LastName, StudentNumber, County, Course, GradLevel FROM tb_Student";
            return db.ExeReader(sqlCmd);
        }

        public DataTable login(LoginUser loginInfo)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tb_Login WHERE UserName = '" + loginInfo.Username + "' AND UserPassword = '" + loginInfo.Password + "'";
            return db.ExeReader(sqlCmd);
        }

        public DataTable FetchAllStudentAttribute(Informations info)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT StudentNumber, FirstName, LastName, Email, Phone, AddressLine1, AddressLine2, City, County, GradLevel, Course FROM tb_Student";
            return db.ExeReader(sqlCmd);
        }

        public static class XmlTools
        {

            public static void ExportXML()
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["assignmentDB"].ConnectionString);
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT StudentNumber, FirstName, LastName, Email, Phone, AddressLine1, AddressLine2, City, County, GradLevel, Course FROM tb_Student", conn);
                DataTable dt = new DataTable { TableName = "tb_Student" };
                sqlData.Fill(dt);


                var openFileDialog = new SaveFileDialog();
                openFileDialog.DefaultExt = ".xml";
                openFileDialog.Filter = "XML File | *.xml";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = openFileDialog.FileName;
                    dt.WriteXml(path);
                    MessageBox.Show("File successfully exported");
                }
            }
        }
    }
}
