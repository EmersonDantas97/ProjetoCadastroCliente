using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;

namespace CadastroClienteMVC.Model
{
    public class SQLServer
    {
        public string stringConn;
        public SqlConnection connDB;

        public SQLServer()
        {
            try
            { 
                stringConn = "Data Source=DESKTOP-7TLUK34;Initial Catalog=BancoCadastros;Persist Security Info=True;User ID=sa;Password=bispo1997";
                connDB = new SqlConnection(stringConn);
                connDB.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                var myCommand = new SqlCommand(SQL, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public string SQLCommand(string SQL)
        {
            try
            {
                var myCommand = new SqlCommand(SQL, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            connDB.Close();
        }
    }
}
