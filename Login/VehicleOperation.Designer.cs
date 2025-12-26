namespace Login
{
    partial class VehicleOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddVehicles = new System.Windows.Forms.Button();
            this.btnUpdateVehicles = new System.Windows.Forms.Button();
            this.btnDeleteVehicles = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddVehicles
            // 
            this.btnAddVehicles.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicles.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddVehicles.Location = new System.Drawing.Point(139, 360);
            this.btnAddVehicles.Name = "btnAddVehicles";
            this.btnAddVehicles.Size = new System.Drawing.Size(148, 41);
            this.btnAddVehicles.TabIndex = 0;
            this.btnAddVehicles.Text = "Add";
            this.btnAddVehicles.UseVisualStyleBackColor = false;
            this.btnAddVehicles.Click += new System.EventHandler(this.btnAddDataVehciles_Click);
            // 
            // btnUpdateVehicles
            // 
            this.btnUpdateVehicles.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVehicles.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUpdateVehicles.Location = new System.Drawing.Point(328, 360);
            this.btnUpdateVehicles.Name = "btnUpdateVehicles";
            this.btnUpdateVehicles.Size = new System.Drawing.Size(148, 41);
            this.btnUpdateVehicles.TabIndex = 1;
            this.btnUpdateVehicles.Text = "Edit";
            this.btnUpdateVehicles.UseVisualStyleBackColor = false;
            this.btnUpdateVehicles.Click += new System.EventHandler(this.btnUpdateVehicles_Click);
            // 
            // btnDeleteVehicles
            // 
            this.btnDeleteVehicles.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVehicles.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDeleteVehicles.Location = new System.Drawing.Point(527, 360);
            this.btnDeleteVehicles.Name = "btnDeleteVehicles";
            this.btnDeleteVehicles.Size = new System.Drawing.Size(148, 41);
            this.btnDeleteVehicles.TabIndex = 2;
            this.btnDeleteVehicles.Text = "Delete";
            this.btnDeleteVehicles.UseVisualStyleBackColor = false;
            this.btnDeleteVehicles.Click += new System.EventHandler(this.btnDeleteVehicles_Click);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(12, 12);
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(776, 330);
            this.dgvVehicles.TabIndex = 4;
            this.dgvVehicles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicles_CellDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // VehicleOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteVehicles);
            this.Controls.Add(this.btnUpdateVehicles);
            this.Controls.Add(this.btnAddVehicles);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvVehicles);
            this.Name = "VehicleOperation";
            this.Text = "VehicleOperation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddVehicles;
        private System.Windows.Forms.Button btnUpdateVehicles;
        private System.Windows.Forms.Button btnDeleteVehicles;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvVehicles;
    }
}