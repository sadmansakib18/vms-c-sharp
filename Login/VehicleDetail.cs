using System;
using System.Data;
using System.Windows.Forms;

namespace Login
{
 public partial class VehicleDetail : Form
 {
 private DataAccess Da { get; set; }
 private string VehicleId { get; set; }
 public VehicleDetail(string vehicleId)
 {
 InitializeComponent();
 Da = new DataAccess();
 VehicleId = vehicleId;
 LoadDetail();
 }

 private void LoadDetail()
 {
 try
 {
 string sql = "SELECT * FROM Vehicles WHERE vehicle_id = '" + VehicleId + "'";
 DataSet ds = Da.ExecuteQuery(sql);
 if (ds != null && ds.Tables.Count >0 && ds.Tables[0].Rows.Count >0)
 {
 var r = ds.Tables[0].Rows[0];
 lblId.Text = r["vehicle_id"].ToString();
 lblName.Text = r["vehicle_name"].ToString();
 lblType.Text = r["vehicle_type"].ToString();
 lblRent.Text = r["rent_per_day"].ToString();
 lblStatus.Text = r["status"].ToString();
 }
 }
 catch (Exception ex)
 {
 MessageBox.Show("Error loading vehicle detail: " + ex.Message);
 }
 }

 private void btnClose_Click(object sender, EventArgs e)
 {
 this.Close();
 }
 }
}
