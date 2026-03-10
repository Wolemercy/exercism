static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
        {
                >=5000 => 2.475f,
                >=1000 => 1.621f,
                >=0 => 0.5f,
                <0 => 3.213f,
        };
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance) * 0.01m;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        var currentBalance = balance;
        while (currentBalance < targetBalance)
        {
            currentBalance = AnnualBalanceUpdate(currentBalance);
            years++;
        }

        return years;
    }
}
