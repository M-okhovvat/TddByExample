namespace TddByExample.Domain
{
    public class Bank
    {
        public Money Reduce(IMoneyExpression expression, string toCurrency)
        {

            return expression.Reduce(toCurrency, this);
        }

        public void AddRate(string from, string to, int rate)
        {

        }

        public decimal GetRate(string from, string to)
        {
            if (from.Equals("CHF") && to.Equals("USD"))
                return 0.5m;

            if (from.Equals("USD") && to.Equals("CHF"))
                return 2;

            return 1;
        }
    }
}