using MiniBankApp.Accounts;
using MiniBankApp.Infrastructure;
using MiniBankApp.Interfaces;
using MiniBankApp.Services;

IRepository<Account> repository = new InMemoryAccountRepository();
ITransactionLogger logger = new ConsoleTransactionLogger();

BankService bank = new BankService(repository, logger);


// 1. Hesapları oluştur
CheckingAccount checking1 =
    new CheckingAccount(1, "Ahmet", 5000);

CheckingAccount checking2 =
    new CheckingAccount(2, "Mehmet", 3000);

SavingsAccount savings =
    new SavingsAccount(
        3,
        "Ali",
        12,
        0.12m);

PremiumAccount premium =
    new PremiumAccount(4, "Zeynep");

Console.WriteLine(".........................");

// 2. Hesapları aç
bank.OpenAccount(checking1);
bank.OpenAccount(checking2);
bank.OpenAccount(savings);
bank.OpenAccount(premium);
Console.WriteLine(".........................");

// 3. Para yatır
bank.Deposit(1, 10000);
bank.Deposit(2, 5000);
bank.Deposit(3, 20000);
bank.Deposit(4, 30000);
Console.WriteLine(".........................");

// 4. Başarılı para çekme
bank.Withdraw(1, 2000);
Console.WriteLine(".........................");

// 5. Günlük limit aşımı → HATA
try
{
    bank.Withdraw(1, 6000);
}
catch (Exception ex)
{
    Console.WriteLine($"HATA: {ex.Message}");
}
Console.WriteLine(".........................");

// 6. Vadeli hesaptan vade dolmadan çekme → HATA
try
{
    bank.Withdraw(3, 1000);
}
catch (Exception ex)
{
    Console.WriteLine($"HATA: {ex.Message}");
}
Console.WriteLine(".........................");
try
{
    bank.TransferFunds(1, 2, 1000);
}
catch (Exception ex)
{
    Console.WriteLine($"TRANSFER HATASI: {ex.Message}");
}
Console.WriteLine(".........................");
try
{
    bank.TransferFunds(1, 2, 6000);
}
catch (Exception ex)
{
    Console.WriteLine($"TRANSFER HATASI: {ex.Message}");
}
Console.WriteLine(".........................");

// 7. Hesapları listele
bank.PrintAccounts();

Console.WriteLine(".........................");
// 8. Faiz raporu
bank.PrintInterestReport();
Console.WriteLine(".........................");

// 9. İşlem geçmişi
bank.PrintTransactionHistory(1);

Console.WriteLine(".........................");

try
{
    bank.Deposit(9, 1000);
}
catch (Exception ex)
{
    Console.WriteLine($"HATA: {ex.Message}");
}
Console.WriteLine(".........................");

//kapalı hesap
checking2.Close();

try
{
    bank.Withdraw(2, 100);
}
catch (Exception ex)
{
    Console.WriteLine($"HATA: {ex.Message}");
}