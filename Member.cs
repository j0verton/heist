using System;

namespace heist
{
    class Member
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }
        public Member(string name)
        {
            Name = name;
        }

        public string MemberInfo()
        {
            return @$"
            {Name}
            Skill Level: {SkillLevel}
            Courage Factor: {CourageFactor}";
        }
    }
}