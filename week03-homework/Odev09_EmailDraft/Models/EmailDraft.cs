using System;

namespace Odev09_EmailDraft.Models;

public class EmailDraft
{
    private string to;
    private string subject;
    private string body;
    private bool isSent;

    public string To
    {
        get { return to; }
        set { to = value; }
    }

    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }

    public string Body
    {
        get { return body; }
        set { body = value; }
    }

    public bool IsSent
    {
        get { return isSent; }
        private set { isSent = value; }
    }

    public void UpdateBody(string newBody)
    {
        if (IsSent)
        {
            Console.WriteLine("E-posta gönderildiği için düzenlenemez.");
            return;
        }

        Body = newBody;
    }

    public void Send()
    {
        if (string.IsNullOrWhiteSpace(To) || string.IsNullOrWhiteSpace(Subject))
        {
            Console.WriteLine("Alıcı ve konu boş olamaz.");
            return;
        }

        IsSent = true;
        Console.WriteLine("E-posta gönderildi.");
    }
}
