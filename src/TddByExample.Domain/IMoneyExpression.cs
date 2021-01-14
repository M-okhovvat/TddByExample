namespace TddByExample.Domain
{
    public interface IMoneyExpression
    {
        Money Reduce(string toCurrency, Bank bank);

        IMoneyExpression Plus(IMoneyExpression moneyExpression);
        IMoneyExpression Times(int multiply);
    }
}