using System;
using System.Data.Common;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace UDS.Net.API.HealthChecks
{
    // Code from https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/monitor-app-health#use-the-healthchecks-feature-in-your-back-end-aspnet-microservices
    public class SqlConnectionHealthCheck : IHealthCheck
    {
        private const string DefaultTestQuery = "Select 1";

        public string ConnectionString { get; }

        public string TestQuery { get; }

        public SqlConnectionHealthCheck(string connectionString)
            : this(connectionString, testQuery: DefaultTestQuery)
        {
        }

        public SqlConnectionHealthCheck(string connectionString, string testQuery)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            TestQuery = testQuery;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                try
                {
                    await connection.OpenAsync(cancellationToken);

                    if (TestQuery != null)
                    {
                        var command = connection.CreateCommand();
                        command.CommandText = TestQuery;

                        await command.ExecuteNonQueryAsync(cancellationToken);
                    }
                }
                catch (DbException ex)
                {
                    return new HealthCheckResult(status: context.Registration.FailureStatus, exception: ex);
                }
            }

            return HealthCheckResult.Healthy();
        }
    }
}

