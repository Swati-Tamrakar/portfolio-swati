namespace CustomerMaintainance
{
    partial class frmRetailCustomer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBxCompany = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.btnHomePhone = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Label();
            this.btnLastName = new System.Windows.Forms.Label();
            this.btnFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(320, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 32);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 32);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBxCompany
            // 
            this.txtBxCompany.Location = new System.Drawing.Point(155, 182);
            this.txtBxCompany.Name = "txtBxCompany";
            this.txtBxCompany.Size = new System.Drawing.Size(293, 22);
            this.txtBxCompany.TabIndex = 17;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(155, 132);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(293, 22);
            this.txtBxEmail.TabIndex = 16;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(155, 85);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(293, 22);
            this.txtBxLastName.TabIndex = 15;
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(155, 38);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(293, 22);
            this.txtBxFirstName.TabIndex = 14;
            // 
            // btnHomePhone
            // 
            this.btnHomePhone.AutoSize = true;
            this.btnHomePhone.Location = new System.Drawing.Point(56, 182);
            this.btnHomePhone.Name = "btnHomePhone";
            this.btnHomePhone.Size = new System.Drawing.Size(94, 17);
            this.btnHomePhone.TabIndex = 13;
            this.btnHomePhone.Text = "Home Phone:";
            // 
            // btnEmail
            // 
            this.btnEmail.AutoSize = true;
            this.btnEmail.Location = new System.Drawing.Point(56, 135);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(50, 17);
            this.btnEmail.TabIndex = 12;
            this.btnEmail.Text = "Email: ";
            // 
            // btnLastName
            // 
            this.btnLastName.AutoSize = true;
            this.btnLastName.Location = new System.Drawing.Point(56, 88);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(80, 17);
            this.btnLastName.TabIndex = 11;
            this.btnLastName.Text = "Last Name:";
            // 
            // btnFirstName
            // 
            this.btnFirstName.AutoSize = true;
            this.btnFirstName.Location = new System.Drawing.Point(56, 41);
            this.btnFirstName.Name = "btnFirstName";
            this.btnFirstName.Size = new System.Drawing.Size(76, 17);
            this.btnFirstName.TabIndex = 10;
            this.btnFirstName.Text = "First Name";
            // 
            // frmRetailCustomer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(552, 290);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBxCompany);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.btnHomePhone);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnLastName);
            this.Controls.Add(this.btnFirstName);
            this.Name = "frmRetailCustomer";
            this.Text = "RetailCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBxCompany;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.Label btnHomePhone;
        private System.Windows.Forms.Label btnEmail;
        private System.Windows.Forms.Label btnLastName;
        private System.Windows.Forms.Label btnFirstName;
    }
}