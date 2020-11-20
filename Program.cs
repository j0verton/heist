using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");

            Console.WriteLine("Enter a Team member's name");
            Member NumberOne = new Member(Console.ReadLine());
            Console.WriteLine($"enter {NumberOne.Name}'s skill level");
            NumberOne.SkillLevel = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"enter {NumberOne.Name}'s courage factor");
            NumberOne.CourageFactor = double.Parse(Console.ReadLine());

            Console.WriteLine("Your Team");
            Console.WriteLine("----------");
            Console.WriteLine(NumberOne.Name);
            Console.WriteLine($"Skill Level: {NumberOne.SkillLevel}");
            Console.WriteLine($"Courage Factor: {NumberOne.CourageFactor}");
        }

        class Member
        {
            public string Name { get; set; }
            public int SkillLevel { get; set; }
            public double CourageFactor { get; set; }
            public Member(string name)
            {
                Name = name;
            }
        }
    }
}
