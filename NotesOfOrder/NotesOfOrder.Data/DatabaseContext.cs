using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NotesOfOrder.Core;
using NotesOfOrder.Core.Entities;

namespace NotesOfOrder.Data
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        private readonly ILoggerFactory _loggerFactory;

        public DatabaseContext(DbContextOptions<DatabaseContext> options, ILoggerFactory loggerFactory) : base(options)
        {
            _loggerFactory = loggerFactory;
        }

        public DbSet<ExampleEntity> ExampleEntities { get; set; }
        public DbSet<ExampleSubEntity> ExampleSubEntities { get; set; }
        public DbSet<Note> Notes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!Debugger.IsAttached)
                return;

            optionsBuilder.UseLoggerFactory(_loggerFactory);
            //.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.que));
        }
    }
}
