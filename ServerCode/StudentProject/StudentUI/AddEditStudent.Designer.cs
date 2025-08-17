namespace StudentUI
{
    partial class AddEditStudent
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
            lblFname = new Label();
            txtFname = new TextBox();
            lblLname = new Label();
            lblDOB = new Label();
            txtLname = new TextBox();
            txtEmail = new TextBox();
            dtpDOB = new DateTimePicker();
            lblgender = new Label();
            cmbGender = new ComboBox();
            lblEmail = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            btnSave = new Button();
            lblStudentID = new Label();
            txtStudentID = new TextBox();
            lblCity = new Label();
            cmbStudentID = new CheckBox();
            cmbCity = new ComboBox();
            SuspendLayout();
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Location = new Point(45, 109);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(64, 15);
            lblFname.TabIndex = 0;
            lblFname.Text = "First Name";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(153, 109);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(240, 23);
            txtFname.TabIndex = 1;
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Location = new Point(42, 153);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(63, 15);
            lblLname.TabIndex = 2;
            lblLname.Text = "Last Name";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(45, 205);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(75, 15);
            lblDOB.TabIndex = 3;
            lblDOB.Text = "Date Of Birth";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(153, 153);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(240, 23);
            txtLname.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(153, 282);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 23);
            txtEmail.TabIndex = 5;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(153, 205);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 23);
            dtpDOB.TabIndex = 6;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Location = new Point(45, 252);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(45, 15);
            lblgender.TabIndex = 7;
            lblgender.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "F", "M" });
            cmbGender.Location = new Point(153, 249);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 8;
            cmbGender.Text = "F";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(45, 290);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(45, 331);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(153, 328);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 23);
            txtPhone.TabIndex = 11;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(42, 373);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(153, 357);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(251, 56);
            txtAddress.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(35, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(43, 71);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(59, 15);
            lblStudentID.TabIndex = 15;
            lblStudentID.Text = "StudentID";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(153, 71);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(121, 23);
            txtStudentID.TabIndex = 16;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(409, 79);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 17;
            lblCity.Text = "City";
            // 
            // cmbStudentID
            // 
            cmbStudentID.AutoSize = true;
            cmbStudentID.Location = new Point(303, 75);
            cmbStudentID.Name = "cmbStudentID";
            cmbStudentID.Size = new Size(78, 19);
            cmbStudentID.TabIndex = 18;
            cmbStudentID.Text = "StudentID";
            cmbStudentID.UseVisualStyleBackColor = true;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(455, 75);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(181, 23);
            cmbCity.TabIndex = 19;
           
            // 
            // AddEditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCity);
            Controls.Add(cmbStudentID);
            Controls.Add(lblCity);
            Controls.Add(txtStudentID);
            Controls.Add(lblStudentID);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(cmbGender);
            Controls.Add(lblgender);
            Controls.Add(dtpDOB);
            Controls.Add(txtEmail);
            Controls.Add(txtLname);
            Controls.Add(lblDOB);
            Controls.Add(lblLname);
            Controls.Add(txtFname);
            Controls.Add(lblFname);
            Name = "AddEditStudent";
            Text = "AddEditStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFname;
        private TextBox txtFname;
        private Label lblLname;
        private Label lblDOB;
        private TextBox txtLname;
        private TextBox txtEmail;
        private DateTimePicker dtpDOB;
        private Label lblgender;
        private ComboBox cmbGender;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private Button btnSave;
        private Label lblStudentID;
        private TextBox txtStudentID;
        private Label lblCity;
        private CheckBox cmbStudentID;
        private ComboBox cmbCity;
    }
}