using System;
using MFramework.EF.Resources;

namespace MFramework.EF.Migrations
{
    /// <summary>
    /// Exception that is thrown when migration fails
    /// Inner exception will contain the exception from the migration 
    /// agent
    /// </summary>
    public class MigrationException : Exception
    {
        /// <summary>
        /// New instance of the exception
        /// </summary>
        /// <param name="innerException">Inner exception will contain the exception from the migration</param>
        public MigrationException(Exception innerException) :
            base(MainResource.MigrationErrorText, innerException)
        {

        }

        /// <summary>
        /// New instance of the exception
        /// </summary>
        /// <param name="message">Message that describes the exception</param>
        /// <param name="innerException">Inner exception will contain the exception from the migration</param>
        public MigrationException(string message, Exception innerException) :
            base(message, innerException)
        {

        }

        /// <summary>
        /// New instance of the exception
        /// </summary>
        /// <param name="message">Message that describes the exception</param>
        public MigrationException(string message) :
            base(message)
        {

        }
    }
}
