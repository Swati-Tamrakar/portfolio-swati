namespace CustomerMaintainance
{
    partial class frmCustomerMaintenance
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
            this.lstBxCustomerMaintenance = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddWholesale = new System.Windows.Forms.Button();
            this.btnAddRetail = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxCustomerMaintenance
            // 
            this.lstBxCustomerMaintenance.FormattingEnabled = true;
            this.lstBxCustomerMaintenance.ItemHeight = 16;
            this.lstBxCustomerMaintenance.Location = new System.Drawing.Point(31, 62);
            this.lstBxCustomerMaintenance.Name = "lstBxCustomerMaintenance";
            this.lstBxCustomerMaintenance.Size = new System.Drawing.Size(469, 196);
            this.lstBxCustomerMaintenance.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customers:";
            // 
            // btnAddWholesale
            // 
            this.btnAddWholesale.Location = new System.Drawing.Point(599, 62);
            this.btnAddWholesale.Name = "btnAddWholesale";
            this.btnAddWholesale.Size = new System.Drawing.Size(152, 31);
            this.btnAddWholesale.TabIndex = 1;
            this.btnAddWholesale.Text = "Add &Wholesale";
            this.btnAddWholesale.UseVisualStyleBackColor = true;
            this.btnAddWholesale.Click += new System.EventHandler(this.btnAddWholesale_Click);
            // 
            // btnAddRetail
            // 
            this.btnAddRetail.Location = new System.Drawing.Point(599, 117);
            this.btnAddRetail.Name = "btnAddRetail";
            this.btnAddRetail.Size = new System.Drawing.Size(152, 31);
            this.btnAddRetail.TabIndex = 2;
            this.btnAddRetail.Text = "Add &Retail";
            this.btnAddRetail.UseVisualStyleBackColor = true;
            this.btnAddRetail.Click += new System.EventHandler(this.btnAddRetail_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(599, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(599, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCustomerMaintenance
            // 
            this.AcceptButton = this.btnAddRetail;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 317);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddRetail);
            this.Controls.Add(this.btnAddWholesale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxCustomerMaintenance);
            this.Name = "frmCustomerMaintenance";
            this.Text = "Customer Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxCustomerMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddWholesale;
        private System.Windows.Forms.Button btnAddRetail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}

