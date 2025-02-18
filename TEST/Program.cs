/*
    Encapsulation: Permet de séparer les interfaces publiques de la complexité interne d'une classe,
*/

using TEST.src.OopPrinciples.Abstraction;
using TEST.src.OopPrinciples.Coupling;
using TEST.src.OopPrinciples.Encapsulation;
using TEST.src.OopPrinciples.Inheritance;
using TEST.src.OopPrinciples.Polymorphism;
using TEST.src.SOLID.bOCP;
using TEST.src.SOLID.cLSP;

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

/*
    SRP: Single Responsibility Principle=> Le principe de responsabilité unique te permet de t’assurer qu’une fonction ne fait qu’une seule et unique chose, mais qu’elle le fait bien.
	=> Diviser pour mieux regnier en créant plusieurs classes avec leurs méthodes propres, plutôt qu'un four tout de plusieurs fonctionnalités dans une seule classe
*/

/*
    OCP : Open/Closed Principle: (O) Le principe Ouvert/Fermé te demande de ne pas modifier le comportement d’une action en fonction d’un paramètre, mais plutôt d’étendre 
    les capacités dudit
        paramètre grâce à une fonction définie en amont.
        => On a une méthode qui comporte un objet en entrée, et suivant sont typeOf, on est obligé de rajouter à chaque fois un case si on rajoute un autre objet
        => On utilise une interface dans chaque classe qui établie une méthodes patagée par l'ensemble des classes, qu'on vient ajouter à la classe existante d'ou l'étendre
         et la fermer à la modification
*/

/*
	LSP : Liskov’s Substitution Principle (LSP): (L) Le principe de substitution de Liskov te permet d’interchanger les enfants d’une classe sans que cela ait
     d’incidence sur l’exécution du code.
	=> En gros la classe abstraite, ou l'interface doit être la même chose en terme de paramètres d'entrée et de sortie dans les classes qui en héritent
*/

//BAD: Liskov Substitution principle: on doit pouvoir substituer une superclasse (Rectangle) par une sub classe (Square) et avoir les mêmes resultats, ici ce n'est pas possible !
// var rect = new Rectangle();
// rect.Height = 10;
// rect.Width = 5;

// Console.WriteLine("Expected area = 10 * 5 = 50");
// Console.WriteLine(rect.Area);

// var square = new Square();
// rect.Height = 10;
// rect.Width = 5;

// Console.WriteLine("Expected area = 10 * 5 = 50");
// Console.WriteLine(square.Area);

//GOOD
TEST.src.SOLID.cLSP.Shape rectangle = new TEST.src.SOLID.cLSP.Rectangle { Width = 5, Height = 4 };
Console.WriteLine($"Area of  the rectangle: {rectangle.Area}");

Square square = new Square { SideLength = 5 };
Console.WriteLine($"Area of the square: {square.Area}");

/*
	ISP : Interface Segregation Principle (ISP): (I) Le principe de ségrégation des interfaces te demande de séparer les actions le plus possible.
	=> Il vaut mieux faire plusieurs petites interfaces qu'une grosse pour éviter d'avoir à implémenter ou à surcharger une classe qui en hérite
*/

//BAD: Unhandled exception. System.InvalidOperationException: Volume not applicable to the 2D shapes at TEST.src.SOLID.dISP.Circle.Volume() 
// in D:\DEVELOPPEMENT\Dev 2025\TEST\TEST\src\SOLID\dISP\Cicle.cs:line 15
// var circle = new TEST.src.SOLID.dISP.Circle();
// circle.Radius = 10;
// Console.WriteLine(circle.Area());
//Console.WriteLine(circle.Volume()); // Le volume n'existe pas dans un cercle en 2D du coup ça throw l'exception qu'on a implémentée !

// GOOD
var circle = new TEST.src.SOLID.dISP.Circle();
circle.Radius = 10;
Console.WriteLine(circle.Area());

var sphere = new TEST.src.SOLID.dISP.Sphere();
sphere.Radius = 10;
Console.WriteLine(sphere.Area());

/*
	DIP : Dependency Inversion Principle (DIP): (D) Le principe d’inversion de dépendance préconise de passer des abstractions en paramètre (des contrats grâce aux interfaces)
	plutôt que les objets eux-mêmes.
	=> On passe une interface au lieu d'un objet en paramètre
*/

//BAD: le fait de mettre en paramètre d'entrée un classe concrète ça restreint le choix de l'implémentation de classe !
// var carDip = new TEST.src.SOLID.eDIP.Car(new TEST.src.SOLID.eDIP.ElectricEngine()); // Erreur

//GOOD: introduire une abstraction ou interface à la place d'une implémentation concrète d'un objet !
var carDip = new TEST.src.SOLID.eDIP.Car(new TEST.src.SOLID.eDIP.ElectricEngine()); // OK !

carDip.StartCar();
