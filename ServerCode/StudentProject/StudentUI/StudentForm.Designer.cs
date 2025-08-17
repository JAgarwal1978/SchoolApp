
namespace StudentUI
{
    partial class StudentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudent = new DataGridView();
            lblStudentList = new Label();
            cmbGender = new ComboBox();
            cmbCity = new ComboBox();
            lblCity = new Label();
            lblGender = new Label();
            btnAddStudent = new Button();
            txtStudentID = new TextBox();
            lblStudentId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(13, 165);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.Size = new Size(1041, 369);
            dgvStudent.TabIndex = 0;
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.Location = new Point(12, 147);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(69, 15);
            lblStudentList.TabIndex = 1;
            lblStudentList.Text = "Student List";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(78, 21);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(181, 23);
            cmbGender.TabIndex = 2;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(78, 66);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(181, 23);
            cmbCity.TabIndex = 3;
            cmbCity.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(13, 69);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 4;
            lblCity.Text = "City";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(13, 21);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(279, 108);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(139, 23);
            btnAddStudent.TabIndex = 6;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(78, 105);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(181, 23);
            txtStudentID.TabIndex = 7;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(13, 108);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(59, 15);
            lblStudentId.TabIndex = 8;
            lblStudentId.Text = "StudentID";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 528);
            Controls.Add(lblStudentId);
            Controls.Add(txtStudentID);
            Controls.Add(btnAddStudent);
            Controls.Add(lblGender);
            Controls.Add(lblCity);
            Controls.Add(cmbCity);
            Controls.Add(cmbGender);
            Controls.Add(lblStudentList);
            Controls.Add(dgvStudent);
            Name = "StudentForm";
            Text = "Student Information";
            Load += StudentForm_Load;
            Click += myclick;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }



        #endregion

        private DataGridView dgvStudent;
        private Label lblStudentList;
        private ComboBox cmbGender;
        private ComboBox cmbCity;
        private Label lblCity;
        private Label lblGender;
        private Button btnAddStudent;
        private TextBox txtStudentID;
        private Label lblStudentId;
    }
}
