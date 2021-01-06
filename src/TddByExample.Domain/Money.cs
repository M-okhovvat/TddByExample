namespace TddByExample.Domain
{
    public class Money
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

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }


        public string GetCurrency()
        {
            return Currency;
        }
    }
}