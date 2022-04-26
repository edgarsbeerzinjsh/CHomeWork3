namespace ConsoleApp1
{
    internal class Person
    {
        public Person()
        {
            Console.WriteLine($"Ievadiet vārdu");
            string name = Console.ReadLine();
            Console.WriteLine($"Ievadiet uzvārdu");
            string surname = Console.ReadLine();
            Console.WriteLine($"Ievadiet savu dzimšanas dienu (DD/MM/GG)");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Ievadiet kādu savu hobiju");
            string hobby = Console.ReadLine();
            Console.WriteLine($"Jūsu dzimums (V/S)");
            string man = Console.ReadLine();

            Name = name;
            Surname = surname;
            DateOfBirth = birthdate;
            Hobby = hobby;
            IsMale = man == "V";
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Hobby { get; set; }
        public bool IsMale { get; set; }
        public int Age { get; set; }
        public void YourAge()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - DateOfBirth.Year - 1;
            Age = age;
        }
        public void Greeting()
        {
            Console.WriteLine($"Sveiki, mani sauc {Name} {Surname} un es esmu {Age} gadus vecs");
        }

    }
}