namespace PillarsOOP.Models;

public class BankAccount
{
    private double AccountBalance { get; set; }
    private double TaxRate => 0.18;

    public string Deposit(double amount)
    {
        AccountBalance += amount;
        return GetAtmMessage();
    }

    public double GetAccountBalance()
    {
        double balanceAfterTax = GetBalanceAfterTax();
        return balanceAfterTax;
    }

    public string GetAtmMessage()
    {
        return $"Your current account balance is ${GetAccountBalance()}";
    }

    private double GetBalanceAfterTax(){
        return AccountBalance * TaxRate;
    }
}