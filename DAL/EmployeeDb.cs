using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HiTechDistributionInc.DAL
{
    // Database Programming with ADO.NET in Connected Mode
    public class EmployeeDb
    {
        public const string SELLECT_ALL = @"SELECT Id, FirstName, LastName, PhoneNumber, Email
                                            FROM Employees";
        public const string SELLECT_BY_ID = @"SELECT Id, FirstName, LastName, PhoneNumber, Email
                                              FROM Employees
                                              WHERE Id = @Id";
        public const string SELLECT_BY_FILTER = @"SELECT Id, FirstName, LastName, PhoneNumber, Email
                                                  FROM Employees
                                                  WHERE FirstName + ' ' + LastName LIKE '%' + @Text + '%'";
        public const string UPDATE = @"UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email
                                       WHERE Id = @Id";
        public const string INSERT = @"INSERT INTO Employees (FirstName, LastName, PhoneNumber, Email)
                                       OUTPUT INSERTED.Id
                                       VALUES (@FirstName, @LastName, @PhoneNumber, @Email)";

        public List<Employee> GetAll()
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var selectCommand = new SqlCommand();
            selectCommand.Connection = sqlConnection;
            selectCommand.CommandText = SELLECT_ALL;
            try
            {
                var reader = selectCommand.ExecuteReader();
                var employees = new List<Employee>();
                while (reader.Read())
                {
                    var employee = Materialize(reader);
                    employees.Add(employee);
                }
                reader.Close();

                return employees;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        // Create an instance of the Employee entity
        // Populate each employee property with data comming from the database
        private static Employee Materialize(SqlDataReader reader)
        {
            var employee = new Employee();
            employee.Id = reader.GetInt32(0);
            employee.FirstName = reader.GetString(1);
            employee.LastName = reader.GetString(2);
            employee.PhoneNumber = reader.GetString(3);
            employee.Email = reader.GetString(4);
            return employee;
        }

        public Employee GetById(int employeeId)
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var selectCommand = new SqlCommand();
            selectCommand.Connection = sqlConnection;
            selectCommand.CommandText = SELLECT_BY_ID;
            var idSqlParameter = new SqlParameter();
            idSqlParameter.ParameterName = "@Id";
            idSqlParameter.Value = employeeId;
            selectCommand.Parameters.Add(idSqlParameter);
            try
            {
                var reader = selectCommand.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }
                var employee = Materialize(reader);
                reader.Close();

                return employee;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<Employee> GetEmployeesByFilter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return new List<Employee>();
            }

            var sqlConnection = UtilityDb.OpenConnection();
            var selectCommand = new SqlCommand();
            selectCommand.Connection = sqlConnection;
            selectCommand.CommandText = SELLECT_BY_FILTER;
            var textSqlParameter = new SqlParameter();
            textSqlParameter.ParameterName = "@Text";
            textSqlParameter.Value = text;
            selectCommand.Parameters.Add(textSqlParameter);
            try
            {
                var reader = selectCommand.ExecuteReader();
                var employees = new List<Employee>();
                while (reader.Read())
                {
                    var employee = Materialize(reader);
                    employees.Add(employee);
                }
                reader.Close();

                return employees;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void Save(Employee employee)
        {
            if (employee == null)
            {
                return;
            }
            if (!Exists(employee))
            {
                Insert(employee);
                return;
            }
            Update(employee);
        }

        private void Update(Employee employee)
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var updateCommand = new SqlCommand();
            updateCommand.CommandText = UPDATE;
            updateCommand.Connection = sqlConnection;

            var idSqlParameter = new SqlParameter();
            idSqlParameter.ParameterName = "@Id";
            idSqlParameter.Value = employee.Id;
            updateCommand.Parameters.Add(idSqlParameter);

            var firstNameSqlParameter = new SqlParameter();
            firstNameSqlParameter.ParameterName = "@FirstName";
            firstNameSqlParameter.Value = employee.FirstName;
            updateCommand.Parameters.Add(firstNameSqlParameter);

            var lastNameSqlParameter = new SqlParameter();
            lastNameSqlParameter.ParameterName = "@LastName";
            lastNameSqlParameter.Value = employee.LastName;
            updateCommand.Parameters.Add(lastNameSqlParameter);

            var phoneNumberSqlParameter = new SqlParameter();
            phoneNumberSqlParameter.ParameterName = "@PhoneNumber";
            phoneNumberSqlParameter.Value = employee.PhoneNumber;
            updateCommand.Parameters.Add(phoneNumberSqlParameter);

            var emailSqlParameter = new SqlParameter();
            emailSqlParameter.ParameterName = "@Email";
            emailSqlParameter.Value = employee.Email;
            updateCommand.Parameters.Add(emailSqlParameter);

            var transaction = sqlConnection.BeginTransaction();
            updateCommand.Transaction = transaction;
            try
            {
                updateCommand.ExecuteNonQuery();
                transaction.Commit();
            }
            catch(Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void Insert(Employee employee)
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var insertCommand = new SqlCommand();
            insertCommand.CommandText = INSERT;
            insertCommand.Connection = sqlConnection;

            var firstNameSqlParameter = new SqlParameter();
            firstNameSqlParameter.ParameterName = "@FirstName";
            firstNameSqlParameter.Value = employee.FirstName;
            insertCommand.Parameters.Add(firstNameSqlParameter);

            var lastNameSqlParameter = new SqlParameter();
            lastNameSqlParameter.ParameterName = "@LastName";
            lastNameSqlParameter.Value = employee.LastName;
            insertCommand.Parameters.Add(lastNameSqlParameter);

            var phoneNumberSqlParameter = new SqlParameter();
            phoneNumberSqlParameter.ParameterName = "@PhoneNumber";
            phoneNumberSqlParameter.Value = employee.PhoneNumber;
            insertCommand.Parameters.Add(phoneNumberSqlParameter);

            var emailSqlParameter = new SqlParameter();
            emailSqlParameter.ParameterName = "@Email";
            emailSqlParameter.Value = employee.Email;
            insertCommand.Parameters.Add(emailSqlParameter);

            var transaction = sqlConnection.BeginTransaction();
            insertCommand.Transaction = transaction;
            try
            {
                employee.Id = (int)insertCommand.ExecuteScalar();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private bool Exists(Employee employee)
        {
            if (employee.Id > 0)
            {
                return true;
            }
            return false;
        }
    }
}