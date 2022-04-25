namespace ConsoleApp1
{
    public class Item
    {
        public Item()
        {
            Console.WriteLine($"Ievadiet preces garumu");
            Height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ievadiet preces platumu");
            Width = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ievadiet preces augstumu");
            Depth = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ievadiet preces svaru");
            Weight = double.Parse(Console.ReadLine());
        }
        public double Height { get; }
        public double Width { get; }
        public double Depth { get; }
        public double Weight { get; set; }

        public void NewItem()
        {
            Console.WriteLine($"Ievadiet jaunās preces nosaukumu:");
            string name = Console.ReadLine();
            //            Console.WriteLine($"Ar {Mark} {Model} ir iespējams veikt zvanus");
        }
        public void ShowItem()
        {
            Console.WriteLine($"Ievadītās preces parametri ir:");
            Console.WriteLine($"Garums: {Height}");
            Console.WriteLine($"Platums: {Width}");
            Console.WriteLine($"Augstums: {Depth}");
            Console.WriteLine($"Svars: {Weight}");

        }
    }
}