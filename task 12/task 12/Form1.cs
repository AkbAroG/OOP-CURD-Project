using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        string connectionString =
            "Data Source=AKBAROO\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True";

        int selectedStudentId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        // ================= VALIDATION FUNCTION =================
        private bool ValidateInput()
        {
            // Name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter student name");
                txtName.Focus();
                return false;
            }

            // Age
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please enter age");
                txtAge.Focus();
                return false;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Age must be a valid number greater than 0");
                txtAge.Focus();
                return false;
            }

            // Department
            if (string.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                MessageBox.Show("Please enter department");
                txtDepartment.Focus();
                return false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email");
                txtEmail.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtEmail.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter valid email address");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        // ================= INSERT =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "INSERT INTO Students (Name,Age,Department,Email) VALUES (@Name,@Age,@Department,@Email)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Student Saved Successfully");
            LoadStudents();
            ClearFields();
        }

        // ================= UPDATE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student first");
                return;
            }

            if (!ValidateInput())
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Students 
                                 SET Name=@Name, Age=@Age, Department=@Department, Email=@Email
                                 WHERE StudentID=@StudentID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@StudentID", selectedStudentId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Student Updated Successfully");
            LoadStudents();
            ClearFields();
            selectedStudentId = 0;
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student to delete");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Students WHERE StudentID=@StudentID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentID", selectedStudentId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student Deleted Successfully");
                LoadStudents();
                ClearFields();
                selectedStudentId = 0;
            }
        }

        // ================= DISPLAY =================
        private void LoadStudents()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // ================= GRID CLICK =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtAge.Clear();
            txtDepartment.Clear();
            txtEmail.Clear();
        }
    }
}
