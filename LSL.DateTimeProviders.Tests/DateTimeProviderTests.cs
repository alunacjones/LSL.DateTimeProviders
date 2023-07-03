using NUnit.Framework;
using FluentAssertions;
using System;

namespace LSL.DateTimeProviders.Tests
{
    public class DateTimeProviderTests
    {
        [Test]
        public void ItShouldReturnTheExpectedDateTime()
        {
            new DateTimeProvider().Now().Should().BeWithin(TimeSpan.FromSeconds(2));
        }        
    }
}
