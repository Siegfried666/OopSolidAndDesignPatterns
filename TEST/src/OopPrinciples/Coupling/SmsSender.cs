namespace TEST.src.OopPrinciples.Coupling
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            //Email sending logic
            Console.WriteLine("Sms message: " + message);
        }
    }
}