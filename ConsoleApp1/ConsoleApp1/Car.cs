namespace ConsoleApp1
{
    public class Car
    {
        public Car()
        {
            Console.WriteLine($"Ievadiet auto marku");
            Mark = Console.ReadLine();
            Console.WriteLine($"Ievadiet auto numurzīmi");
            Number = Console.ReadLine();
            Console.WriteLine($"Ievadiet auto ātrumu");
            Speed = double.Parse(Console.ReadLine());
        }
        public string Mark { get; set; }
        public string Number { get; set; }
        public double Speed { get; set; }

        public void StartDrive()
        {
            Speed = 10;
            Console.WriteLine($"{Mark} ar numurzīmi {Number} uzsāk braukt ar ātrumu {Speed} km/h");
        }
        public void AddSpeed()
        {
            Console.WriteLine($"Ievadiet par cik km/h jāpalielina auto ātrums:");
            double addSpeed = double.Parse(Console.ReadLine());
            Speed += addSpeed; 
            Console.WriteLine($"{Mark} ar numurzīmi {Number} pārvietojas ar {Speed} km/h");
        }
        public void ReduceSpeed()
        {
            Console.WriteLine($"Ievadiet par cik km/h jāsamazina auto ātrums:");
            double reduceSpeed = double.Parse(Console.ReadLine());
            Speed -= reduceSpeed;
            Console.WriteLine($"{Mark} ar numurzīmi {Number} pārvietojas ar {Speed} km/h");
        }
        public void Stop()
        {
            Speed = 0;
            Console.WriteLine($"{Mark} ar numurzīmi {Number} ir apstājusies");
        }
        public void Beep()
        {
            Console.WriteLine($"Beep beep");
        }
    }
}
