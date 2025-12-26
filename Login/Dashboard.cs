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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            VehicleOperation vehicle = new VehicleOperation();
            vehicle.Show();
            
           
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TakeCutomerData data = new TakeCutomerData();
            data.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehicleDashBoard vehicleDash = new VehicleDashBoard();
            vehicleDash.Show();
            this.Hide();
        }
    }
}
