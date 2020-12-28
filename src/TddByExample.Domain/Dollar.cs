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
            Amount *= Amount * multiplier;
            return null;
        }
    }
}