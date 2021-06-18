using System;
using System.Text.RegularExpressions;

namespace övn2
{
    class Program
    {
        private static bool isInteger(String input)
        {
            return int.TryParse(input, out int n);
        }


        private static void showMenu()
        {
            Console.WriteLine("\nEnter 0 to quit");
            Console.WriteLine("Enter 1 to get ticket for cinema");
            Console.WriteLine("Enter 2 to repeat a random text ten times");
            Console.WriteLine("Enter 3 to get third word in a sentence");
            Console.WriteLine("-----------");
            Console.Write("choice: ");
        }
        private static int calculateSinglePrice(int age)
        {
            int price = 0;

            if (age < 5 || age > 100)
            {
                Console.WriteLine("Free enterance");
            }
            else if (age < 20)
            {
                Console.WriteLine("Youth price: 80kr");
                price = 80;
            }
            else if (age > 64)
            {
                Console.WriteLine("pensioner price: 90kr");
                price = 90;
            }
            else
            {
                Console.WriteLine("Standard price: 120kr");
                price = 120;
            }

            return price;
        }
        private static void getPrice()
        {
            int age;

            Console.Write("\nHow many people? ");
            int people = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalPrice = 0;

            
            for (int i = 1; i <= people; i++)
            {
                Console.Write($"\nEnter age for guest {i}: ");

                while(!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.Write("Please enter a valide age: ");
                }

                Console.WriteLine("\n----------------");
                totalPrice += calculateSinglePrice(age);

                counter++;

                Console.WriteLine($"{counter} guest(s), total price: {totalPrice}kr");
                Console.WriteLine("----------------\n");
            }
        }


        private static void repeatText()
        {
            String input;
            Console.Write("\nGive a random text: ");
            input = Console.ReadLine();
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {

                Console.Write($"{i}. {input}");
                if (i < 10)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        private static void splitSentence()
        {

            String input;
            String[] words;
            Console.Write("\nGive a sentence with three or more words: ");
            input = Console.ReadLine();

            words = Regex.Split(input, "\\s+");

            while (words.Length < 3)
            {
                Console.WriteLine("Give at least three words");
                input = Console.ReadLine();
                words = Regex.Split(input, "\\s+");
            }


            Console.WriteLine($"\nThe third word is: {words[2]}");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the main menu\nUse numbers to naviagte");
            bool done = false;
            do
            {
                showMenu();
                switch (Console.ReadLine())
                {
                    case "0":
                        done = true;
                        break;
                    case "1":
                        getPrice();
                        break;
                    case "2":
                        repeatText();
                        break;
                    case "3":
                        splitSentence();
                        break;
                    default:
                        Console.WriteLine("\nWrong input: please enter 0 to 3");
                        break;
                }
            } while (!done);

            Console.WriteLine("\nGood bye!");

        }

    }
}
