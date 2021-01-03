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

        [Fact]
        public void define_five_franc()
        {
            TddByExample.Domain.CurrencyTests.Franc fiveFranc = new TddByExample.Domain.CurrencyTests.Franc(6);

            fiveFranc.Amount.Should().Be(6);
        }

        [Fact]
        public void multiply_franc()
        {
            var fiveFranc = new TddByExample.Domain.CurrencyTests.Franc(5);

            TddByExample.Domain.CurrencyTests.Franc tenFranc = fiveFranc.Times(2);

            tenFranc.Amount.Should().Be(10);

            TddByExample.Domain.CurrencyTests.Franc fifteenFranc = fiveFranc.Times(3);

            fifteenFranc.Amount.Should().Be(15);
        }

        [Fact]
        public void two_franc_with_same_value_are_equal()
        {
            var fiveFranc = new TddByExample.Domain.CurrencyTests.Franc(5);
            var anotherFiveFranc = new TddByExample.Domain.CurrencyTests.Franc(5);

            fiveFranc.Should().Be(anotherFiveFranc);

            var tenFranc = new TddByExample.Domain.CurrencyTests.Franc(10);
            var anotherTenFranc = new TddByExample.Domain.CurrencyTests.Franc(10);

            tenFranc.Should().Be(anotherTenFranc);
        }

        [Fact]
        public void two_franc_with_different_values_are_not_equal()
        {
            var fiveFranc = new TddByExample.Domain.CurrencyTests.Franc(5);
            var eightFranc = new TddByExample.Domain.CurrencyTests.Franc(8);

            fiveFranc.Should().NotBe(eightFranc);
        }

        [Fact]
        public void null_is_not_equal_to_franc()
        {
            var eightFranc = new TddByExample.Domain.CurrencyTests.Franc(8);

            eightFranc.Should().NotBe(null);
        }
    }
}