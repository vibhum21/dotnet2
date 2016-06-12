namespace PanditStationWinForms
{
    partial class NewServiceRequest
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
            this.CustomerList = new System.Windows.Forms.ComboBox();
            this.VehicleList = new System.Windows.Forms.ComboBox();
            this.ServicePanel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.MaintenanceRadio = new System.Windows.Forms.RadioButton();
            this.MaintenancePanel = new System.Windows.Forms.Panel();
            this.MaintenanceComboBox = new System.Windows.Forms.ComboBox();
            this.OilingPanel = new System.Windows.Forms.Panel();
            this.OilingComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OilQtyTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OilQuantityPanel = new System.Windows.Forms.Panel();
            this.MaintenQtyPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SPQtyTextBox = new System.Windows.Forms.TextBox();
            this.ServicePanel.SuspendLayout();
            this.MaintenancePanel.SuspendLayout();
            this.OilingPanel.SuspendLayout();
            this.OilQuantityPanel.SuspendLayout();
            this.MaintenQtyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(52, 30);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(121, 21);
            this.CustomerList.TabIndex = 1;
            this.CustomerList.Text = "Select Customer";
            this.CustomerList.SelectedIndexChanged += new System.EventHandler(this.CustomerList_SelectedIndexChanged);
            // 
            // VehicleList
            // 
            this.VehicleList.FormattingEnabled = true;
            this.VehicleList.Location = new System.Drawing.Point(422, 30);
            this.VehicleList.Name = "VehicleList";
            this.VehicleList.Size = new System.Drawing.Size(121, 21);
            this.VehicleList.TabIndex = 2;
            this.VehicleList.Text = "Select Vehicle(s)";
            this.VehicleList.SelectedIndexChanged += new System.EventHandler(this.VehicleList_SelectedIndexChanged);
            // 
            // ServicePanel
            // 
            this.ServicePanel.Controls.Add(this.radioButton1);
            this.ServicePanel.Controls.Add(this.MaintenanceRadio);
            this.ServicePanel.Location = new System.Drawing.Point(197, 72);
            this.ServicePanel.Name = "ServicePanel";
            this.ServicePanel.Size = new System.Drawing.Size(200, 38);
            this.ServicePanel.TabIndex = 25;
            this.ServicePanel.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Oiling";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.OilingRadio_CheckedChanged);
            // 
            // MaintenanceRadio
            // 
            this.MaintenanceRadio.AutoSize = true;
            this.MaintenanceRadio.Location = new System.Drawing.Point(110, 12);
            this.MaintenanceRadio.Name = "MaintenanceRadio";
            this.MaintenanceRadio.Size = new System.Drawing.Size(87, 17);
            this.MaintenanceRadio.TabIndex = 22;
            this.MaintenanceRadio.TabStop = true;
            this.MaintenanceRadio.Text = "Maintenance";
            this.MaintenanceRadio.UseVisualStyleBackColor = true;
            this.MaintenanceRadio.CheckedChanged += new System.EventHandler(this.MaintenanceRadio_CheckedChanged);
            // 
            // MaintenancePanel
            // 
            this.MaintenancePanel.Controls.Add(this.MaintenanceComboBox);
            this.MaintenancePanel.Location = new System.Drawing.Point(360, 146);
            this.MaintenancePanel.Name = "MaintenancePanel";
            this.MaintenancePanel.Size = new System.Drawing.Size(200, 54);
            this.MaintenancePanel.TabIndex = 27;
            this.MaintenancePanel.Visible = false;
            // 
            // MaintenanceComboBox
            // 
            this.MaintenanceComboBox.FormattingEnabled = true;
            this.MaintenanceComboBox.Location = new System.Drawing.Point(49, 13);
            this.MaintenanceComboBox.Name = "MaintenanceComboBox";
            this.MaintenanceComboBox.Size = new System.Drawing.Size(121, 21);
            this.MaintenanceComboBox.TabIndex = 2;
            this.MaintenanceComboBox.Text = "Select Maintenance";
            this.MaintenanceComboBox.SelectedIndexChanged += new System.EventHandler(this.MaintenanceComboBox_SelectedIndexChanged);
            // 
            // OilingPanel
            // 
            this.OilingPanel.Controls.Add(this.OilingComboBox);
            this.OilingPanel.Location = new System.Drawing.Point(62, 146);
            this.OilingPanel.Name = "OilingPanel";
            this.OilingPanel.Size = new System.Drawing.Size(200, 54);
            this.OilingPanel.TabIndex = 28;
            this.OilingPanel.Visible = false;
            // 
            // OilingComboBox
            // 
            this.OilingComboBox.FormattingEnabled = true;
            this.OilingComboBox.Location = new System.Drawing.Point(49, 13);
            this.OilingComboBox.Name = "OilingComboBox";
            this.OilingComboBox.Size = new System.Drawing.Size(121, 21);
            this.OilingComboBox.TabIndex = 2;
            this.OilingComboBox.Text = "Select Oiling";
            this.OilingComboBox.SelectedIndexChanged += new System.EventHandler(this.OilingComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Quantity";
            // 
            // OilQtyTextBox
            // 
            this.OilQtyTextBox.Location = new System.Drawing.Point(109, 18);
            this.OilQtyTextBox.Name = "OilQtyTextBox";
            this.OilQtyTextBox.Size = new System.Drawing.Size(70, 20);
            this.OilQtyTextBox.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 34;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OilQuantityPanel
            // 
            this.OilQuantityPanel.Controls.Add(this.label1);
            this.OilQuantityPanel.Controls.Add(this.OilQtyTextBox);
            this.OilQuantityPanel.Controls.Add(this.button1);
            this.OilQuantityPanel.Location = new System.Drawing.Point(62, 206);
            this.OilQuantityPanel.Name = "OilQuantityPanel";
            this.OilQuantityPanel.Size = new System.Drawing.Size(200, 85);
            this.OilQuantityPanel.TabIndex = 35;
            this.OilQuantityPanel.Visible = false;
            // 
            // MaintenQtyPanel
            // 
            this.MaintenQtyPanel.Controls.Add(this.label2);
            this.MaintenQtyPanel.Controls.Add(this.SPQtyTextBox);
            this.MaintenQtyPanel.Controls.Add(this.button2);
            this.MaintenQtyPanel.Location = new System.Drawing.Point(360, 206);
            this.MaintenQtyPanel.Name = "MaintenQtyPanel";
            this.MaintenQtyPanel.Size = new System.Drawing.Size(200, 82);
            this.MaintenQtyPanel.TabIndex = 36;
            this.MaintenQtyPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quantity";
            // 
            // SPQtyTextBox
            // 
            this.SPQtyTextBox.Location = new System.Drawing.Point(109, 18);
            this.SPQtyTextBox.Name = "SPQtyTextBox";
            this.SPQtyTextBox.Size = new System.Drawing.Size(70, 20);
            this.SPQtyTextBox.TabIndex = 30;
            // 
            // NewServiceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.MaintenQtyPanel);
            this.Controls.Add(this.OilQuantityPanel);
            this.Controls.Add(this.OilingPanel);
            this.Controls.Add(this.MaintenancePanel);
            this.Controls.Add(this.ServicePanel);
            this.Controls.Add(this.VehicleList);
            this.Controls.Add(this.CustomerList);
            this.Name = "NewServiceRequest";
            this.Text = "NewServiceRequest";
            this.Load += new System.EventHandler(this.NewServiceRequest_Load);
            this.ServicePanel.ResumeLayout(false);
            this.ServicePanel.PerformLayout();
            this.MaintenancePanel.ResumeLayout(false);
            this.OilingPanel.ResumeLayout(false);
            this.OilQuantityPanel.ResumeLayout(false);
            this.OilQuantityPanel.PerformLayout();
            this.MaintenQtyPanel.ResumeLayout(false);
            this.MaintenQtyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerList;
        private System.Windows.Forms.ComboBox VehicleList;
        private System.Windows.Forms.Panel ServicePanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton MaintenanceRadio;
        private System.Windows.Forms.Panel MaintenancePanel;
        private System.Windows.Forms.ComboBox MaintenanceComboBox;
        private System.Windows.Forms.Panel OilingPanel;
        private System.Windows.Forms.ComboBox OilingComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OilQtyTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel OilQuantityPanel;
        private System.Windows.Forms.Panel MaintenQtyPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SPQtyTextBox;
    }
}