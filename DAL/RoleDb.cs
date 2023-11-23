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
    public class RoleDb
    {
        public const string SELLECT_ALL = @"SELECT Id, Title
                                            FROM Roles";
        public const string SELLECT_BY_ID = @"SELECT Id, Title
                                              FROM Roles
                                              WHERE Id = @Id";
        public const string SELLECT_BY_FILTER = @"SELECT Id, Title
                                                  FROM Roles
                                                  WHERE Title LIKE '%' + @Text + '%'";
        public const string UPDATE = @"UPDATE Roles SET Title = @Title
                                       WHERE Id = @Id";
        public const string INSERT = @"INSERT INTO Roles (Title)
                                       OUTPUT INSERTED.Id
                                       VALUES (@Title)";

        public List<Role> GetAll()
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var selectCommand = new SqlCommand();
            selectCommand.Connection = sqlConnection;
            selectCommand.CommandText = SELLECT_ALL;
            try
            {
                var reader = selectCommand.ExecuteReader();
                var roles = new List<Role>();
                while(reader.Read())
                {
                    var role = Materialize(reader);
                    roles.Add(role);
                }
                reader.Close();

                return roles;
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

        // Create an instance of the Role entity
        // Populate each role property with data comming from the database
        private static Role Materialize(SqlDataReader reader)
        {
            var role = new Role();
            role.Id = reader.GetInt32(0);
            role.Title = reader.GetString(1);
            return role;
        }

        public Role GetById(int roleId)
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var selectCommand = new SqlCommand();
            selectCommand.Connection = sqlConnection;
            selectCommand.CommandText = SELLECT_BY_ID;
            var idSqlParameter = new SqlParameter();
            idSqlParameter.ParameterName = "@Id";
            idSqlParameter.Value = roleId;
            selectCommand.Parameters.Add(idSqlParameter);
            try
            {
                var reader = selectCommand.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }
                var role = Materialize(reader);
                reader.Close();

                return role;
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

        public List<Role> GetRolesByFilter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return new List<Role>();
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
                var roles = new List<Role>();
                while (reader.Read())
                {
                    var role = Materialize(reader);
                    roles.Add(role);
                }
                reader.Close();

                return roles;
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

        public void Save(Role role)
        {
            if (role == null)
            {
                return;
            }
            if (!Exists(role))
            {
                Insert(role);
                return;
            }
            Update(role);
        }

        private void Update(Role role)
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var updateCommand = new SqlCommand();
            updateCommand.CommandText = UPDATE;
            updateCommand.Connection = sqlConnection;

            var idSqlParameter = new SqlParameter();
            idSqlParameter.ParameterName = "@Id";
            idSqlParameter.Value = role.Id;
            updateCommand.Parameters.Add(idSqlParameter);

            var titleSqlParameter = new SqlParameter();
            titleSqlParameter.ParameterName = "@Title";
            titleSqlParameter.Value = role.Title;
            updateCommand.Parameters.Add(titleSqlParameter);

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

        private void Insert(Role role)
        {
            var sqlConnection = UtilityDb.OpenConnection();
            var insertCommand = new SqlCommand();
            insertCommand.CommandText = INSERT;
            insertCommand.Connection = sqlConnection;

            var titleSqlParameter = new SqlParameter();
            titleSqlParameter.ParameterName = "@Title";
            titleSqlParameter.Value = role.Title;
            insertCommand.Parameters.Add(titleSqlParameter);

            var transaction = sqlConnection.BeginTransaction();
            insertCommand.Transaction = transaction;
            try
            {
                role.Id = (int)insertCommand.ExecuteScalar();
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

        private bool Exists(Role role)
        {
            if (role.Id > 0)
            {
                return true;
            }
            return false;
        }
    }
}
