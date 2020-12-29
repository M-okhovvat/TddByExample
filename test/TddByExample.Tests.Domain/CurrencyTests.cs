using FluentAssertions;
using TddByExample.Domain;
using Xunit;

namespace TddByExample.Tests.Domain
{
    public class CurrencyTests
    {
        [Fact]
        public void five_dollar_multiplied_multiple_times()
        {
            var fiveDollars = new Dollar(5);

            fiveDollars.Times(2).Should().Be(new Dollar(10));
            fiveDollars.Times(3).Should().Be(new Dollar(15));
        }

        [Fact]
        public void five_dollar_equals_five_dollar()
        {
            var fiveDollar = new Dollar(5);
            var anotherFiveDollar = new Dollar(5);

            fiveDollar.Should().Be(anotherFiveDollar);

            var sixDollar = new Dollar(6);
            var anotherSixDollar = new Dollar(7);

            sixDollar.Should().NotBe(anotherSixDollar);
        }
   
    }
}