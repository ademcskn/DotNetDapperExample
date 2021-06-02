using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DotNetDapperExample
{
    public class DapperRepository
    {
        private readonly IDbConnection _connection;

        public DapperRepository()
        {
            _connection = new SqlConnection("Data Source=.;Initial Catalog=Customer;Integrated Security=True;");
        }

        public IDbConnection Connection
        {
            get { return _connection; }
        }

        public void Dispose()
        {
            if (_connection != null)
                _connection.Dispose();
        }
    }
}
