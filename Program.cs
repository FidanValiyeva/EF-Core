using ConsoleApp16.Contexts;
using ConsoleApp16.Models;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            string choice;
            string name;
            string surname;
            int password;
            do
            {
                Console.WriteLine("1.Register 2.Login 0.Cixis");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":

                        Console.WriteLine("adini daxil et");
                        name = Console.ReadLine();
                        Console.WriteLine("soyadini daxil et");
                        surname = Console.ReadLine();

                        Console.WriteLine("sifreni daxil et");
                        bool ispassword = false;
                        do
                        {
                            ispassword = int.TryParse(Console.ReadLine(), out password);

                        } while (!ispassword);

                        
                        break;
                    case "2":
                        Console.WriteLine("adini daxil et");
                        name = Console.ReadLine();
                        Console.WriteLine("soyadini daxil et");
                        surname = Console.ReadLine();

                        Console.WriteLine("sifreni daxil et");
                        do
                        {
                            ispassword = int.TryParse(Console.ReadLine(), out password);

                        } while (!ispassword);
                        break;
                    case "0":

                        break;



                    default:
                        break;
                }



            } while (!f);


        }
    }
}
