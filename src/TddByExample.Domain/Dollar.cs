namespace TddByExample.Domain
{
    public class Dollar : Money
    {

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
        public Dollar(int amount) : base(amount)
        {
        }


    }
}