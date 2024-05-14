using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassMarkedProgramII
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPersonClass();
        }

        static void TestPersonClass()
        {
            // Test the Person class
            Person person1 = new Person("Kanjula", "Gunathilaka", "Kanjula@example.com", new DateTime(1990, 6, 2));
            Person person2 = new Person("Chandi", "Herath", "Herath@example.com", new DateTime(2005, 5, 2));

            Console.WriteLine("Person 1:");
            Console.WriteLine($"Name: {person1.firstName} {person1.lastName}");
            Console.WriteLine($"Email: {person1.email}");
            Console.WriteLine($"Date of Birth: {person1.dateOfBirth}");
            Console.WriteLine($"Adult: {person1.Adult}");
            Console.WriteLine($"Sun Sign: {person1.SunSign}");
            Console.WriteLine($"Chinese Sign: {person1.ChineseSign}");
            Console.WriteLine($"Birthday today: {person1.IsBirthdayToday}");

            Console.WriteLine("\nPerson 2:");
            Console.WriteLine($"Name: {person2.firstName} {person2.lastName}");
            Console.WriteLine($"Email: {person2.email}");
            Console.WriteLine($"Date of Birth: {person2.dateOfBirth}");
            Console.WriteLine($"Adult: {person2.Adult}");
            Console.WriteLine($"Sun Sign: {person2.SunSign}");
            Console.WriteLine($"Chinese Sign: {person2.ChineseSign}");
            Console.WriteLine($"Birthday today: {person2.IsBirthdayToday}");
        }
    }
}