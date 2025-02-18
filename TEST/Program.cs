/*
    Encapsulation: Permet de séparer les interfaces publiques de la complexité interne d'une classe,
*/

using TEST.src.OopPrinciples.Abstraction;
using TEST.src.OopPrinciples.Coupling;
using TEST.src.OopPrinciples.Encapsulation;
using TEST.src.OopPrinciples.Inheritance;
using TEST.src.OopPrinciples.Polymorphism;

BadBankAccount badBankAccount = new BadBankAccount();

badBankAccount.balance = -50;
Console.WriteLine(badBankAccount.balance);

// BankAccount bankAccount = new BankAccount(-100); // Return exception negative amount !
BankAccount bankAccount = new BankAccount(100); // OK !
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(100); // OK !
// bankAccount.Withdraw(200); // NOK 150 - 200 = -50 ! Withdraw amount must be positive
Console.WriteLine(bankAccount.GetBalance());

/*
    Abstraction: Permet de réduire la complexité en cachant les détails non nécessaire
*/

EmailService emailService = new EmailService();

//Bad 
// emailService.Connect();
// emailService.Authenticate();
// emailService.SendEmail();
// emailService.Disconnect();

//Good
emailService.SendEmail();

/*
    Inheritance:  créer des sous classes ou classes derrivées basées sur une classe existante pour éviter d'avoir à se répeter dans chaque classe, "Est un" (is-a relationship)
*/
TEST.src.OopPrinciples.Inheritance.Car car = new TEST.src.OopPrinciples.Inheritance.Car();

//Shared
car.Brand = "Ford";
car.Start();
car.Stop();

//Unique
car.NumberOfDoors = 4;

/*
    Polymorphisme:  Possibilité pour un objet d'avoir plusieurs formes
*/
//Bad
// List<object> vehicules = new List<object>();

//Good
List<TEST.src.OopPrinciples.Polymorphism.Vehicule> vehicules = new List<TEST.src.OopPrinciples.Polymorphism.Vehicule>();
vehicules.Add(new TEST.src.OopPrinciples.Polymorphism.Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
vehicules.Add(new Motocycle { Brand = "Harley Davidson", Model = "Sportster", Year = 2021 });

//Bad
// Vehicule inspection
// foreach (var vehicule in vehicules)
// {
//     if (vehicule is TEST.src.OopPrinciples.Polymorphism.Car)
//     {
//         var carPo = (TEST.src.OopPrinciples.Polymorphism.Car)vehicule;
//         carPo.Start();
//     }
//     else if (vehicule is Motocycle)
//     {
//         var moto = (Motocycle)vehicule;
//         moto.Start();
//     }
// }

//Good
foreach (var vehicule in vehicules)
{
    vehicule.Start();
}

/*
    Coupling:  Degré de dépendance entre différentes classes, si les classes sont interconnectées, c'est plus compliqué pour les modifier sans 
    qu'il n'y ait un impacte sur chacune d'elle
*/

//Bad: EmailSender est couplé avec Order, si on veut changer EmailSender, il faudra aussi changer Order
// var order = new Order();
// order.PlaceOrder();

//Good
var orderFromEmail = new Order(new EmailSender());
orderFromEmail.PlaceOrder();

var orderFromSms = new Order(new SmsSender());
orderFromSms.PlaceOrder();

/*
    Composition:  Créer des objets complexe à partir d'objets simples => "A un" (has-a relationship) relation exemple: Car a une relation avec les wheels, seats, chassis, engine
*/
var carCo = new TEST.src.OopPrinciples.Composition.Car();
carCo.StartCar();