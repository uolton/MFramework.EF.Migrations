using System.Data.Entity;
using MFramework.EF.Core;

namespace MFramework.EF.Migrations
{
    /// <summary>
    /// Interface that Migrating Initializeer must implement
    /// </summary>
    /// <typeparam name="TContext">Type of context for the migration</typeparam>
    public interface IMigratingInitializer<in TContext> : IDatabaseInitializer<TContext>
        where TContext : ExtendedDbContext
    {
        /// <summary>
        /// Indicates that migrations are enabled
        /// Is set to false after the migrations are run
        /// </summary>
        bool MigrationsEnabled { get; set; }
    }
}
