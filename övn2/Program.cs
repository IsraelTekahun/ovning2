using System;
using System.Text.RegularExpressions;

namespace övn2
{
    class Program
    {

        private static int calculateSinglePrice(int age)
        {
            int price = 0;

            Console.WriteLine();

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

        private static void showMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Enter 0 to quit");
            Console.WriteLine("Enter 1 get price");
            Console.WriteLine("Eneter 2 family");
            Console.WriteLine("-----------");
            Console.Write("choice: ");
        }
        private static String getPrice()
        {
            int age;

            Console.WriteLine();

            Console.Write("How many people? ");
            int people = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalPrice = 0;

            
            for (int i = 1; i <= people; i++)
            {
                Console.WriteLine();
                Console.Write($"Enter age for guest {i}: ");
                age = int.Parse(Console.ReadLine());

                totalPrice += calculateSinglePrice(age);

                counter++;

                Console.WriteLine();
                Console.WriteLine("----------------");
                Console.WriteLine($"{counter} guest(s): {totalPrice}kr");
                Console.WriteLine("----------------");
                Console.WriteLine();
            }

            return "  ";
        }
        static void Main(string[] args)
        {
            String input;
            String[] words;

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
                        Console.WriteLine("Give a random text");
                        input = Console.ReadLine();
                        for (int i = 1; i <= 10; i++)
                        {

                            Console.Write($"{i}. {input}" );
                            if(i < 10)
                                Console.Write(", ");
                        }

                        break;
                    case "3":
                        Console.WriteLine("Give a sentence with three words");
                        input = Console.ReadLine();

                        words = Regex.Split(input, "\\s+");

                        while (words.Length < 3)
                        {
                            Console.WriteLine("Give at least three words");
                            input = Console.ReadLine();
                            words = Regex.Split(input, "\\s+");
                        }

                     
                        Console.WriteLine($"The third word: {words[2]}");

                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
            } while (!done);

        }
    }
}
