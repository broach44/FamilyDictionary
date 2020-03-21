using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Laura" }, { "age", "31" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Shellie" }, { "age", "61" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Russell" }, { "age", "deceased" } });

        // iterate over each item in myFamily and produce the following output:  "Krista is my sister and is 42 years old"
            foreach (var (familyMember, memberInfo) in myFamily)
	        {
                var memberName = "";
                var memberAge = "";
                foreach (var (personKey, personValue) in memberInfo)
                {
                    if (personKey == "name")
                    {
                        memberName = personValue;
                    }
                    else if (personKey == "age")
                    {
                        memberAge = personValue;
                    }
                }

                if (memberAge == "deceased")
                {
                    Console.WriteLine($"My {familyMember} is no longer with us...");
                }
                else
                {
                    Console.WriteLine($"{memberName} is my {familyMember} and is {memberAge} years old");
                }
            }

            Console.ReadLine();
        }
    }
}
