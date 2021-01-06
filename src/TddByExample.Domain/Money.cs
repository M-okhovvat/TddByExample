namespace TddByExample.Domain
{
    public abstract class Money
    {
        protected int Amount { get; set; }
        protected string Currency { get; set; }
        protected Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override bool Equals(object? obj)
        {

            return Amount == ((Money)obj).Amount && obj.GetType() == GetType();
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public abstract Money Times(int multiplyBy);


        public string GetCurrency()
        {
            return Currency;
        }
    }
}