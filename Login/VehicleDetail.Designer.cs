namespace Login
{
 partial class VehicleDetail
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

 private void InitializeComponent()
 {
 this.label1 = new System.Windows.Forms.Label();
 this.label2 = new System.Windows.Forms.Label();
 this.label3 = new System.Windows.Forms.Label();
 this.label4 = new System.Windows.Forms.Label();
 this.label5 = new System.Windows.Forms.Label();
 this.lblId = new System.Windows.Forms.Label();
 this.lblName = new System.Windows.Forms.Label();
 this.lblType = new System.Windows.Forms.Label();
 this.lblRent = new System.Windows.Forms.Label();
 this.lblStatus = new System.Windows.Forms.Label();
 this.btnClose = new System.Windows.Forms.Button();
 this.SuspendLayout();
 //
 // label1
 //
 this.label1.AutoSize = true;
 this.label1.Location = new System.Drawing.Point(12,15);
 this.label1.Name = "label1";
 this.label1.Size = new System.Drawing.Size(47,13);
 this.label1.TabIndex =0;
 this.label1.Text = "Vehicle:";
 //
 // label2
 //
 this.label2.AutoSize = true;
 this.label2.Location = new System.Drawing.Point(12,40);
 this.label2.Name = "label2";
 this.label2.Size = new System.Drawing.Size(38,13);
 this.label2.TabIndex =1;
 this.label2.Text = "Name:";
 //
 // label3
 //
 this.label3.AutoSize = true;
 this.label3.Location = new System.Drawing.Point(12,65);
 this.label3.Name = "label3";
 this.label3.Size = new System.Drawing.Size(36,13);
 this.label3.TabIndex =2;
 this.label3.Text = "Type:";
 //
 // label4
 //
 this.label4.AutoSize = true;
 this.label4.Location = new System.Drawing.Point(12,90);
 this.label4.Name = "label4";
 this.label4.Size = new System.Drawing.Size(35,13);
 this.label4.TabIndex =3;
 this.label4.Text = "Rent:";
 //
 // label5
 //
 this.label5.AutoSize = true;
 this.label5.Location = new System.Drawing.Point(12,115);
 this.label5.Name = "label5";
 this.label5.Size = new System.Drawing.Size(40,13);
 this.label5.TabIndex =4;
 this.label5.Text = "Status:";
 //
 // lblId
 //
 this.lblId.AutoSize = true;
 this.lblId.Location = new System.Drawing.Point(80,15);
 this.lblId.Name = "lblId";
 this.lblId.Size = new System.Drawing.Size(10,13);
 this.lblId.TabIndex =5;
 this.lblId.Text = "-";
 //
 // lblName
 //
 this.lblName.AutoSize = true;
 this.lblName.Location = new System.Drawing.Point(80,40);
 this.lblName.Name = "lblName";
 this.lblName.Size = new System.Drawing.Size(10,13);
 this.lblName.TabIndex =6;
 this.lblName.Text = "-";
 //
 // lblType
 //
 this.lblType.AutoSize = true;
 this.lblType.Location = new System.Drawing.Point(80,65);
 this.lblType.Name = "lblType";
 this.lblType.Size = new System.Drawing.Size(10,13);
 this.lblType.TabIndex =7;
 this.lblType.Text = "-";
 //
 // lblRent
 //
 this.lblRent.AutoSize = true;
 this.lblRent.Location = new System.Drawing.Point(80,90);
 this.lblRent.Name = "lblRent";
 this.lblRent.Size = new System.Drawing.Size(10,13);
 this.lblRent.TabIndex =8;
 this.lblRent.Text = "-";
 //
 // lblStatus
 //
 this.lblStatus.AutoSize = true;
 this.lblStatus.Location = new System.Drawing.Point(80,115);
 this.lblStatus.Name = "lblStatus";
 this.lblStatus.Size = new System.Drawing.Size(10,13);
 this.lblStatus.TabIndex =9;
 this.lblStatus.Text = "-";
 //
 // btnClose
 //
 this.btnClose.Location = new System.Drawing.Point(100,150);
 this.btnClose.Name = "btnClose";
 this.btnClose.Size = new System.Drawing.Size(75,23);
 this.btnClose.TabIndex =10;
 this.btnClose.Text = "Close";
 this.btnClose.UseVisualStyleBackColor = true;
 this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
 //
 // VehicleDetail
 //
 this.AutoScaleDimensions = new System.Drawing.SizeF(6F,13F);
 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
 this.ClientSize = new System.Drawing.Size(300,200);
 this.Controls.Add(this.btnClose);
 this.Controls.Add(this.lblStatus);
 this.Controls.Add(this.lblRent);
 this.Controls.Add(this.lblType);
 this.Controls.Add(this.lblName);
 this.Controls.Add(this.lblId);
 this.Controls.Add(this.label5);
 this.Controls.Add(this.label4);
 this.Controls.Add(this.label3);
 this.Controls.Add(this.label2);
 this.Controls.Add(this.label1);
 this.Name = "VehicleDetail";
 this.Text = "Vehicle Detail";
 this.ResumeLayout(false);
 this.PerformLayout();
 }

 #endregion
 private System.Windows.Forms.Label label1;
 private System.Windows.Forms.Label label2;
 private System.Windows.Forms.Label label3;
 private System.Windows.Forms.Label label4;
 private System.Windows.Forms.Label label5;
 private System.Windows.Forms.Label lblId;
 private System.Windows.Forms.Label lblName;
 private System.Windows.Forms.Label lblType;
 private System.Windows.Forms.Label lblRent;
 private System.Windows.Forms.Label lblStatus;
 private System.Windows.Forms.Button btnClose;
 }
}
