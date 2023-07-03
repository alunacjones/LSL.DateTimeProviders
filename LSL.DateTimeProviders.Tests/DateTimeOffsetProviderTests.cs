using NUnit.Framework;
using FluentAssertions;
using System;

namespace LSL.DateTimeProviders.Tests
{
    public class DateTimeOffsetProviderTests
    {
        [Test]
        public void ItShouldReturnTheExpectedDateTimeOffset()
        {
            new DateTimeOffsetProvider().Now().Should().BeWithin(TimeSpan.FromSeconds(2));
        }    
    }
}
