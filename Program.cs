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

            Console.Write(HesitOneTeam.TeamInfo());


        }


    }
}
