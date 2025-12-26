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
    public partial class TakeCutomerData : Form
    {
        private DataAccess Da { get; set; } //ALAMIN MUSTAFA RAHIM vvvvvvvvvvvvvvvvv
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public TakeCutomerData()
        {
            InitializeComponent();
            Da = new DataAccess();
            GenerateCustomerId();
        }

        private void GenerateCustomerId()
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM Customer";
                DataSet ds = this.Da.ExecuteQuery(sql);
                int count = 0;
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }
                int newId = count + 1;
                this.txtCutomerId.Text = "C-" + newId.ToString("D5"); // C-00001, C-00002, etc.
                this.txtCutomerId.ReadOnly = true; // User change korte parbe na

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error generating Customer ID: " + ex.Message);
                this.txtCutomerId.Text = "C-00001";
            }
        }
        private void reset()
        {
            //this.txtCutomerId.Clear();
            this.txtCutomerName.Clear();
            this.txtCutomerAdress.Clear();
            this.txtCutomerPhone.Clear();
            GenerateCustomerId();

        }

        private void btnCutomerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string customerId = txtCutomerId.Text;
                string customerName = txtCutomerName.Text;
                string customerPhone = txtCutomerPhone.Text;
                string customerAddress = txtCutomerAdress.Text;
                
                // database a insert korbo
                this.Sql = "INSERT INTO Customer (customer_id, customer_name, customer_phone, customer_address) " +
                    "VALUES('" + customerId + "', '" + customerName + "', '" + customerPhone + "', '" + customerAddress + "')";
                int row = this.Da.ExecuteUpdateQuery(this.Sql);
                if (row == 1)
                {
                    MessageBox.Show("Customer added successfully.");
                    this.reset();
                }
                else
                {
                    MessageBox.Show("Failed to add customer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error returning to dashboard: " + ex.Message);
            }
        }
    }
}
