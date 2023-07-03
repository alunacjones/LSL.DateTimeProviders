using System;

namespace LSL.DateTimeProviders
{
    /// <summary>
    /// Abstraction to provide the current DateTime
    /// </summary>
    public interface IDateTimeProvider
    {
        /// <summary>
        /// Get the current DateTime
        /// </summary>
        /// <returns>Now</returns>
        DateTime Now();
    }
}
