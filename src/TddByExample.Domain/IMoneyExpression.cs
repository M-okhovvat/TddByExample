namespace TddByExample.Domain
{
    public interface IMoneyExpression
    {
        Money Reduce(string toCurrency, Bank bank);
    }
}