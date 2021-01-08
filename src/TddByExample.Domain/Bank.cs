namespace TddByExample.Domain
{
    public class Bank
    {
        public Money Reduce(IMoneyExpression expression, string toCurrency)
        {
            return ((Sum)expression).Reduce(toCurrency);
        }
    }
}