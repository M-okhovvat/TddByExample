using FluentAssertions;
using TddByExample.Domain;
using Xunit;

namespace TddByExample.Tests.Domain
{
    public class CurrencyTests
    {
        [Fact]
        public void five_dollars_multiplied_by_two_equals_ten_dollars()
        {
            var dollar = new Dollar(5);

            dollar.Times(2);

            dollar.Amount.Should().Be(10);
        }
    }
}