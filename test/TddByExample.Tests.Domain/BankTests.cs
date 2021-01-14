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

        [Fact]
        public void exchange_franc_to_dollar_when_rate_is_two_to_one()
        {
            var franc = Money.Franc(2);
            var bank = new Bank();

            bank.AddRate("CHF", "USD", 0.5m);
            var reducedMoney = bank.Reduce(franc, "USD");

            var expected = Money.Dollar(1);
            reducedMoney.Should().Be(expected);
        }

        [Fact]
        public void exchange_dollar_to_franc_when_rate_is_one_to_two()
        {
            var dollar = Money.Dollar(2);
            var bank = new Bank();

            bank.AddRate("USD", "CHF", 2);
            var reducedMoney = bank.Reduce(dollar, "CHF");

            var expected = Money.Franc(4);
            reducedMoney.Should().Be(expected);
        }

        [Fact]
        public void exchange_dollar_to_dollar_when_rate_is_one_to_one()
        {
            var dollar = Money.Dollar(1);
            var bank = new Bank();

            var reducedMoney = bank.Reduce(dollar, "USD");

            var expected = Money.Dollar(1);
            reducedMoney.Should().Be(expected);
        }

        [Fact]
        public void exchange_rate_for_changing_dollar_to_dollar_is_one()
        {
            var bank = new Bank();

            var rate = bank.Rate("USD", "USD");

            rate.Should().Be(1);
        }

        [Fact]
        public void sum_of_two_franc_with_one_dollar__equals_to_two_dollar() // 2 CHF + 1 USD = 2 USD
        {
            IMoneyExpression franc = Money.Franc(2);
            IMoneyExpression dollar = Money.Dollar(1);
            var bank = new Bank();
            bank.AddRate("USD", "CHF", 2);
            bank.AddRate("CHF", "USD", 0.5m);

            var reducedAmount = bank.Reduce(dollar.Plus(franc), "USD");

            var expected = Money.Dollar(2);
            reducedAmount.Should().Be(expected);
        }

        [Fact]
        public void sum_of_two_franc_with_one_dollar_equals_to_four_dollar() // 2 CHF + 1 USD = 4 CHF
        {
            var franc = Money.Franc(2);
            var dollar = Money.Dollar(1);
            var bank = new Bank();
            bank.AddRate("USD", "CHF", 2);
            bank.AddRate("CHF", "USD", 0.5m);


            var reducedAmount = bank.Reduce(franc.Plus(dollar), "CHF");

            var expected = Money.Franc(4);
            reducedAmount.Should().Be(expected);

            var sumResult = new Sum(dollar, franc);
            var reducedAmountResult = bank.Reduce(sumResult, "CHF");

            reducedAmountResult.Should().Be(expected);
        }
    }

    public class SumTests
    {
        [Fact]
        public void sum_plus_tests()
        {
            var oneDollar = Money.Dollar(1);
            var twoFranc = Money.Franc(2);
            var bank = new Bank();
            bank.AddRate("CHF", "USD", 0.5m);
            bank.AddRate("USD", "CHF", 2);
            var sum = new Sum(oneDollar, twoFranc);
            var sumExpression = sum.Plus(twoFranc);

            var reducedAmount = bank.Reduce(sumExpression, "CHF");

            var expectedResult = Money.Franc(6);
            reducedAmount.Should().Be(expectedResult);
        }
    }
}