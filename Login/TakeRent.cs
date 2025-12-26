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
    public partial class TakeRent : Form
    {
        private DataAccess Da { get; set; } //ALAMIN MUSTAFA RAHIM vvvvvvvvvvvvvvvvv
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public TakeRent()
        {
            InitializeComponent();
            Da = new DataAccess();
            GenerateRentalId();
        }

        private void GenerateRentalId()
        {
            try
            {
                this.Sql = "SELECT COUNt(*) FROM Rent";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                int count = 0;
                if (this.Ds != null && this.Ds.Tables.Count > 0 && this.Ds.Tables[0].Rows.Count > 0)
                {
                    count = Convert.ToInt32(this.Ds.Tables[0].Rows[0][0]);
                   

                }
                int newId = count + 1;
                this.txtRentalId.Text = "R-" + newId.ToString("D5"); // R-00001, R-00002, etc.
                this.txtRentalId.ReadOnly = true; // User change korte parbe na



            }
            catch(Exception ex)
            {
               MessageBox.Show("An error occurred while generating Rental ID: " + ex.Message);
            }
        }
        private void reset()
        {
            this.txtCustomerId.Clear();
            this.txtVehicleId.Clear();
            this.txtRentDate.Clear();
            this.txtEndDate.Clear();
            this.txtTotalDays.Clear();
            this.txtTotalAmount.Clear();
            this.txtStatus.Clear();
            this.GenerateRentalId();
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            try {

                string customerId = this.txtCustomerId.Text;
                string vehicleId = this.txtVehicleId.Text;
                this.txtStatus.Text = "Pending";
                this.txtStatus.ReadOnly = true;
                string staffId = "S-00001"; // Assuming a default staff ID for now


                // Check if customer exists
                this.Sql = "SELECT COUNT(*) FROM Customer WHERE customer_id = '" + customerId + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);

                int customerExists = 0;
                if (this.Ds != null && this.Ds.Tables.Count > 0 && this.Ds.Tables[0].Rows.Count > 0)
                {
                    customerExists = Convert.ToInt32(this.Ds.Tables[0].Rows[0][0]);


                }

                if (customerExists > 0)
                {
                    //vehicle ache ki na cheak koro or available ki na
                    this.Sql = "SeLECT COUNT(*) FROM Vehicles WHERE vehicle_id = '" + vehicleId + "' AND status = 'Available'";
                    this.Ds = this.Da.ExecuteQuery(this.Sql);
                    int vehicleAvailable = 0;
                    if (this.Ds != null && this.Ds.Tables.Count > 0 && this.Ds.Tables[0].Rows.Count > 0)
                    {
                        vehicleAvailable = Convert.ToInt32(this.Ds.Tables[0].Rows[0][0]);
                    }
                    if (vehicleAvailable > 0)
                    {

                        // Calculate total days
                        DateTime rentDate;
                        DateTime endDate;
                        int totalDays = 0;
                        decimal totalAmount = 0;

                        if (DateTime.TryParse(this.txtRentDate.Text, out rentDate) && DateTime.TryParse(this.txtEndDate.Text, out endDate))
                        {
                            TimeSpan difference = endDate - rentDate;
                            totalDays = difference.Days;

                            if (totalDays < 0)
                            {
                                MessageBox.Show("End date must be after rent date!");
                                return;
                            }
                            
                            // Set total days to textbox
                            this.txtTotalDays.Text = totalDays.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Invalid date format! Please enter valid dates.");
                            return;
                        }
                        
                        // Get rent_per_day from Vehicles table using vehicle_id
                        this.Sql = "SELECT rent_per_day FROM Vehicles WHERE vehicle_id = '" + vehicleId + "'";
                        this.Ds = this.Da.ExecuteQuery(this.Sql);

                        if (this.Ds != null && this.Ds.Tables.Count > 0 && this.Ds.Tables[0].Rows.Count > 0)
                        {
                            // Extract rent_per_day from the first row
                            decimal rentPerDay = Convert.ToDecimal(this.Ds.Tables[0].Rows[0]["rent_per_day"]);

                            totalAmount = rentPerDay * totalDays;
                            
                            // Set total amount to textbox
                            this.txtTotalAmount.Text = totalAmount.ToString("F2");
                        }
                        else
                        {
                            MessageBox.Show("Could not fetch rent per day!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vehicle is Not Available@!!!!!!!!!!");
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("Customer does not exist!");
                    return;
                }
                
                // Insert rental data into database
                this.Sql = "INSERT INTO Rent(rental_id, cutomer_id, vehicle_id, staff_id, rent_date, end_date, total_days, total_amount, status)" +
                    " VALUES('" + this.txtRentalId.Text + "', '" + this.txtCustomerId.Text + "', '" + this.txtVehicleId.Text + "', '" + staffId + "', " + 
                    "CONVERT(DATE, '" + this.txtRentDate.Text + "'), CONVERT(DATE, '" + this.txtEndDate.Text + "'), " + this.txtTotalDays.Text + ", " + this.txtTotalAmount.Text + ", '" + this.txtStatus.Text + "')";
                
                int rowsAffected = this.Da.ExecuteUpdateQuery(this.Sql);
                
                if (rowsAffected > 0)
                {
                    // Update vehicle status to Rented
                    this.Sql = "UPDATE Vehicles SET status = 'Pending' WHERE vehicle_id = '" + vehicleId + "'";
                    int vehicleUpdated = this.Da.ExecuteUpdateQuery(this.Sql);
                    
                    if (vehicleUpdated > 0)
                    {
                        MessageBox.Show("Rental added successfully and vehicle status updated to Rented!");
                    }
                    else
                    {
                        MessageBox.Show("Rental added but failed to update vehicle status.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to add rental.");
                }
                this.reset();

                
            }
            catch(Exception ex)
            {
              MessageBox.Show("An error occurred while adding rental: " + ex.Message);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error returning to dashboard: " + ex.Message);
            }
        }
    }
}
