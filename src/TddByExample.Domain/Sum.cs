namespace TddByExample.Domain
{
    public class Sum : IMoneyExpression
    {
        public Money AugEnd { get; private set; }
        public Money AddEnd { get; private set; }

        public Sum(Money augEnd, Money addEnd)
        {
            AugEnd = augEnd;
            AddEnd = addEnd;
        }

        public Money Reduce(string toCurrency)
        {
            var addEnd = AddEnd.GetAmount();
            var augEnd = AugEnd.GetAmount();
            return new Money(addEnd + augEnd, toCurrency);
        }
    }
}