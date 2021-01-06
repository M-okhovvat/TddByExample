namespace TddByExample.Domain
{
    public class Dollar : Money
    {

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override string Currency()
        {
            return "USD";
        }

        public Dollar(int amount) : base(amount)
        {
        }


    }
}