using System;

namespace IntroToCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                MockPerson mockPerson = new MockPerson();
                var beforeListOfPersons = mockPerson.GetListOfPerson();
                Console.WriteLine("Before:");
                foreach (var item in beforeListOfPersons)
                {
                    Console.WriteLine(item.FirstName + " - " + item.LastName + " - " + item.Id);
                }
                Console.WriteLine();
                int countBefore = mockPerson.Count;
                Console.WriteLine($"Total persons count is = {countBefore}");
                Console.WriteLine();
                Console.WriteLine("Now:");
                Person person = mockPerson.AddPerson(new Person() { FirstName = "Precious", LastName = "Wonkulah" });
                countBefore = mockPerson.Count;
                Console.WriteLine($"Total persons count is = {countBefore}");
                Console.WriteLine(  );
                foreach (var item in beforeListOfPersons)
                {
                    Console.WriteLine(item.FirstName + " - " + item.LastName + " - " + item.Id);
                }
                person = mockPerson.AddPerson(new Person() { FirstName = "Dacious", LastName = "Wonkulah" });
                countBefore = mockPerson.Count;
                Console.WriteLine();
                Console.WriteLine($"Total persons count is = {countBefore}");
                Console.WriteLine();
                foreach (var item in beforeListOfPersons)
                {
                    Console.WriteLine(item.FirstName + " - " + item.LastName + " - " + item.Id);
                }
                Console.WriteLine();
                person = mockPerson.Delete(1);
                countBefore = mockPerson.Count;
                Console.WriteLine($"Total persons count is = {countBefore}");
                foreach (var item in beforeListOfPersons)
                {
                    Console.WriteLine(item.FirstName + " - " + item.LastName + " - " + item.Id);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }

    }



}
