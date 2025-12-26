using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userName = this.txtUserName.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            string sql = "SELECT * FROM Authority WHERE LOWER(username) = LOWER('" + userName + "') AND password = '" + password + "'";
            // show dialoge with the swl print
            //DialogResult dialogResult = MessageBox.Show("Executing SQL:\n" + sql, "SQL Query", MessageBoxButtons.OKCancel);

            
            try
            {
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                MessageBox.Show("count: " + ds.Tables.Count + "rows :" + ds.Tables[0].Rows.Count);


                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        MessageBox.Show("Invalid Username or Password. Found " + ds.Tables[0].Rows.Count + " matches.");
                    }
                    else
                    {
                        MessageBox.Show("Query failed or no data returned.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
