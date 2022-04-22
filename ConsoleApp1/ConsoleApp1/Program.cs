using ConsoleApp1;
// See https://aka.ms/new-console-template for more information
// Simbolu daudzbveidībai programmā
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("1. Uzdevums: Telefons");
Telephone telephone1 = new Telephone();

Console.WriteLine($"Ievadījāt telefonu ar šādiem parametriem:");
Console.WriteLine($"Marka: {telephone1.Mark}");
Console.WriteLine($"Modelis: {telephone1.Model}");
Console.WriteLine($"Izmēri: {telephone1.Hight} X {telephone1.Width} X {telephone1.Depth}");
Console.WriteLine();
telephone1.Call();
telephone1.Sms();


Console.WriteLine();
Console.WriteLine();
Telephone telephone2 = new Telephone();

Console.WriteLine($"Ievadījāt telefonu ar šādiem parametriem:");
Console.WriteLine($"Marka: {telephone2.Mark}");
Console.WriteLine($"Modelis: {telephone2.Model}");
Console.WriteLine($"Izmēri: {telephone2.Hight} X {telephone2.Width} X {telephone2.Depth}");
Console.WriteLine();
telephone2.Call();
telephone2.Sms();