using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//important for database operations
using System.Data.SqlClient;//important for sql server database operations

namespace Login
{
    internal class DataAccess
    {
        private SqlConnection sqlcon; //database er connection stablish korar jonno
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }
        private SqlCommand sqlcom;// sql cquery command exwcute korar jonnno
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }
        private SqlDataAdapter sda;//data retrive korar jonno
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }
        private DataSet ds; // data set store korar jonno
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess() // connection string diye connection stablished kora hoise
        {
            try
            {
                this.Sqlcon = new SqlConnection(
    @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=rentdb;Integrated Security=True;
      Connect Timeout=120;Encrypt=False; TrustServerCertificate=True");
                this.Sqlcon.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Database connection failed: " + ex.Message);
            }
            
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
            this.Sqlcom.CommandTimeout = 0; // 0 means no timeout
        }

        public DataSet ExecuteQuery(string sql) //data set return korar jonno
        {
            try
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return this.Ds;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public DataTable ExecuteQueryTable(string sql) // data table return korar jonno
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }

        public int ExecuteUpdateQuery(string sql) //insert , update , delete er jonno
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }



    }
}
