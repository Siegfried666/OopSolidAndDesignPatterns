namespace TEST.src.SOLID.aSRP
{

    public class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending email to {email}: {message}");
        }
    }
}