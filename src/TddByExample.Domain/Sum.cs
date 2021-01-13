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
        { //addEnd : 2 CHF , augEnd: 1 USD
            var addEndAmount = AddEnd.Reduce(toCurrency, bank).GetAmount();
            var augEndAmount = AugEnd.Reduce(toCurrency, bank).GetAmount();

            return new Money((int)(addEndAmount + augEndAmount), toCurrency);
        }

        public IMoneyExpression Plus(IMoneyExpression franc)
        {
            return null;
        }
    }
}