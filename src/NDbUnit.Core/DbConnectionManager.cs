using System;
using System.Data;

namespace NDbUnit.Core
{
    public class DbConnectionManager<TDbConnection> where TDbConnection : class, IDbConnection, new()
    {
        private readonly string _connectionString;
        private TDbConnection _connection;

        public DbConnectionManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbConnectionManager(TDbConnection connection)
        {
            HasExternallyManagedConnection = true;
            _connectionString = connection.ConnectionString;
            _connection = connection;
        }

        public bool HasExternallyManagedConnection { get; private set; }

        public TDbConnection GetConnection(bool forceNewConnection = false)
        {
            if (forceNewConnection)
            {
                if (HasExternallyManagedConnection)
                {
                    throw new InvalidOperationException("Cannot force new connection when DbConnectionManager has been initialized with an external connection.");
                }

                ReleaseConnection();
            }

            if (null == _connection && !HasExternallyManagedConnection)
            {
                _connection = CreateConnection(_connectionString);
            }

            return _connection;
        }

        public void ReleaseConnection()
        {
            if (_connection != null && !HasExternallyManagedConnection)
            {
                _connection.Dispose();
                _connection = null;
            }
        }

        private TDbConnection CreateConnection(string connectionString)
        {
            return new TDbConnection { ConnectionString = _connectionString };
        }
    }
}