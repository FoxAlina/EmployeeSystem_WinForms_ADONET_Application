﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Employees_TestTaskWinFormsApp
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection();
        private const string connectionString = "Server=(local); Database=Employees; User=OpenUser; Password=openuser;";
        private SqlCommand command;

        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGridView(string.Empty);
            SetSelectByPositionComboBoxValues();
        }

        private void ShowErrorMessageBox(string message)
        {
            string caption = "Error";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddNewEmployee();
            RefreshDataGridView(string.Empty);
            SetSelectByPositionComboBoxValues();
            CleanAddEmployeeTextFields();
        }

        private void CleanAddEmployeeTextFields()
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) ||
                !string.IsNullOrEmpty(lastNameTextBox.Text) ||
                !string.IsNullOrEmpty(positionTextBox.Text) ||
                !string.IsNullOrEmpty(yearOfBirthTextBox.Text) ||
                !string.IsNullOrEmpty(salaryTextBox.Text))
            {
                nameTextBox.Text = string.Empty;
                lastNameTextBox.Text = string.Empty;
                positionTextBox.Text = string.Empty;
                yearOfBirthTextBox.Text = string.Empty;
                salaryTextBox.Text = string.Empty;
            }
        }

        private void AddNewEmployee()
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(lastNameTextBox.Text) ||
                string.IsNullOrEmpty(positionTextBox.Text) ||
                string.IsNullOrEmpty(yearOfBirthTextBox.Text) ||
                string.IsNullOrEmpty(salaryTextBox.Text))
            {
                ShowErrorMessageBox("Some fields are empty!");
                return;
            }

            connection.ConnectionString = connectionString;
            command = connection.CreateCommand();

            try
            {
                string query = "Insert into EmployeeInfo values ('"
                    + nameTextBox.Text + "','"
                    + lastNameTextBox.Text + "','"
                    + positionTextBox.Text + "','"
                    + yearOfBirthTextBox.Text + "','"
                    + salaryTextBox.Text + "');";
                command.CommandText = query;
                connection.Open();
                command.ExecuteScalar();

                MessageBox.Show("New employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowErrorMessageBox(ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        private void SetSelectByPositionComboBoxValues()
        {
            connection.ConnectionString = connectionString;
            command = connection.CreateCommand();
            try
            {
                string query = "select * from EmployeeInfo;";
                command.CommandText = query;

                connection.Open();

                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable globalDataTable = new DataTable();
                globalDataTable.Load(sqlDataReader);

                selectByPositionComboBox.DisplayMember = "Position";
                selectByPositionComboBox.ValueMember = "ID";
                globalDataTable.DefaultView.Sort = "Position";
                selectByPositionComboBox.DataSource = globalDataTable.DefaultView.ToTable(true, "Position");

                sqlDataReader.Close();
            }
            catch (Exception exception)
            {
                ShowErrorMessageBox(exception.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        private void RefreshDataGridView(string query)
        {
            connection.ConnectionString = connectionString;
            command = connection.CreateCommand();
            try
            {
                if (string.IsNullOrEmpty(query))
                    query = "select * from EmployeeInfo;";

                command.CommandText = query;

                connection.Open();

                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable globalDataTable = new DataTable();
                globalDataTable.Load(sqlDataReader);
                dataGridView.DataSource = globalDataTable;

                this.dataTable = globalDataTable;

                sqlDataReader.Close();
            }
            catch (Exception exception)
            {
                ShowErrorMessageBox(exception.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            SelectEmployeeRow();
        }

        private void SelectEmployeeRow()
        {
            string employeeName = employeeNameFindTextBox.Text;
            string employeeLastName = employeeLastNameFindTextBox.Text;

            if (string.IsNullOrEmpty(employeeName) ||
                string.IsNullOrEmpty(employeeLastName))
            {
                ShowErrorMessageBox("Some fields are empty!");
                return;
            }

            dataGridView.ClearSelection();
            try
            {
                int rowIndex = dataGridView.Rows.Cast<DataGridViewRow>()
                    .Where(r =>
                    {
                        return r.Cells["Name"].Value.ToString().Equals(employeeName)
                        && r.Cells["LastName"].Value.ToString().Equals(employeeLastName);
                    })
                    .Select(r => r.Index)
                    .DefaultIfEmpty(-1)
                    .First();

                if (rowIndex == -1)
                {
                    MessageBox.Show("No matches.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridView.Rows[rowIndex].Selected = true;
                }
            }
            catch (Exception exception)
            {
                ShowErrorMessageBox(exception.Message);
            }
            finally
            {
                CleanFindEmployeeFields();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (DeleteSelectedEmployees())
                MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshDataGridView(string.Empty);
        }

        private void CleanFindEmployeeFields()
        {
            if (!string.IsNullOrEmpty(employeeNameFindTextBox.Text) ||
                !string.IsNullOrEmpty(employeeLastNameFindTextBox.Text))
            {
                employeeNameFindTextBox.Text = string.Empty;
                employeeLastNameFindTextBox.Text = string.Empty;
            }
        }

        private bool DeleteSelectedEmployees()
        {
            bool result = true;

            var selectedRows = dataGridView.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("No rows selected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }

            int employeeID;
            for (int i = 0; i < selectedRows.Count; i++)
            {
                employeeID = Convert.ToInt32(selectedRows[i].Cells[0].Value);
                result &= DeleteEmployee(employeeID);
            }

            return result;
        }

        private bool DeleteEmployee(int employeeID)
        {
            bool result = false;

            connection.ConnectionString = connectionString;
            command = connection.CreateCommand();

            try
            {
                //string query = "Delete from EmployeeInfo where Name='" + employeeName + "'and LastName='" + employeeLastName + "';";
                string query = "Delete from EmployeeInfo where ID=" + employeeID + ";";
                command.CommandText = query;
                connection.Open();
                command.ExecuteScalar();

                result = true;
            }
            catch (Exception exception)
            {
                ShowErrorMessageBox(exception.Message);

                result = false;
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }

            return result;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView(string.Empty);
            var selectedRow = selectByPositionComboBox.SelectedItem;
            if (selectedRow is DataRowView row)
            {
                //int employeeID = Convert.ToInt32(row.Row["ID"]);
                //string employeePosition = FindEmployee(employeeID);

                string employeePosition = Convert.ToString(row.Row["Position"]);
                if (!string.IsNullOrEmpty(employeePosition))
                {
                    string query = "select * from EmployeeInfo where Position='" + employeePosition + "';";
                    RefreshDataGridView(query);
                }
            }
        }

        private string FindEmployee(int id)
        {
            DataRow[] employees = this.dataTable.Select("ID = " + id);
            if (employees.Length == 1)
            {
                return Convert.ToString(employees[0]["Position"]);
            }
            return string.Empty;
        }

        private void showDBButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView(string.Empty);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Form2 averageSalaryForm = new Form2();
            averageSalaryForm.Show();
        }
    }
}