namespace TddByExample.Domain
{
    public class Money : IMoneyExpression
    {
        protected int Amount { get; set; }
        protected string Currency { get; set; }

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override bool Equals(object? obj)
        {
            var money = ((Money)obj);
            return Amount == money.Amount && Currency == money.Currency;
        }

        public Money Reduce(string toCurrency, Bank bank)
        {
            decimal rate = bank.Rate(Currency, toCurrency);
            var amount = (int)(Amount * rate);
            return new Money(amount, toCurrency);
        }

        public IMoneyExpression Plus(IMoneyExpression addEnd)
        {
            return new Sum(this, addEnd);
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public string GetCurrency()
        {
            return Currency;
        }

        public IMoneyExpression Plus(Money money)
        {
            return new Sum(this, money);
        }

        public int GetAmount()
        {
            return Amount;
        }
    }
}