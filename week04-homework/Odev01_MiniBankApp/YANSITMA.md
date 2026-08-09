*Encapsulation'ı Account.cs içindeki Balance ve IsActive propertylerinde kullandım.(private set)
*Polymorphism'i Account klasörü içindeki classlarda kullandım.(override)
*Interface kullanmak, BankService'in somut sınıflara bağımlı olmasını engelledi. Böylece farklı repository ve logger sınıfları kullanılabilirim ve yeni özellikler eklerken mevcut kodu değiştirmek zorunda kalmam.
*Dokunduğum dosya
Accounts/PremiumAccount.cs :Yeni hesap türünü oluşturdum.
Program.cs :Premium hesabı oluşturup bankaya eklemek için dokundum.

Dokunmadığım dosya
BankService.cs → Dokunmadım.

Çünkü BankService, Account interface/abstract yapısına ve polymorphism'e göre çalışıyor. PremiumAccount, CheckingAccount'tan türediği için BankService onu da normal bir Account gibi kullanabiliyor.