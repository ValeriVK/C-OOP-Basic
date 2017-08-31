namespace Exercise
{
    using System;
    using System.Reflection;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {           
            int peoples = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < peoples; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                var personName = personInfo[0];
                int personAge = int.Parse(personInfo[1]);

                var person = new Person(personName, personAge);
                family.AddMember(person);
            }

            var peoplesByAge = family.Members.OrderBy(p => p.Name).ThenByDescending(p => p.Age).Where(p => p.Age > 30).ToList();
            foreach (var person in peoplesByAge)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }            
        }
    }
}
