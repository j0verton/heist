using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Team HesitOneTeam = new Team();
            Console.WriteLine("Plan your Heist!");
            Console.WriteLine("How difficult is the Job?");
            int bDiff = Int32.Parse(Console.ReadLine());
            int successes = 0;
            int failures = 0;
            while (true)
            {
                Console.WriteLine("Enter your new Team member's name");
                Member recruit = new Member(Console.ReadLine());
                if (recruit.Name == "")
                {
                    break;
                }
                Console.WriteLine($"enter {recruit.Name}'s skill level");
                recruit.SkillLevel = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"enter {recruit.Name}'s courage factor");
                recruit.CourageFactor = double.Parse(Console.ReadLine());
                HesitOneTeam.Recruit(recruit);
            }

            Console.WriteLine("Your Team is Assembled!");

            Console.WriteLine("");
            Console.WriteLine("How many test runs should we do?");
            int runs = Int32.Parse(Console.ReadLine());
            // Console.WriteLine("Enter the Bank's Difficulty Level");
            while (runs > 0)
            {
                int LuckFactor = new Random().Next(-10, 11);
                int roundDiff = bDiff + LuckFactor;
                Console.WriteLine($"your teams skill is {HesitOneTeam.TeamSkill()}");
                Console.WriteLine($"The Bank's difficulty rating is {roundDiff}");
                if (HesitOneTeam.TeamSkill() >= roundDiff)
                {
                    Console.WriteLine("You did it!");
                    successes++;
                }
                else
                {
                    Console.WriteLine("busted...");
                    failures++;
                }
                runs--;
            }

            Console.WriteLine($"You succeeded {successes} times");
            Console.WriteLine($"You failed {failures} times");

        }


    }
}
