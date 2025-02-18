
namespace TEST.src.SOLID.aSRP
{

    //SRP: User a une seule responsabilité => représenter un user et UserService a une responsabilité => s'occuper de la gestion (Business Logic) d'un User
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        //BAD: La classe a plus d'une raison pour changer, est ça va à l'encontre du principe SRP. Si on change User et qu'on lui ajoute plus de propiétés, ou si on change la 
        // logique de register, comme par exemple l'enregistrement doit prendre en paramètre un nom etc. D'ou la création de UserService.cs

        // public void Register()
        // {
        //     // Register user logic...

        //     // Send email
        //     EmailSender emailSender = new EmailSender();
        //     emailSender.SendEmail(Email, "Welcome to our plateform");
        // }
    }
}