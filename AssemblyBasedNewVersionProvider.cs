using MFramework.EF.Core;

namespace MFramework.EF.Migrations
{
    /// <summary>
    /// Provider that is used to compare existing (database) version of the model
    /// to new version of the model based on assembly that contains the DbCOntext
    /// </summary>
    /// <typeparam name="TContext">DbContext instance</typeparam>
    public class AssemblyBasedNewVersionProvider<TContext> : INewVersionProvider<TContext>
        where TContext : ExtendedDbContext
    {
        /// <summary>
        /// New instance of the provider
        /// </summary>
        public AssemblyBasedNewVersionProvider()
        {
            _newVersion = typeof(TContext).Assembly.GetName().Version.ToString();
        }

        private readonly string _newVersion = string.Empty;

        /// <summary>
        /// Get new version for the context
        /// based on assembly version that contains the context
        /// </summary>
        /// <param name="context">Type of DbContext to use</param>
        /// <returns>New version</returns>
        public string GetNewVersion(TContext context)
        {
            return _newVersion;
        }
    }
}
