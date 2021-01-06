namespace TddByExample.Domain
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount)
        {
            Currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }
    }
}