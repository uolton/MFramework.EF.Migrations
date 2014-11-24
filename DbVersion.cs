using System;

namespace MFramework.EF.Migrations
{
    /// <summary>
    /// Class that contains current version of the database
    /// You must include this class (table) if your DbContext
    /// to be supported by migrations
    /// </summary>
    public class DbVersion
    {
        /// <summary>
        /// Unique row identifier
        /// </summary>
        public int DbVersionID { get; set; }

        /// <summary>
        /// Current version of the database
        /// </summary>
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Data time when migrations last occurred or
        /// database was initially created
        /// </summary>
        public DateTime LastUpdatedOn { get; set; }
    }
}
