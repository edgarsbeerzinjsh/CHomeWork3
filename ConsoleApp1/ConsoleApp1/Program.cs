using ConsoleApp1;
// See https://aka.ms/new-console-template for more information
// Simbolu daudzbveidībai programmā
//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine("1. Uzdevums: Telefons");

//Telephone telephone1 = new Telephone();

//Console.WriteLine($"Ievadījāt telefonu ar šādiem parametriem:");
//Console.WriteLine($"Marka: {telephone1.Mark}");
//Console.WriteLine($"Modelis: {telephone1.Model}");
//Console.WriteLine($"Izmēri: {telephone1.Height} X {telephone1.Width} X {telephone1.Depth}");
//Console.WriteLine();
//telephone1.Call();
//telephone1.Sms();

//Console.WriteLine();
//Console.WriteLine();
//Telephone telephone2 = new Telephone();

//Console.WriteLine($"Ievadījāt telefonu ar šādiem parametriem:");
//Console.WriteLine($"Marka: {telephone2.Mark}");
//Console.WriteLine($"Modelis: {telephone2.Model}");
//Console.WriteLine($"Izmēri: {telephone2.Height} X {telephone2.Width} X {telephone2.Depth}");
//Console.WriteLine();
//telephone2.Call();
//telephone2.Sms();


//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("2. Uzdevums: Auto");
//Console.WriteLine();

//Car car1 = new Car();

//Console.WriteLine($"Ievadījāt auto ar šādiem parametriem:");
//Console.WriteLine($"Marka: {car1.Mark}");
//Console.WriteLine($"Numurzīme: {car1.Number}");
//Console.WriteLine($"Ātrums: {car1.Speed}");
//car1.AddSpeed();
//car1.ReduceSpeed();
//car1.Stop();
//car1.Beep();
//car1.StartDrive();

//Car car2 = new Car();

//Console.WriteLine($"Ievadījāt auto ar šādiem parametriem:");
//Console.WriteLine($"Marka: {car2.Mark}");
//Console.WriteLine($"Numurzīme: {car2.Number}");
//Console.WriteLine($"Ātrums: {car2.Speed}");
//car2.AddSpeed();
//car2.ReduceSpeed();
//car2.Stop();
//car2.Beep();
//car2.StartDrive();


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("3. Uzdevums: Prece");
Console.WriteLine();

Console.WriteLine($"Ievadiet preces garumu");
double height = double.Parse(Console.ReadLine());
Console.WriteLine($"Ievadiet preces platumu");
double width = double.Parse(Console.ReadLine());
Console.WriteLine($"Ievadiet preces augstumu");
double depth = double.Parse(Console.ReadLine());
Console.WriteLine($"Ievadiet preces svaru");
double weight = double.Parse(Console.ReadLine());

Item item1 = new Item(height, width, depth, weight);
item1.ShowItem();

Item prece = Item.NewItem();
Console.WriteLine($"Ievadītās preces parametri ir:");
Console.WriteLine($"Garums: {prece.Height}");
Console.WriteLine($"Platums: {prece.Width}");
Console.WriteLine($"Augstums: {prece.Depth}");
Console.WriteLine($"Svars: {prece.Weight}");


Console.WriteLine();
Console.WriteLine();
//Console.WriteLine("4. Uzdevums: Persona");
//Console.WriteLine();

//Person person1 = new Person();
//person1.YourAge();
//person1.Greeting();