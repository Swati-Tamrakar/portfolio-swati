namespace Midterm_Project
{
    partial class frmUsername
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblSsn = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxBirthDate = new System.Windows.Forms.TextBox();
            this.txtBxSsn = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rchTxtBxAnswer = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(50, 36);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(107, 17);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(48, 73);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(98, 17);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Last Name:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.Location = new System.Drawing.Point(49, 105);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(108, 44);
            this.lblBirthday.TabIndex = 4;
            this.lblBirthday.Text = "Birth Date: (mm/dd/yyyy)";
            // 
            // lblSsn
            // 
            this.lblSsn.AutoSize = true;
            this.lblSsn.Location = new System.Drawing.Point(49, 149);
            this.lblSsn.Name = "lblSsn";
            this.lblSsn.Size = new System.Drawing.Size(44, 17);
            this.lblSsn.TabIndex = 6;
            this.lblSsn.Text = "SSN:";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(163, 33);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(147, 24);
            this.txtBxFirstName.TabIndex = 1;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(163, 70);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(147, 24);
            this.txtBxLastName.TabIndex = 3;
            // 
            // txtBxBirthDate
            // 
            this.txtBxBirthDate.Location = new System.Drawing.Point(163, 105);
            this.txtBxBirthDate.Name = "txtBxBirthDate";
            this.txtBxBirthDate.Size = new System.Drawing.Size(147, 24);
            this.txtBxBirthDate.TabIndex = 5;
            // 
            // txtBxSsn
            // 
            this.txtBxSsn.Location = new System.Drawing.Point(163, 146);
            this.txtBxSsn.Name = "txtBxSsn";
            this.txtBxSsn.Size = new System.Drawing.Size(147, 24);
            this.txtBxSsn.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(481, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 53);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Enter Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(87, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 53);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(284, 209);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(104, 53);
            this.btndisplay.TabIndex = 11;
            this.btndisplay.Text = "&Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(481, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 53);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rchTxtBxAnswer
            // 
            this.rchTxtBxAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.rchTxtBxAnswer.Location = new System.Drawing.Point(12, 293);
            this.rchTxtBxAnswer.Name = "rchTxtBxAnswer";
            this.rchTxtBxAnswer.ReadOnly = true;
            this.rchTxtBxAnswer.Size = new System.Drawing.Size(649, 223);
            this.rchTxtBxAnswer.TabIndex = 13;
            this.rchTxtBxAnswer.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "(###-##-####)";
            // 
            // frmUsername
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(676, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchTxtBxAnswer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxSsn);
            this.Controls.Add(this.txtBxBirthDate);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.lblSsn);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmUsername";
            this.Text = " Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblSsn;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxBirthDate;
        private System.Windows.Forms.TextBox txtBxSsn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rchTxtBxAnswer;
        private System.Windows.Forms.Label label2;
    }
}

