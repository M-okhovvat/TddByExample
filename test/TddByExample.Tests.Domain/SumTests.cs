using FluentAssertions;
using TddByExample.Domain;
using Xunit;

namespace TddByExample.Tests.Domain
{
    public class SumTests
    {
        private readonly Bank _bank;

        public SumTests()
        {
            _bank = new Bank();
            _bank.AddRate("CHF", "USD", 0.5m);
            _bank.AddRate("USD", "CHF", 2);
        }

        [Fact]
        public void sum_plus_tests()
        {
            var oneDollar = Money.Dollar(1);
            var twoFranc = Money.Franc(2);

            var sum = new Sum(oneDollar, twoFranc);
            var sumExpression = sum.Plus(twoFranc);

            var reducedAmount = _bank.Reduce(sumExpression, "CHF");

            var expectedResult = Money.Franc(6);
            reducedAmount.Should().Be(expectedResult);
        }

        [Fact]
        public void sum_times()
        {
            var oneDollar = Money.Dollar(1);
            var twoFranc = Money.Franc(2);
            var sum = new Sum(oneDollar, twoFranc);
            var resultedSum = sum.Times(2);

            var reducedAmountToDollar = _bank.Reduce(resultedSum, "USD");

            var expected = Money.Dollar(4);
            reducedAmountToDollar.Should().Be(expected);
        }
    }
}