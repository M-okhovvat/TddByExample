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
            var expression = Money.Dollar(4).Plus(Money.Dollar(5));
            var bank = new Bank();

            var reducedMoney = bank.Reduce(expression, "USD");

            reducedMoney.Should().Be(Money.Dollar(9));
        }

        [Fact]
        public void sum_of_two_moneys_is_a_kind_of_expression()
        {
            var dollar = Money.Dollar(5);
            var dollarToBeAdd = Money.Dollar(6);
            var expression = dollar.Plus(dollarToBeAdd);

            Sum sum = (Sum)expression;

            sum.AugEnd.Should().Be(dollar);
            sum.AddEnd.Should().Be(dollarToBeAdd);
        }

        [Fact]
        public void bank_reduce_sum_of_two_money_with_the_same_currency()
        {
            var dollar = Money.Dollar(5);
            var dollarToBeAdd = Money.Dollar(6);
            var expression = dollar.Plus(dollarToBeAdd);
            var bank = new Bank();

            var reducedMoney = bank.Reduce(expression, "USD");

            reducedMoney.Should().Be(Money.Dollar(11));
        }
    }
}