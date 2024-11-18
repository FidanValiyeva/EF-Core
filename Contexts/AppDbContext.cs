using ConsoleApp16.Helper.Exceptions;
using ConsoleApp16.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Contexts
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Basket> basket { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS03;Database=EFCore;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public static void Register(string name, string surname, int password)
        {
            Console.WriteLine("İstifadəçi adı: ");

            if (Users.Exists(x => x.Name == name))
            {
                Console.WriteLine("bu istifadeci artiq movcuddur!");
                return;
            }
            else
            {
                Console.WriteLine("ad ugurla qebul olundu");
            }


            Console.WriteLine("İstifadəçi soyadı:");

            if (Users.Exists(x => x.Surname == surname))
            {
                Console.WriteLine("bu istifadeci artiq movcuddur!");
                return;
            }
            else
            {
                Console.WriteLine("soyad ugurla qebul olundu");
            }
            Console.WriteLine("password:");
            if (Users.Exists(x => x.Password == password))
            {
                Console.WriteLine("bu sifre artiq movcuddur!");
                return;
            }
            else
            {
                Console.WriteLine("sifre ugurla qebul olundu");
            }
        }
        public static void Login(string name, string surname, int password)
        {
            if (Users.Exists(x => x.Name == name))
            {
                Console.WriteLine("bu istifadeci artiq movcuddur!");
                return;
            }
            else
            {
                throw new UserNotFoundException("mehsul tapilmadi");
            }

            if (Users.Exists(x => x.Surname == surname))
            {
                Console.WriteLine("bu istifadeci artiq movcuddur!");
                return;
            }
            else
            {
                throw new UserNotFoundException("mehsul tapilmadi");
            }
            Console.WriteLine("password:");
            if (Users.Exists(x => x.Password == password))
            {
                Console.WriteLine("bu sifre artiq movcuddur!");
                return;
            }
            else
            {
                throw new UserNotFoundException("mehsul tapilmadi");
            }

        }
    }
}
