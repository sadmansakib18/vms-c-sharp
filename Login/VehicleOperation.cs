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
    public partial class VehicleOperation : Form
    {
        private DataAccess Da { get; set; }
        private DataTable VehiclesTable { get; set; }

        public VehicleOperation()
        {
            InitializeComponent();
            Da = new DataAccess();
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            try
            {
                string sql = "SELECT vehicle_id, vehicle_name, vehicle_type, rent_per_day, status FROM Vehicles";
                DataSet ds = Da.ExecuteQuery(sql);
                if (ds != null && ds.Tables.Count > 0)
                {
                    VehiclesTable = ds.Tables[0];
                    dgvVehicles.DataSource = VehiclesTable;
                }
                else
                {
                    dgvVehicles.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message);
            }
        }

        private void btnAddDataVehciles_Click(object sender, EventArgs e)
        {
            AddVehicles addVehicles = new AddVehicles();
            // show add form as dialog and refresh after close
            addVehicles.ShowDialog();
            LoadVehicles();
        }

        private void btnUpdateVehicles_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a vehicle to edit.");
                return;
            }

            DataRow row = ((DataRowView)dgvVehicles.SelectedRows[0].DataBoundItem).Row;
            string vehicleId = row["vehicle_id"].ToString();

            // Pass vehicle id to AddVehicles to edit
            AddVehicles edit = new AddVehicles(vehicleId);
            edit.ShowDialog();
            LoadVehicles();
        }

        private void btnDeleteVehicles_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a vehicle to delete.");
                return;
            }

            DataRow row = ((DataRowView)dgvVehicles.SelectedRows[0].DataBoundItem).Row;
            string vehicleId = row["vehicle_id"].ToString();

            var conf = MessageBox.Show($"Delete vehicle {vehicleId}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (conf == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM Vehicles WHERE vehicle_id = '" + vehicleId + "'";
                    int r = Da.ExecuteUpdateQuery(sql);
                    if (r > 0)
                    {
                        MessageBox.Show("Deleted.");
                        LoadVehicles();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting vehicle: " + ex.Message);
                }
            }
        }

        private void dgvVehicles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataRow row = ((DataRowView)dgvVehicles.Rows[e.RowIndex].DataBoundItem).Row;
            string vehicleId = row["vehicle_id"].ToString();

            // Show detail in read-only dialog
            global::Login.VehicleDetail detail = new global::Login.VehicleDetail(vehicleId);
            detail.ShowDialog();
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
