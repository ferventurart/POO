class BankAccount
{
    private string _owner;
    private int _accountNumber;
    public int AccountNumber => _accountNumber;
    public string Owner => _owner;
    public decimal Amount { get; set; }
    public bool IsActive { get; set; }
    public BankAccount()
    {
        _owner = "Fernando Ventura";
        IsActive = true;
    }

    public BankAccount(string owner)
    {
        GenerarNumeroCuenta();
        IsActive = true;
        _owner = owner;
    }

    public void GenerarNumeroCuenta()
    {
        var rnd = new Random();
        _accountNumber = rnd.Next();
    }
}