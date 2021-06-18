using System;
using System.Text.RegularExpressions;

namespace övn2
{
    class Program
    {
        private static void showMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Enter 0 to quit");
            Console.WriteLine("Enter 1 get price");
            Console.WriteLine("Eneter 2 family");
            Console.WriteLine();
        }
            private static String getPrice()
        {
            int age;
            Console.WriteLine("How many people?");
            int people = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalPrice = 0;

            //gör det i en funktion
            if (people == 1)
            {

                Console.WriteLine("Age ?");
                age = int.Parse(Console.ReadLine());

                if (age < 5 || age > 100)
                {
                    Console.WriteLine("Free enterance");
                }
                else if (age < 20)
                {
                    Console.WriteLine("Youth price: 80kr");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Youth price: 90kr");
                }
                else
                {
                    Console.WriteLine("Youth price: 120kr");
                }

            }
            else if (people > 1)
            {
                for (int i = 1; i <= people; i++)
                {
                    Console.WriteLine($"Enter age for guest {i}");
                    age = int.Parse(Console.ReadLine());

                    if (age < 20)
                    {
                        totalPrice += 80;
                    }
                    else if (age > 64)
                    {
                        totalPrice += 90;
                    }
                    else
                    {
                        totalPrice += 120;
                    }
                    counter++;
                }
                Console.WriteLine($"{counter} people: {totalPrice}kr");

            }
            else
            {
                // 0 or less given
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


                        Console.WriteLine(getPrice());


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
