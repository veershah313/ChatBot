using System;

namespace ChatBot___Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Allow me to introduce myself. I'm a chatbot and my name is Mike.");
            Console.Write("What is your name:");
            string name = Console.ReadLine();
            Console.WriteLine("It's is nice to meet you, " + name);

            int age = 0;
            Console.Write("How old are you: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi " + name + " you are " + age.ToString());

            Console.Write("What's your hobby: ");
            string hobby = Console.ReadLine();
            Console.WriteLine("That sounds fun. I wish I could " + hobby + ". Maybe you can teach me?");

            Console.Write("What's your favourite food: ");
            string food = Console.ReadLine();
            Console.WriteLine("I also enjoy eating " + food);

            Console.Write("What's your job: ");
            string job = Console.ReadLine();
            Console.WriteLine("I also wanted to become a " + job + " when I was younger but now I have to be a computer.");

            Console.WriteLine("Are you hungry?");
            string imHungry = Console.ReadLine();

            if (imHungry.ToLower() == "yes")
            {
                Console.WriteLine("I will order something, what would you like?");
                string myFood = Console.ReadLine();
                Console.WriteLine("I will order you " + myFood);
                Console.WriteLine("*Food is on the table*");
                Console.WriteLine("My pizza is amazing how is your " + myFood);
                Console.ReadLine();
                Console.WriteLine("I think I'm going to pay now. How much does it cost?");
                double money = 0;
                money = double.Parse(Console.ReadLine());
                Console.WriteLine("Ok, I will pay " + money + " for the lovely food");
                Console.WriteLine("Thank you for the lovely evening I have had a pleasure meeting you " + name);

            }
            else
            {
                Console.WriteLine("Ok, I will order in a bit if that is fine by you?");
                Console.ReadLine();
                Console.Write("When's your birthday:");
                string BDay = Console.ReadLine();
                Console.WriteLine("That's lucky mine is close to that.");
                Console.Write("What school do you go to:");
                Console.ReadLine();
                Console.WriteLine("Are you hungry now?");
                string Hunger = Console.ReadLine();

                if (Hunger.ToLower() == "yes")
                {
                    Console.WriteLine("I will order something, what would you like?");
                    string myFood = Console.ReadLine();
                    Console.WriteLine("I will order you " + myFood);
                    Console.WriteLine("*Food is on the table*");
                    Console.WriteLine("My pizza is amazing how is your " + myFood);
                    Console.ReadLine();
                    Console.WriteLine("I think I'm going to pay now. How much does it cost?");
                    double money = 0;
                    money = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ok, I will pay " + money + " for the lovely food");
                    Console.WriteLine("Thank you for the lovely evening I have had a pleasure meeting you " + name);
                }
               
            }

            

        }

    }

}


