using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace NotesOfOrder.Data
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            //Get Environment
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            //Build Config
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NotesOfOrder.Web"))
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .AddEnvironmentVariables();

            //Add User Secrets
            if (environment == "Development")
                builder.AddUserSecrets<DatabaseContextFactory>();

            var config = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            var connectionString = config.GetConnectionString("DatabaseConnection");
            optionsBuilder.UseSqlServer(
                connectionString,
                o => o.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)
                    .EnableRetryOnFailure()
            );

            //Used to output EF queries to the output window in debug mode
            var loggerFactory = new LoggerFactory(new[]
            {
                new DebugLoggerProvider()
            });

            return new DatabaseContext(optionsBuilder.Options, loggerFactory);
        }
    }
}
