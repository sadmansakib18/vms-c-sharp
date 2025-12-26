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
    public partial class VehicleDashBoard : Form
    {
        public VehicleDashBoard()
        {
            InitializeComponent();
        }

        private void btnCreateRent_Click(object sender, EventArgs e)
        {
            TakeRent rent = new TakeRent();
            rent.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning to dashboard: " + ex.Message);
            }
        }
    }
}
