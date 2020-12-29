namespace TddByExample.Domain
{
    public class Dollar
    {
        public int Amount { get; set; }

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            return Amount == ((Dollar)obj).Amount;
        }
    }
}