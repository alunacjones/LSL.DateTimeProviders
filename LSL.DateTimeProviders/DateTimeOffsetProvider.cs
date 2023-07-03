using System;

namespace LSL.DateTimeProviders
{
    /// <inheritdoc/>
    public class DateTimeOffsetProvider : IDateTimeOffsetProvider
    {
        /// <inheritdoc/>
        public DateTimeOffset Now() => DateTimeOffset.Now;
    }
}
