namespace TEST.src.OopPrinciples.Coupling
{
    public class Order
    {
        private readonly INotificationService notificationService;

        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            //Place order logic
            notificationService.SendNotification("Order placed sucessfully");
        }
    }
}