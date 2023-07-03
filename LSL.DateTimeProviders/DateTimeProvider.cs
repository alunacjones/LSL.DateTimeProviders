using System;

namespace LSL.DateTimeProviders
{
    /// <inheritdoc/>
    public class DateTimeProvider : IDateTimeProvider
    {
        /// <inheritdoc/>
        public DateTime Now() => DateTime.Now;
    }
}
