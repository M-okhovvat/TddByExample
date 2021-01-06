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
            Money fiveDollars = Money.Dollar(5);

            fiveDollars.Times(2).Should().Be(new Dollar(10));
            fiveDollars.Times(3).Should().Be(new Dollar(15));
        }

        [Fact]
        public void five_dollar_equals_five_dollar()
        {
            var fiveDollar = Money.Dollar(5);
            var anotherFiveDollar = new Dollar(5);

            fiveDollar.Should().Be(anotherFiveDollar);

            var sixDollar = Money.Dollar(6);

            sixDollar.Should().NotBe(fiveDollar);
        }

        [Fact]
        public void define_five_franc()
        {
            const int amount = 6;

            var fiveFranc = Money.Franc(amount);

            fiveFranc.Should().Be(Money.Franc(amount));
        }

        [Fact]
        public void multiply_franc()
        {
            var fiveFranc = Money.Franc(5);
            var tenFranc = fiveFranc.Times(2);

            tenFranc.Should().Be(Money.Franc(10));

            var fifteenFranc = fiveFranc.Times(3);

            fifteenFranc.Should().Be(Money.Franc(15));
        }

        [Fact]
        public void two_franc_with_same_value_are_equal()
        {
            var fiveFranc = Money.Franc(5);
            var anotherFiveFranc = Money.Franc(5);

            fiveFranc.Should().Be(anotherFiveFranc);

            var tenFranc = Money.Franc(10);
            var anotherTenFranc = Money.Franc(10);

            tenFranc.Should().Be(anotherTenFranc);
        }

        [Fact]
        public void two_franc_with_different_values_are_not_equal()
        {
            var fiveFranc = Money.Franc(5);
            var eightFranc = Money.Franc(8);

            fiveFranc.Should().NotBe(eightFranc);
        }

        [Fact]
        public void null_is_not_equal_to_franc()
        {
            var eightFranc = Money.Franc(8);

            eightFranc.Should().NotBe(null);
        }


        [Fact]
        public void five_franc_is_not_equal_to_five_dollar()
        {
            var franc = Money.Franc(5);
            var dollar = Money.Dollar(5);

            dollar.Should().NotBe(franc);
        }
    }
}