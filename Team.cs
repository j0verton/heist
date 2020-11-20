using System;
using System.Collections.Generic;

namespace heist
{
    class Team
    {

        public List<Member> Members { get; set; } = new List<Member>();

        public void Recruit(Member member)
        {
            Members.Add(member);
        }
        public string TeamInfo()
        {
            string teamString = @"----------Your--Team---------";
            foreach (Member m in Members)
            {
                teamString += @$"{m.MemberInfo()}
                ---------------------------------";

            }
            return teamString;
        }
    }
}