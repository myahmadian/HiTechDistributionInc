using HiTechDistributionInc.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechDistributionInc.DAL
{
    public class CustomerDbSet
    {
        public const string AGGREGATE_NAME = "CustomerAggregate";
        public const string CUSTOMER_TABLE_NAME = "Customers";
        public const string CUSTOMER_SELECT = "SELECT * FROM Customers";

        private DataTable _customerDataTable;
        private DataSet _dataSet;
        private SqlDataAdapter _dataAdapter;

        public CustomerDbSet()
        {
            _customerDataTable = GetCustomerDataTable();
            _dataSet = GetDataSet();
            _dataSet.Tables.Add(_customerDataTable);
            _dataAdapter = GetDataAdapter();
            Refresh();
        }

        private DataTable GetCustomerDataTable()
        {
            var customerTable = new DataTable();
            customerTable.TableName = CUSTOMER_TABLE_NAME;

            var idColumn = new DataColumn();
            idColumn.ColumnName = nameof(Customer.Id);
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 1;
            customerTable.Columns.Add(idColumn);

            var nameColumn = new DataColumn();
            nameColumn.ColumnName = nameof(Customer.Name);
            customerTable.Columns.Add(nameColumn);

            var streetAddressColumn = new DataColumn();
            streetAddressColumn.ColumnName = nameof(Customer.Address);
            customerTable.Columns.Add(streetAddressColumn);

            var cityColumn = new DataColumn();
            cityColumn.ColumnName = nameof(Customer.City);
            customerTable.Columns.Add(cityColumn);

            var postalCodeColumn = new DataColumn();
            postalCodeColumn.ColumnName = nameof(Customer.PostalCode);
            customerTable.Columns.Add(postalCodeColumn);

            var phoneNumberColumn = new DataColumn();
            phoneNumberColumn.ColumnName = nameof(Customer.PhoneNumber);
            customerTable.Columns.Add(phoneNumberColumn);

            var emailColumn = new DataColumn();
            emailColumn.ColumnName = nameof(Customer.Email);
            customerTable.Columns.Add(emailColumn);

            var creditLimitColumn = new DataColumn();
            creditLimitColumn.ColumnName = nameof(Customer.CreditLimit);
            customerTable.Columns.Add(creditLimitColumn);

            customerTable.PrimaryKey = new DataColumn[] { idColumn };

            return customerTable;
        }

        private DataSet GetDataSet()
        {
            var dataSet = new DataSet();
            dataSet.DataSetName = AGGREGATE_NAME;

            return dataSet;
        }

        private SqlDataAdapter GetDataAdapter()
        {
            var dataAdapter = new SqlDataAdapter(CUSTOMER_SELECT, UtilityDb.OpenConnection());
            // This line automatically creates INSERT/UPDATE/DELETE commands
            new SqlCommandBuilder(dataAdapter);
            return dataAdapter;
        }

        // This is getting the records from the dataset
        // It is not hitting the database
        public List<Customer> ToList()
        {
            var customers = new List<Customer>();

            foreach (var row in _customerDataTable.Rows)
            {
                var dataRow = (DataRow)row;
                var customer = Materialize(dataRow);
                customers.Add(customer);
            }

            return customers;
        }

        // This is refreshing the dataset from the database
        public void Refresh()
        {
            _dataAdapter.Fill(_customerDataTable);
        }

        // Create an instance of the Customer entity
        // Populate each customer property with data comming from the database
        private Customer Materialize(DataRow dataRow)
        {
            var customer = new Customer();

            customer.Id = (int)dataRow[nameof(Customer.Id)];
            customer.Name = (string)dataRow[nameof(Customer.Name)];
            customer.Address = (string)dataRow[nameof(Customer.Address)];
            customer.City = (string)dataRow[nameof(Customer.City)];
            customer.PostalCode = (string)dataRow[nameof(Customer.PostalCode)];
            customer.PhoneNumber = (string)dataRow[nameof(Customer.PhoneNumber)];
            customer.Email = (string)dataRow[nameof(Customer.Email)];
            customer.CreditLimit = Convert.ToDecimal(dataRow[nameof(Customer.CreditLimit)]);

            return customer;
        }

        // This method finds a record in the dataset
        public Customer Find(int customerId)
        {
            var dataRow = _customerDataTable.Rows.Find(customerId);
            if (dataRow == null)
            {
                return null;
            }
            var customer = Materialize(dataRow);

            return customer;
        }

        // This is only adding/updating records to the dataset
        public void AddOrUpdate(Customer customer)
        {
            if (customer == null)
            {
                return;
            }
            var dataRow = _customerDataTable.Rows.Find(customer.Id);
            if (dataRow == null)
            {
                dataRow = _customerDataTable.NewRow();
                Dematerialize(dataRow, customer);
                _customerDataTable.Rows.Add(dataRow);
                return;
            }
            Dematerialize(dataRow, customer);
        }

        // This is updating a datarow in a dataset with data comming from the form
        private void Dematerialize(DataRow dataRow, Customer customer)
        {
            dataRow[nameof(Customer.Id)] = customer.Id;
            dataRow[nameof(Customer.Name)] = customer.Name;
            dataRow[nameof(Customer.Address)] = customer.Address;
            dataRow[nameof(Customer.City)] = customer.City;
            dataRow[nameof(Customer.PostalCode)] = customer.PostalCode;
            dataRow[nameof(Customer.PhoneNumber)] = customer.PhoneNumber;
            dataRow[nameof(Customer.Email)] = customer.Email;
            dataRow[nameof(Customer.CreditLimit)] = customer.CreditLimit;
        }

        // This is removing a record from the dataset
        public void Remove(Customer customer)
        {
            if (customer == null)
            {
                return;
            }
            var dataRow = _customerDataTable.Rows.Find(customer.Id);
            if (dataRow == null)
            {
                return;
            }
            dataRow.Delete();
        }

        public void SaveChanges()
        {
            _dataAdapter.Update(_customerDataTable);
            Refresh();
        }
    }
}
