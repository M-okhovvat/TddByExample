namespace TddByExample.Domain
{
    public class Dollar : Money
    {


        public Dollar(int amount) : base(amount)
        {

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

    public class Money
    {
        protected int Amount { get; set; }

        public Money(int amount)
        {
            Amount = amount;
        }
    }


}