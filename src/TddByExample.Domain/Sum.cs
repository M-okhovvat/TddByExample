namespace TddByExample.Domain
{
    public class Sum : IMoneyExpression
    {
        public IMoneyExpression AugEnd { get; private set; }
        public IMoneyExpression AddEnd { get; private set; }

        public Sum(IMoneyExpression augEnd, IMoneyExpression addEnd)
        {
            AugEnd = augEnd;
            AddEnd = addEnd;
        }

        public Money Reduce(string toCurrency, Bank bank)
        {
            var addEnd = AddEnd.Reduce(toCurrency, bank).GetAmount();
            var augEnd = AugEnd.Reduce(toCurrency, bank).GetAmount();
            return new Money(addEnd + augEnd, toCurrency);
        }

        public IMoneyExpression Plus(IMoneyExpression moneyExpression)
        {
            return new Sum(this, moneyExpression);
        }
    }
}