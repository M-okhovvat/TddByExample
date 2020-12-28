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

        [Fact]
        public void five_dollar_multiplied_multiple_times()
        {
            var fiveDollars = new Dollar(5);

            Dollar tenDollars = fiveDollars.Times(2);
            tenDollars.Amount.Should().Be(10);
            Dollar fifteenDollars = fiveDollars.Times(3);
            fifteenDollars.Amount.Should().Be(15);
        }
    }
}