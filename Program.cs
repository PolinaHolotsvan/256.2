//принцип відкритості/закритості, єдиного обов'язку
class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}
class EmailSender
{
    public void Send(Email email, EmailFormatter formatter)
    {
        // ... sending...
    }
}

interface EmailFormatter
{
    ///
}

class EmailShortFormatter: EmailFormatter
{
    ///
}

class EmailFullFormatter: EmailFormatter
{
    ///
}

class EmailLogger
{
    public void Log(Email email)
    {
        Console.WriteLine("Email from '" + email.From + "' to'" + email.To + "' was send");
    }
}
class Program
{
    static void Main(string[] args)
    {
        EmailLogger logger = new EmailLogger();
        EmailShortFormatter formatter1 = new EmailShortFormatter();
        EmailFullFormatter formatter2 = new EmailFullFormatter();
        Email e1 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Who are you?"
        };
        Email e2 = new Email()
        {
            From = "Vasya",
            To = "Me",
            Theme = "vacuum cleaners!"
        };
        Email e3 = new Email()
        {
            From = "Kolya",
            To =
       "Vasya",
            Theme = "No! Thanks!"
        };
        Email e4 = new Email()
        {
            From = "Vasya",
            To = "Me",
            Theme = "washing machines!"
        };
        Email e5 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Yes"
        };
        Email e6 = new Email()
        {
            From = "Vasya",
            To =
       "Petya",
            Theme = "+2"
        };
        EmailSender es = new EmailSender();
        es.Send(e1, formatter1);
        es.Send(e2, formatter2);
        es.Send(e3, formatter2);
        es.Send(e4, formatter2);
        es.Send(e5, formatter1);
        es.Send(e6, formatter2);
        Console.ReadKey();
    }
}
