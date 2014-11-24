using System.Data.Entity.Infrastructure;
using MFramework.EF.Core;

namespace MFramework.EF.Migrations
{
    /// <summary>
    /// Provider that is used to compare existing (database) version of the model
    /// to new version of the model based on properties and classes within the context
    /// e.i. tables and columns
    /// </summary>
    /// <typeparam name="TContext">DbContext instance</typeparam>
    public class ModelBasedNewVersionProvider<TContext> : INewVersionProvider<TContext>
        where TContext : ExtendedDbContext
    {

        private string _newVersion = string.Empty;

        /// <summary>
        /// Get new version for the context
        /// based on properties and classes within the context
        /// e.i. tables and columns
        /// </summary>
        /// <param name="context">Type of DbContext to use</param>
        /// <returns>New version</returns>
        public string GetNewVersion(TContext context)
        {
            if (_newVersion == string.Empty)
            {
                _newVersion = EdmMetadata.TryGetModelHash(context);
            }
            return _newVersion;
        }
    }
}
