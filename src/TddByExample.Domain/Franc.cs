namespace TddByExample.Domain
{
    public class Franc : Money
    {
        public Franc(int amount) : base(amount)
        {
        }

        public Franc Times(int multipliedBy)
        {
            return new Franc(multipliedBy * Amount);
        }
    }
}