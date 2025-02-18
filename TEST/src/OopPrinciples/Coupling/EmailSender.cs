namespace TEST.src.OopPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {
        // public void SendEmail(string message)
        // {
        //     //Email sending logic
        //     Console.WriteLine("Sending email: " + message);
        // }

        public void SendNotification(string message)
        {
            //Email sending logic
            Console.WriteLine("Sending email: " + message);
        }
    }
}