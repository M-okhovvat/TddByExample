namespace TddByExample.Domain
{
    public class Money
    {
        protected int Amount { get; set; }

        public Money(int amount)
        {
            Amount = amount;
        }

        public override bool Equals(object? obj)
        {
            return Amount == ((Money)obj).Amount;
        }
    }
}