namespace Login
{
    partial class VehicleDashBoard
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
            this.btnCreateRent = new System.Windows.Forms.Button();
            this.btnShowRent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateRent
            // 
            this.btnCreateRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateRent.Location = new System.Drawing.Point(35, 125);
            this.btnCreateRent.Name = "btnCreateRent";
            this.btnCreateRent.Size = new System.Drawing.Size(122, 52);
            this.btnCreateRent.TabIndex = 0;
            this.btnCreateRent.Text = "Create rent";
            this.btnCreateRent.UseVisualStyleBackColor = false;
            this.btnCreateRent.Click += new System.EventHandler(this.btnCreateRent_Click);
            // 
            // btnShowRent
            // 
            this.btnShowRent.Location = new System.Drawing.Point(247, 125);
            this.btnShowRent.Name = "btnShowRent";
            this.btnShowRent.Size = new System.Drawing.Size(108, 52);
            this.btnShowRent.TabIndex = 1;
            this.btnShowRent.Text = "Show Rent";
            this.btnShowRent.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update Rent";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete Rent";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // VehicleDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowRent);
            this.Controls.Add(this.btnCreateRent);
            this.Name = "VehicleDashBoard";
            this.Text = "VehicleDashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRent;
        private System.Windows.Forms.Button btnShowRent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
    }
}