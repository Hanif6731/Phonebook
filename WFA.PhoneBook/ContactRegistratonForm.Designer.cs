namespace WFA.PhoneBook
{
    partial class ContactRegistratonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactRegistratonForm));
            this.pnlInformation = new MetroFramework.Controls.MetroPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlAddPhone = new MetroFramework.Controls.MetroPanel();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.btnAddMorePhone = new System.Windows.Forms.Button();
            this.pnlAddMorePhone = new System.Windows.Forms.Panel();
            this.pnlInformation.SuspendLayout();
            this.pnlAddPhone.SuspendLayout();
            this.pnlAddMorePhone.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformation
            // 
            this.pnlInformation.Controls.Add(this.pnlAddMorePhone);
            this.pnlInformation.Controls.Add(this.lblMessage);
            this.pnlInformation.Controls.Add(this.btnBack);
            this.pnlInformation.Controls.Add(this.btnSave);
            this.pnlInformation.Controls.Add(this.pnlAddPhone);
            this.pnlInformation.Controls.Add(this.lblEmail);
            this.pnlInformation.Controls.Add(this.lblPhone);
            this.pnlInformation.Controls.Add(this.lblLastName);
            this.pnlInformation.Controls.Add(this.lblFirstName);
            this.pnlInformation.Controls.Add(this.txtEmail);
            this.pnlInformation.Controls.Add(this.txtPhone1);
            this.pnlInformation.Controls.Add(this.txtLastName);
            this.pnlInformation.Controls.Add(this.txtFirstName);
            this.pnlInformation.Controls.Add(this.btnAddPhone);
            this.pnlInformation.HorizontalScrollbarBarColor = true;
            this.pnlInformation.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlInformation.HorizontalScrollbarSize = 10;
            this.pnlInformation.Location = new System.Drawing.Point(23, 63);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(310, 435);
            this.pnlInformation.TabIndex = 2;
            this.pnlInformation.VerticalScrollbarBarColor = true;
            this.pnlInformation.VerticalScrollbarHighlightOnWheel = false;
            this.pnlInformation.VerticalScrollbarSize = 10;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(4, 253);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(10, 15);
            this.lblMessage.TabIndex = 20;
            this.lblMessage.Text = " ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Purple;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 38);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Purple;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(190, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 38);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pnlAddPhone
            // 
            this.pnlAddPhone.Controls.Add(this.txtPhone2);
            this.pnlAddPhone.HorizontalScrollbarBarColor = true;
            this.pnlAddPhone.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAddPhone.HorizontalScrollbarSize = 10;
            this.pnlAddPhone.Location = new System.Drawing.Point(0, 207);
            this.pnlAddPhone.Name = "pnlAddPhone";
            this.pnlAddPhone.Size = new System.Drawing.Size(307, 43);
            this.pnlAddPhone.TabIndex = 17;
            this.pnlAddPhone.VerticalScrollbarBarColor = true;
            this.pnlAddPhone.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAddPhone.VerticalScrollbarSize = 10;
            this.pnlAddPhone.Visible = false;
            // 
            // txtPhone2
            // 
            this.txtPhone2.BackColor = System.Drawing.Color.White;
            this.txtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtPhone2.ForeColor = System.Drawing.Color.Black;
            this.txtPhone2.Location = new System.Drawing.Point(3, 8);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(252, 26);
            this.txtPhone2.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Purple;
            this.lblEmail.Location = new System.Drawing.Point(4, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 22);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.Purple;
            this.lblPhone.Location = new System.Drawing.Point(6, 146);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 22);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.Purple;
            this.lblLastName.Location = new System.Drawing.Point(162, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 22);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.Purple;
            this.lblFirstName.Location = new System.Drawing.Point(3, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(98, 22);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First name";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(3, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPhone1
            // 
            this.txtPhone1.BackColor = System.Drawing.Color.White;
            this.txtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtPhone1.ForeColor = System.Drawing.Color.Black;
            this.txtPhone1.Location = new System.Drawing.Point(3, 174);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(252, 26);
            this.txtPhone1.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(166, 45);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(141, 26);
            this.txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(3, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(141, 26);
            this.txtFirstName.TabIndex = 9;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.BackColor = System.Drawing.Color.Purple;
            this.btnAddPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPhone.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnAddPhone.FlatAppearance.BorderSize = 2;
            this.btnAddPhone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhone.ForeColor = System.Drawing.Color.White;
            this.btnAddPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPhone.Image")));
            this.btnAddPhone.Location = new System.Drawing.Point(261, 162);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(46, 38);
            this.btnAddPhone.TabIndex = 8;
            this.btnAddPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPhone.UseVisualStyleBackColor = false;
            this.btnAddPhone.Click += new System.EventHandler(this.BtnAddPhone_Click);
            // 
            // btnAddMorePhone
            // 
            this.btnAddMorePhone.BackColor = System.Drawing.Color.Purple;
            this.btnAddMorePhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMorePhone.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnAddMorePhone.FlatAppearance.BorderSize = 2;
            this.btnAddMorePhone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddMorePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMorePhone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMorePhone.ForeColor = System.Drawing.Color.White;
            this.btnAddMorePhone.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMorePhone.Image")));
            this.btnAddMorePhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMorePhone.Location = new System.Drawing.Point(3, 3);
            this.btnAddMorePhone.Name = "btnAddMorePhone";
            this.btnAddMorePhone.Size = new System.Drawing.Size(144, 38);
            this.btnAddMorePhone.TabIndex = 21;
            this.btnAddMorePhone.Text = "Add Phone";
            this.btnAddMorePhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMorePhone.UseVisualStyleBackColor = false;
            this.btnAddMorePhone.Click += new System.EventHandler(this.BtnAddMorePhone_Click);
            // 
            // pnlAddMorePhone
            // 
            this.pnlAddMorePhone.Controls.Add(this.btnAddMorePhone);
            this.pnlAddMorePhone.Location = new System.Drawing.Point(157, 256);
            this.pnlAddMorePhone.Name = "pnlAddMorePhone";
            this.pnlAddMorePhone.Size = new System.Drawing.Size(150, 46);
            this.pnlAddMorePhone.TabIndex = 22;
            this.pnlAddMorePhone.Visible = false;
            // 
            // ContactRegistratonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 521);
            this.Controls.Add(this.pnlInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContactRegistratonForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Contact Registration";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContactRegistratonForm_FormClosed);
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.pnlAddPhone.ResumeLayout(false);
            this.pnlAddPhone.PerformLayout();
            this.pnlAddMorePhone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel pnlInformation;
        private System.Windows.Forms.Button btnAddPhone;
        private MetroFramework.Controls.MetroPanel pnlAddPhone;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddMorePhone;
        private System.Windows.Forms.Panel pnlAddMorePhone;
    }
}