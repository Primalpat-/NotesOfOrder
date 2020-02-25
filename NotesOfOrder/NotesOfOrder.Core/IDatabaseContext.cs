using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NotesOfOrder.Core.Entities;

namespace NotesOfOrder.Core
{
    public interface IDatabaseContext
    {
        DbSet<ExampleEntity> ExampleEntities { get; set; }
        DbSet<ExampleSubEntity> ExampleSubEntities { get; set; }
        DbSet<Note> Notes { get; set; }
        #region DBContext Features

        DbSet<T> Set<T>() where T : class;
        DatabaseFacade Database { get; }
        ChangeTracker ChangeTracker { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        EntityEntry Entry(object entity);
        void Dispose();
        string ToString();
        bool Equals(object obj);
        int GetHashCode();
        Type GetType();

        #endregion
    }
}
