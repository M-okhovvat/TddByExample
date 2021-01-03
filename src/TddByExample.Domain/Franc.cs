namespace TddByExample.Domain
{
    public class Franc
    {
        public Franc(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public Franc Times(int multipliedBy)
        {
            return new Franc(multipliedBy * Amount);
        }

        public override bool Equals(object obj)
        {
            return ((Franc)obj).Amount == Amount;
        }
    }
}