using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Team HesitOneTeam = new Team();
            Console.WriteLine("Plan your Heist!");
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
            // Console.WriteLine("Enter the Bank's Difficulty Level");
            int LuckFactor = new Random().Next(-10, 11);
            int bDiff = 100 + LuckFactor;
            Console.WriteLine($"your teams skill is {HesitOneTeam.TeamSkill()}");
            Console.WriteLine($"The Bank's difficulty rating is {bDiff}");
            if (HesitOneTeam.TeamSkill() >= bDiff)
            {
                Console.WriteLine("You did it!");
            }
            else
            {
                Console.WriteLine("busted...");
            }
        }


    }
}
