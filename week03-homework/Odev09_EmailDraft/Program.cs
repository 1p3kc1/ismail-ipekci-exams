using Odev09_EmailDraft.Models;

namespace Odev09_EmailDraft;

class Program
{
    static void Main(string[] args)
    {
EmailDraft email = new EmailDraft();

email.Send();

email.To = "ali@gmail.com";
email.Subject = "Toplantı";
email.Body = "Merhaba.";

email.Send();

email.UpdateBody("Yeni mesaj");

Console.WriteLine($"Mesaj: {email.Body}");
Console.WriteLine($"Gönderildi mi? {email.IsSent}");
    }
}
