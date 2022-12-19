/*
 * Program Name: Client List
 * Programmer: Luke Schreiber
 * Date: 12/19/2022
 *
 * program does : Creates a list of clients for your law firm
 * with specific age and names.
 */
namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "kane", "kevin", "kale", "kellen" };
            List<int> ages = new List<int>() { 32, 34, 91, 28 };

            Person person;
            for (int i = 0; i < names.Count; i++)
            {
                person = new Person(names[i], ages[i]);
                Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            }
        }
    }

}