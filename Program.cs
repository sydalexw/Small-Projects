using System;

namespace Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            string character = "";
            string name1 = "";
            int strengthB = 51;
            int lifeB= 1025;
            int lifeA = 0;
            int strengthA = 0;
                Console.WriteLine("Enter your name dude: ");
                name1 = Console.ReadLine();
            Console.WriteLine("Which cardset would you like to use?");
            Console.WriteLine("Blaine: \n Character: Blaine is a security Bard, use him for high defense! \n Attack: 20 \n Defense: 1200");
            Console.WriteLine("Will: \n Character: Will is a warrior, use him for high attack! \n Attack: 60 \n Defense: 950");
            Console.WriteLine("Kimmie: \n Character: Kimmie is an assassin, use them for a balanced set! \n Attack: 35 \n Defense: 1000");
            character = Console.ReadLine();



            if (character == "Blaine")
            {
                lifeA = 1200;
                strengthA = 20;
            }

            if (character == "Will")
            {
                lifeA = 950;
                strengthA = 60;
            }

            if (character == "Kimmie")
            {
                lifeA = 1000;
                strengthA = 35;
            }
            string response = "";


            while (lifeA > 0 && lifeB > 0)
            {
                Console.WriteLine(name1 + ": What do you want to do?");
                Console.WriteLine("Attack, Power Up, or Block?");
                response = Console.ReadLine();
                if (response == "Attack")
                {
                    lifeB = lifeB - strengthA;
                }
                if (response == "Power Up")
                {
                    strengthA = strengthA + 3;
                }
                if (response == "Block")
                {
                    strengthA = strengthA - strengthB / 2;
                    lifeB = lifeB - strengthA;
                }

                //2nd Player
                Console.WriteLine("Diana is deciding what to do!");
                Random rng = new Random();

                int AIchoice = rng.Next(1, 3);
                if (AIchoice == 1)
                {
                    lifeA = lifeA - strengthB;
                    Console.WriteLine("Diana Attacks!");
                }
                if (AIchoice == 2)
                {
                    strengthB = strengthB + 3;
                    Console.WriteLine("Diana is powering up");
                }
                if (AIchoice == 3)
                { 
                    strengthB = strengthB - strengthA / 2;
                    lifeA = lifeA - strengthB;
                    Console.WriteLine("Diana defends");
                }

                Console.WriteLine("Your health: " + lifeA);
                Console.WriteLine("Diana's health is at: " + lifeB);
                Console.WriteLine("Next Turn!!!");
        }

            if (lifeA >= lifeB)
        {
            Console.WriteLine("You won");
        }
            else
        {
            Console.WriteLine("You lost");
        }
    }



        }

        }



