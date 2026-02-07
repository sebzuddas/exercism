static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {

        if (balance >= 0 && balance < 1000)
        {
            return 000.5f;
        }
        else if (balance >= 1000 && balance < 5000)
        {
            return 001.621f;
        }
        else if (balance >= 5000)
        {
            return 002.475f;
        }
        else 
        {
            return 003.213f;
        }
        
    }

    public static decimal Interest(decimal balance)
    {
        float interestRate = InterestRate(balance)/100; // divide by 100 to get percentage calculation
        return balance * Convert.ToDecimal(interestRate); 

    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while(balance < targetBalance)
        {
            balance = balance + Interest(balance);
            years++;
        }
        return years;

    }
}
