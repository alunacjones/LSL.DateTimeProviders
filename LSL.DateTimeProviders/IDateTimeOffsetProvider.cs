using System;

namespace LSL.DateTimeProviders
{
    /// <summary>
    /// Abtraction to provide the current DateTimeOffset
    /// </summary>
    public interface IDateTimeOffsetProvider
    {
        /// <summary>
        /// Get the current DateTimeOffset
        /// </summary>
        /// <returns>Now</returns>
        DateTimeOffset Now();
    }
}
