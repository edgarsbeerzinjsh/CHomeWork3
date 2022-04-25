namespace ConsoleApp1
{
    public class Telephone
    {
        public Telephone()
        {
            Console.WriteLine($"Ievadiet telefona marku");
            Mark = Console.ReadLine();
            Console.WriteLine($"Ievadiet telefona modeli");
            Model = Console.ReadLine();
            Console.WriteLine($"Ievadiet telefona garuma izmēru");
            Height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ievadiet telefona platuma izmēru");
            Width = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ievadiet telefona augstuma izmēru");
            Depth = double.Parse(Console.ReadLine());
        }
        public string Mark { get; set; }
        public string Model { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public void Call()
        {
            Console.WriteLine($"Ar {Mark} {Model} ir iespējams veikt zvanus");
        }
        public void Sms()
        {
            Console.WriteLine($"Ar {Mark} {Model} ir iespējams sūtīt SMS");
        }
        
    }
}
