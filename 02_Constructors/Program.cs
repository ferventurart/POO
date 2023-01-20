// See https://aka.ms/new-console-template for more information

BankAccount savingAccount = new();

savingAccount.GenerarNumeroCuenta();
savingAccount.Amount = 1200;
savingAccount.IsActive = true;

string message = $"La cuenta No. {savingAccount.AccountNumber} del propietario/a {savingAccount.Owner} tiene un ahorro total de ${savingAccount.Amount}";


BankAccount checkingAccount = new("Pedro Vasquez");
checkingAccount.Amount = 900;
checkingAccount.IsActive = true;

string messageAuto = $"La cuenta No. {checkingAccount.AccountNumber} del propietario/a {checkingAccount.Owner} tiene un ahorro total de ${checkingAccount.Amount}";



Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(message);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(messageAuto);