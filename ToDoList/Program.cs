namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd TODO");
            Console.WriteLine("[R]emove TODO");
            Console.WriteLine("[E]xit");

            var userChoise = Console.ReadLine();

            if (userChoise == "S")
            {
                PrintSelectedOption("See all TODOs");
            }
            else if (userChoise == "A")
            {
                PrintSelectedOption("Add TODO");
            }
            else if (userChoise == "R")
            {
                PrintSelectedOption("Remove TODO");
            }
            else if (userChoise == "E")
            {
                PrintSelectedOption("Exit");
            }

            void PrintSelectedOption(string selectedOption)
            {
                Console.WriteLine("Selected option: " + selectedOption);
            }
        }
    }
}
