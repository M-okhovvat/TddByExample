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

        public Money Reduce(string toCurrency, Bank bank)
        { //addEnd : 2 CHF , augEnd: 1 USD
            var addEndAmount = AddEnd.GetAmount();
            var augEndAmount = AugEnd.GetAmount();
            var addEndCurrency = AddEnd.GetCurrency();
            var augEndCurrency = AugEnd.GetCurrency();

            var addEndToExpectedExchangeRate = bank.Rate(addEndCurrency, toCurrency);
            var augEndToExpectedExchangeRate = bank.Rate(augEndCurrency, toCurrency);

            var addEndExchangedAmount = addEndAmount * addEndToExpectedExchangeRate;
            var augEndExchangedAmount = augEndAmount * augEndToExpectedExchangeRate;



            return new Money((int)(addEndExchangedAmount + augEndExchangedAmount), toCurrency);
        }
    }
}