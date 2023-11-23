using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.DAL
{
    // Database Programming with ADO.NET in Connected Mode
    public class UserAccountDb
    {
        public const string SELECT_ALL = @"SELECT Id, Username, Password, Employee_Id, Role_Id
                                           FROM UserAccounts";
        public const string SELECT_BY_ID = @"SELECT Id, Username, Password, Employee_Id, Role_Id
                                             FROM UserAccounts
                                             WHERE Id = @Id";
        public const string SELECT_BY_USERNAME = @"SELECT Id, Username, Password, Employee_Id, Role_Id
                                                   FROM UserAccounts
                                                   WHERE Username = @UserName";
        public const string SELLECT_BY_FILTER = @"SELECT Id, Username, Password, Employee_Id, Role_Id
                                                  FROM UserAccounts
                                                  WHERE Username LIKE '%' + @Text + '%'";
        public const string UPDATE = @"UPDATE UserAccounts SET Username = @Username, Password = @Password, Employee_Id = @Employee_Id, Role_Id = @Role_Id
                                       WHERE Id = @Id";
        public const string INSERT = @"INSERT INTO UserAccounts (Username, Password, Employee_Id, Role_Id)
                                       OUTPUT INSERTED.Id
                                       VALUES (@Username, @Password, @Employee_Id, @Role_Id)";

        public List<UserAccount> GetAll()
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var selectCommand = new SqlCommand();
            selectCommand.Connection = sqlConnection;
            selectCommand.CommandText = SELECT_ALL;
            try
            {
                var reader = selectCommand.ExecuteReader();
                var userAccounts = new List<UserAccount>();
                while (reader.Read())
                {
                    var userAccount = Materialize(reader);
                    userAccounts.Add(userAccount);
                }
                reader.Close();

                return userAccounts;
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

        // Create an instance of the UserAccount entity
        // Populate each user account property with data comming from the database
        private UserAccount Materialize(SqlDataReader reader)
        {
            var userAccount = new UserAccount();
            userAccount.Id = reader.GetInt32(0);
            userAccount.Username = reader.GetString(1);
            userAccount.Password = reader.GetString(2);

            // UserAccount.Employee
            var employeeId = reader.GetInt32(3);
            var employeeDb = new EmployeeDb();
            userAccount.Employee = employeeDb.GetById(employeeId);

            //UserAccount.Role
            var roleId = reader.GetInt32(4);
            var roleDb = new RoleDb();
            userAccount.Role = roleDb.GetById(roleId);
            return userAccount;
        }

        public UserAccount GetById(int userAccountId)
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var selectCommand = new SqlCommand();
            selectCommand.Connection = sqlConnection;
            selectCommand.CommandText = SELECT_BY_ID;
            var idSqlParameter = new SqlParameter();
            idSqlParameter.ParameterName = "@Id";
            idSqlParameter.Value = userAccountId;
            selectCommand.Parameters.Add(idSqlParameter);
            try
            {
                var reader = selectCommand.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }
                var userAccount = Materialize(reader);
                reader.Close();

                return userAccount;
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

        public UserAccount GetByUserName(string username)
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var selectCommand = new SqlCommand();
            selectCommand.Connection = sqlConnection;
            selectCommand.CommandText = SELECT_BY_USERNAME;
            var usernameSqlParameter = new SqlParameter();
            usernameSqlParameter.ParameterName = "@Username";
            usernameSqlParameter.Value = username;
            selectCommand.Parameters.Add(usernameSqlParameter);
            try
            {
                var reader = selectCommand.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }
                var userAccount = Materialize(reader);
                reader.Close();

                return userAccount;
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

        public List<UserAccount> GetUserAccountsByFilter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return new List<UserAccount>();
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
                var userAccounts = new List<UserAccount>();
                while (reader.Read())
                {
                    var userAccount = Materialize(reader);
                    userAccounts.Add(userAccount);
                }
                reader.Close();

                return userAccounts;
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

        public void Save(UserAccount userAccount)
        {
            if (userAccount == null)
            {
                return;
            }
            if (!Exists(userAccount))
            {
                Insert(userAccount);
                return;
            }
            Update(userAccount);
        }

        private void Update(UserAccount userAccount)
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var updateCommand = new SqlCommand();
            updateCommand.CommandText = UPDATE;
            updateCommand.Connection = sqlConnection;

            var idSqlParameter = new SqlParameter();
            idSqlParameter.ParameterName = "@Id";
            idSqlParameter.Value = userAccount.Id;
            updateCommand.Parameters.Add(idSqlParameter);

            var usernameSqlParameter = new SqlParameter();
            usernameSqlParameter.ParameterName = "@Username";
            usernameSqlParameter.Value = userAccount.Username;
            updateCommand.Parameters.Add(usernameSqlParameter);

            var passwordSqlParameter = new SqlParameter();
            passwordSqlParameter.ParameterName = "@Password";
            passwordSqlParameter.Value = userAccount.Password;
            updateCommand.Parameters.Add(passwordSqlParameter);

            var employeeIdSqlParameter = new SqlParameter();
            employeeIdSqlParameter.ParameterName = "@Employee_Id";
            employeeIdSqlParameter.Value = userAccount.Employee.Id;
            updateCommand.Parameters.Add(employeeIdSqlParameter);

            var roleIdSqlParameter = new SqlParameter();
            roleIdSqlParameter.ParameterName = "@Role_Id";
            roleIdSqlParameter.Value = userAccount.Role.Id;
            updateCommand.Parameters.Add(roleIdSqlParameter);

            var transaction = sqlConnection.BeginTransaction();
            updateCommand.Transaction = transaction;
            try
            {
                updateCommand.ExecuteNonQuery();
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

        private void Insert(UserAccount userAccount)
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var insertCommand = new SqlCommand();
            insertCommand.CommandText = INSERT;
            insertCommand.Connection = sqlConnection;

            var usernameSqlParameter = new SqlParameter();
            usernameSqlParameter.ParameterName = "@Username";
            usernameSqlParameter.Value = userAccount.Username;
            insertCommand.Parameters.Add(usernameSqlParameter);

            var passwordSqlParameter = new SqlParameter();
            passwordSqlParameter.ParameterName = "@Password";
            passwordSqlParameter.Value = userAccount.Password;
            insertCommand.Parameters.Add(passwordSqlParameter);

            var employeeIdSqlParameter = new SqlParameter();
            employeeIdSqlParameter.ParameterName = "@Employee_Id";
            employeeIdSqlParameter.Value = userAccount.Employee.Id;
            insertCommand.Parameters.Add(employeeIdSqlParameter);

            var roleIdSqlParameter = new SqlParameter();
            roleIdSqlParameter.ParameterName = "@Role_Id";
            roleIdSqlParameter.Value = userAccount.Role.Id;
            insertCommand.Parameters.Add(roleIdSqlParameter);

            var transaction = sqlConnection.BeginTransaction();
            insertCommand.Transaction = transaction;
            try
            {
                userAccount.Id = (int)insertCommand.ExecuteScalar();
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

        private bool Exists(UserAccount userAccount)
        {
            if (userAccount.Id > 0)
            {
                return true;
            }
            return false;
        }
    }
}
