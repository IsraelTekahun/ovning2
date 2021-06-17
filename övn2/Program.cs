using System;

namespace övn2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Welcome to the main menu\nUse numbers to naviagte");
            Console.WriteLine("0 to quit");
            Console.WriteLine("1 enter age");
            Console.WriteLine("2 family");

            bool done = false;
            do
            {
                switch (Console.ReadLine())
                {
                    case "0":
                        done = true;
                        break;
                    case "1":
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
                        break;
                    case "2":
                        Console.WriteLine("How many people?");
                        int people = int.Parse(Console.ReadLine());
                        int counter = 0;
                        int totalPrice = 0;

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
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
            } while (!done);

        }
    }
}
