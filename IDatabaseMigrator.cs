
namespace MFramework.EF.Migrations
{
    /// <summary>
    /// Database migrator interface
    /// </summary>
    public interface IDatabaseMigrator
    {
        /// <summary>
        /// Main function that performs migration
        /// </summary>
        /// <param name="sourceConnectionString">Connection string for source database</param>
        /// <param name="destinationConnectionString">Connection string for destination database</param>
        void Migrate(string sourceConnectionString, string destinationConnectionString);
    }
}
