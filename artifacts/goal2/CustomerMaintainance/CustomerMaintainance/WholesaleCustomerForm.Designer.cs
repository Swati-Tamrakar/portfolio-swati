namespace CustomerMaintainance
{
    partial class frmWholesaleCustomer
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
            this.btnFirstName = new System.Windows.Forms.Label();
            this.btnLastName = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Label();
            this.btnCompany = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxCompany = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirstName
            // 
            this.btnFirstName.AutoSize = true;
            this.btnFirstName.Location = new System.Drawing.Point(40, 29);
            this.btnFirstName.Name = "btnFirstName";
            this.btnFirstName.Size = new System.Drawing.Size(76, 17);
            this.btnFirstName.TabIndex = 0;
            this.btnFirstName.Text = "First Name";
            // 
            // btnLastName
            // 
            this.btnLastName.AutoSize = true;
            this.btnLastName.Location = new System.Drawing.Point(40, 76);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(80, 17);
            this.btnLastName.TabIndex = 1;
            this.btnLastName.Text = "Last Name:";
            // 
            // btnEmail
            // 
            this.btnEmail.AutoSize = true;
            this.btnEmail.Location = new System.Drawing.Point(40, 123);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(50, 17);
            this.btnEmail.TabIndex = 2;
            this.btnEmail.Text = "Email: ";
            // 
            // btnCompany
            // 
            this.btnCompany.AutoSize = true;
            this.btnCompany.Location = new System.Drawing.Point(40, 170);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(71, 17);
            this.btnCompany.TabIndex = 3;
            this.btnCompany.Text = "Company:";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(139, 26);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(293, 22);
            this.txtBxFirstName.TabIndex = 4;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(139, 73);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(293, 22);
            this.txtBxLastName.TabIndex = 5;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(139, 120);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(293, 22);
            this.txtBxEmail.TabIndex = 6;
            // 
            // txtBxCompany
            // 
            this.txtBxCompany.Location = new System.Drawing.Point(139, 170);
            this.txtBxCompany.Name = "txtBxCompany";
            this.txtBxCompany.Size = new System.Drawing.Size(293, 22);
            this.txtBxCompany.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(280, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmWholesaleCustomer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(502, 296);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBxCompany);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnLastName);
            this.Controls.Add(this.btnFirstName);
            this.Name = "frmWholesaleCustomer";
            this.Text = "WholesaleCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnFirstName;
        private System.Windows.Forms.Label btnLastName;
        private System.Windows.Forms.Label btnEmail;
        private System.Windows.Forms.Label btnCompany;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxCompany;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}