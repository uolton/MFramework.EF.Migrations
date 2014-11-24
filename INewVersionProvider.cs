using MFramework.EF.Core;

namespace MFramework.EF.Migrations
{
    /// <summary>
    /// Interface that is used to compare existing and 
    /// new version of the DbContext
    /// </summary>
    /// <typeparam name="TContext">Type of DbContext</typeparam>
    public interface INewVersionProvider<TContext>
        where TContext: ExtendedDbContext
    {
        /// <summary>
        /// Provide new version to be migrated to
        /// </summary>
        /// <param name="context">DbContext to use</param>
        /// <returns>New version</returns>
        string GetNewVersion(TContext context);
    }
}
