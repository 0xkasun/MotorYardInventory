namespace Motor_Yard
{
    partial class Reports
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
            this.tabControl_Reports = new System.Windows.Forms.TabControl();
            this.tabPageSales_Reports = new System.Windows.Forms.TabPage();
            this.tabPage_TotalIncome_Reports = new System.Windows.Forms.TabPage();
            this.tabPage_TaxesPayable_Reports = new System.Windows.Forms.TabPage();
            this.tabControl_Reports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Reports
            // 
            this.tabControl_Reports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Reports.Controls.Add(this.tabPageSales_Reports);
            this.tabControl_Reports.Controls.Add(this.tabPage_TotalIncome_Reports);
            this.tabControl_Reports.Controls.Add(this.tabPage_TaxesPayable_Reports);
            this.tabControl_Reports.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Reports.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Reports.Name = "tabControl_Reports";
            this.tabControl_Reports.SelectedIndex = 0;
            this.tabControl_Reports.Size = new System.Drawing.Size(576, 381);
            this.tabControl_Reports.TabIndex = 0;
            // 
            // tabPageSales_Reports
            // 
            this.tabPageSales_Reports.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSales_Reports.Location = new System.Drawing.Point(4, 24);
            this.tabPageSales_Reports.Name = "tabPageSales_Reports";
            this.tabPageSales_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales_Reports.Size = new System.Drawing.Size(568, 353);
            this.tabPageSales_Reports.TabIndex = 0;
            this.tabPageSales_Reports.Text = "Sales";
            // 
            // tabPage_TotalIncome_Reports
            // 
            this.tabPage_TotalIncome_Reports.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_TotalIncome_Reports.Location = new System.Drawing.Point(4, 24);
            this.tabPage_TotalIncome_Reports.Name = "tabPage_TotalIncome_Reports";
            this.tabPage_TotalIncome_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TotalIncome_Reports.Size = new System.Drawing.Size(568, 353);
            this.tabPage_TotalIncome_Reports.TabIndex = 1;
            this.tabPage_TotalIncome_Reports.Text = "Total Income";
            // 
            // tabPage_TaxesPayable_Reports
            // 
            this.tabPage_TaxesPayable_Reports.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_TaxesPayable_Reports.Location = new System.Drawing.Point(4, 24);
            this.tabPage_TaxesPayable_Reports.Name = "tabPage_TaxesPayable_Reports";
            this.tabPage_TaxesPayable_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TaxesPayable_Reports.Size = new System.Drawing.Size(568, 353);
            this.tabPage_TaxesPayable_Reports.TabIndex = 2;
            this.tabPage_TaxesPayable_Reports.Text = "Taxes Payable";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 381);
            this.Controls.Add(this.tabControl_Reports);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Control System - Reports";
            this.tabControl_Reports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Reports;
        private System.Windows.Forms.TabPage tabPageSales_Reports;
        private System.Windows.Forms.TabPage tabPage_TotalIncome_Reports;
        private System.Windows.Forms.TabPage tabPage_TaxesPayable_Reports;
    }
}