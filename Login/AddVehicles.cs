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
    public partial class AddVehicles : Form
    {
        private DataAccess Da { get; set; } //ALAMIN MUSTAFA RAHIM vvvvvvvvvvvvvvvvv
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private bool IsEdit { get; set; } = false;
        private string EditingVehicleId { get; set; }

        public AddVehicles()
        {
            InitializeComponent();
        }

        public AddVehicles(string vehicleId) : this()
        {
            // edit mode
            this.IsEdit = true;
            this.EditingVehicleId = vehicleId;
        }

        private void AddVehicles_Load(object sender, EventArgs e)
        {
            Da = new DataAccess();
            if (this.IsEdit)
            {
                LoadVehicleForEdit(this.EditingVehicleId);
            }
            else
            {
                this.GenerateVehicleId();
            }
        }

        private void LoadVehicleForEdit(string vehicleId)
        {
            try
            {
                string sql = "SELECT * FROM Vehicles WHERE vehicle_id = '" + vehicleId + "'";
                DataSet ds = this.Da.ExecuteQuery(sql);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    var r = ds.Tables[0].Rows[0];
                    this.txtVehicleId.Text = r["vehicle_id"].ToString();
                    this.txtVehicleName.Text = r["vehicle_name"].ToString();
                    this.cmbVehicleType.Text = r["vehicle_type"].ToString();
                    this.txtRentPerDay.Text = r["rent_per_day"].ToString();
                    this.cmbVehicleStatus.Text = r["status"].ToString();
                    this.txtVehicleId.ReadOnly = true;
                    this.btnSaveVehicles.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicle for edit: " + ex.Message);
            }
        }

        private void reset()
        {
            this.txtVehicleName.Clear();
            this.txtRentPerDay.Clear();
            this.cmbVehicleType.SelectedIndex = -1;
            this.cmbVehicleStatus.SelectedIndex = -1;
            this.txtRentPerDay.Clear();
            this.GenerateVehicleId();

        }

        private void GenerateVehicleId()
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM Vehicles";
                DataSet ds = this.Da.ExecuteQuery(sql);

                int count = 0;
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }

                int newId = count + 1;
                this.txtVehicleId.Text = "V-" + newId.ToString("D5"); // V-00001, V-00002, etc.

                this.txtVehicleId.ReadOnly = true; // User change korte parbe na
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Vehicle ID: " + ex.Message);
                this.txtVehicleId.Text = "V-00001";
            }
        }

        private void btnSaveVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsEdit)
                {
                    this.Sql = "UPDATE Vehicles SET vehicle_name = '" + this.txtVehicleName.Text + "', vehicle_type = '" + this.cmbVehicleType.Text + "', rent_per_day = '" + this.txtRentPerDay.Text + "', status = '" + this.cmbVehicleStatus.Text + "' WHERE vehicle_id = '" + this.txtVehicleId.Text + "'";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Vehicle updated successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vehicle update failed.");
                    }
                }
                else
                {
                    this.Sql = "INSERT INTO Vehicles(vehicle_id, vehicle_name, vehicle_type, rent_per_day, status)" +
                        " VALUES('" + this.txtVehicleId.Text + "', '" + this.txtVehicleName.Text + "', '" + this.cmbVehicleType.Text + "', '" + this.txtRentPerDay.Text + "', '" + this.cmbVehicleStatus.Text + "')";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Vehicle information saved succesfully.");
                        this.reset();
                    }
                    else
                    {
                        MessageBox.Show("Product information insertion failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured during saving the product information\n\n" + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Return to Dashboard form
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
