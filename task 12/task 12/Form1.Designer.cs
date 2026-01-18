namespace StudentManagementSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName = new Label();
            lblAge = new Label();
            lblDepartment = new Label();
            lblEmail = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtDepartment = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblAge
            // 
            lblAge.Location = new Point(20, 60);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age";
            // 
            // lblDepartment
            // 
            lblDepartment.Location = new Point(20, 100);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(100, 23);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Department";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 31);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(120, 60);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 31);
            txtAge.TabIndex = 5;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(120, 100);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(100, 31);
            txtDepartment.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 31);
            txtEmail.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(20, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(120, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(220, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(20, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(606, 200);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            ClientSize = new Size(677, 460);
            Controls.Add(lblName);
            Controls.Add(lblAge);
            Controls.Add(lblDepartment);
            Controls.Add(lblEmail);
            Controls.Add(txtName);
            Controls.Add(txtAge);
            Controls.Add(txtDepartment);
            Controls.Add(txtEmail);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Student Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
