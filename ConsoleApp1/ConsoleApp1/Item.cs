namespace ConsoleApp1
{
    public class Item
    {
        public Item(double height, double width, double depth, double weight)
        {
            Height = height;
            Width = width;
            Depth = depth;
            Weight = weight;
        }
        public double Height { get; }
        public double Width { get; }
        public double Depth { get; }
        public double Weight { get; }

        public void NewItem()
        {
            //Console.WriteLine($"Ievadiet preces garumu");
            //double height = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Ievadiet preces platumu");
            //double width = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Ievadiet preces augstumu");
            //double depth = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Ievadiet preces svaru");
            //double weight = double.Parse(Console.ReadLine());
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