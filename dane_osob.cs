using ConsoleApp2;
namespace dane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstname = "Janusz";
            person.lastname = "Nowak";
            person.weigth = 90.5F;
            person.height = 192;
            Console.WriteLine($"Dane użytkownika: \n{person.getdata()}");

            Person kowal = new Person();
            kowal.firstname = "Janusz";
            kowal.lastname = "Nowak";
            kowal.weigth = 90.5F;
            kowal.height = 192;
            Console.WriteLine($"Dane użytkownika: \n{kowal.getdata()}");
        }
    }
}
