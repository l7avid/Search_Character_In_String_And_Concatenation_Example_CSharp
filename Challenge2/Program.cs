namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            string inputString = Console.ReadLine();
            Console.Write("Enter a character to search: ");
            char characterToSearch = Console.ReadLine()[0];
            int indexFound = inputString.IndexOf(characterToSearch);
            Console.WriteLine($"The matching index for the character searched is {indexFound}");

            //Concatenation
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastname = Console.ReadLine();
            string fullname = name + " " + lastname;
            Console.WriteLine(fullname);
        }
    }
}