namespace PanditStationWinForms
{
    partial class NewBill
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
            this.VehicleList = new System.Windows.Forms.ComboBox();
            this.CustomerList = new System.Windows.Forms.ComboBox();
            this.BillingPanel = new System.Windows.Forms.Panel();
            this.JobListView = new System.Windows.Forms.ListView();
            this.JobID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JobType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JobDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceCharge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BillingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleList
            // 
            this.VehicleList.FormattingEnabled = true;
            this.VehicleList.Location = new System.Drawing.Point(309, 23);
            this.VehicleList.Name = "VehicleList";
            this.VehicleList.Size = new System.Drawing.Size(121, 21);
            this.VehicleList.TabIndex = 3;
            this.VehicleList.Text = "Select Vehicle(s)";
            this.VehicleList.SelectedIndexChanged += new System.EventHandler(this.VehicleList_SelectedIndexChanged);
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(38, 23);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(121, 21);
            this.CustomerList.TabIndex = 2;
            this.CustomerList.Text = "Select Customer";
            this.CustomerList.SelectedIndexChanged += new System.EventHandler(this.CustomerList_SelectedIndexChanged);
            // 
            // BillingPanel
            // 
            this.BillingPanel.Controls.Add(this.JobListView);
            this.BillingPanel.Location = new System.Drawing.Point(38, 73);
            this.BillingPanel.Name = "BillingPanel";
            this.BillingPanel.Size = new System.Drawing.Size(411, 280);
            this.BillingPanel.TabIndex = 4;
            this.BillingPanel.Visible = false;
            // 
            // JobListView
            // 
            this.JobListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JobID,
            this.JobType,
            this.JobDate,
            this.ServiceCharge,
            this.Quantity,
            this.Price});
            this.JobListView.Location = new System.Drawing.Point(6, 3);
            this.JobListView.Name = "JobListView";
            this.JobListView.Size = new System.Drawing.Size(402, 97);
            this.JobListView.TabIndex = 0;
            this.JobListView.UseCompatibleStateImageBehavior = false;
            this.JobListView.View = System.Windows.Forms.View.Details;
            this.JobListView.SelectedIndexChanged += new System.EventHandler(this.JobListView_SelectedIndexChanged);
            // 
            // JobID
            // 
            this.JobID.Text = "JobID";
            this.JobID.Width = 40;
            // 
            // JobType
            // 
            this.JobType.Text = "JobType";
            this.JobType.Width = 70;
            // 
            // JobDate
            // 
            this.JobDate.Text = "JobDate";
            this.JobDate.Width = 70;
            // 
            // ServiceCharge
            // 
            this.ServiceCharge.Text = "ServiceCharge";
            this.ServiceCharge.Width = 85;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 70;
            // 
            // NewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 383);
            this.Controls.Add(this.BillingPanel);
            this.Controls.Add(this.VehicleList);
            this.Controls.Add(this.CustomerList);
            this.Name = "NewBill";
            this.Text = "NewBill";
            this.Load += new System.EventHandler(this.NewBill_Load);
            this.BillingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox VehicleList;
        private System.Windows.Forms.ComboBox CustomerList;
        private System.Windows.Forms.Panel BillingPanel;
        private System.Windows.Forms.ListView JobListView;
        private System.Windows.Forms.ColumnHeader JobID;
        private System.Windows.Forms.ColumnHeader JobType;
        private System.Windows.Forms.ColumnHeader JobDate;
        private System.Windows.Forms.ColumnHeader ServiceCharge;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
    }
}