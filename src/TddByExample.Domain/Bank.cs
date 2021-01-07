namespace TddByExample.Domain
{
    public class Bank
    {
        public Money Reduce(MoneyExpression expression, string toCurrency)
        {
            return Money.Dollar(9);
        }
    }
}