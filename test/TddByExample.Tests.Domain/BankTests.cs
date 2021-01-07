using FluentAssertions;
using TddByExample.Domain;
using Xunit;

namespace TddByExample.Tests.Domain
{
    public class BankTests
    {
        [Fact]
        public void five_dollar_plus_four_dollar_results_ten_dollar()
        {
            var expression = Money.Dollar(4).Sum(Money.Dollar(5));
            var bank = new Bank();

            var reducedMoney = bank.Reduce(expression, "USD");

            reducedMoney.Should().Be(Money.Dollar(9));
        }
    }
}