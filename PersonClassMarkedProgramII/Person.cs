using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassMarkedProgramII
{
    public class Person
    {
        // Fields
        public string firstName;
        public string lastName;
        public string email;
        public DateTime dateOfBirth;

        // Constructors
        public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth) : this(firstName, lastName, "", dateOfBirth)
        {
        }

        public Person(string firstName, string lastName, string email) : this(firstName, lastName, email, DateTime.MinValue)
        {
        }

        // Read-only properties
        public bool Adult => CalculateAge(dateOfBirth) >= 18;

        public string SunSign
        {
            get
            {
                int day = dateOfBirth.Day;
                int month = dateOfBirth.Month;

                // Determine the sun sign based on the date of birth
                if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                    return "Aquarius";
                else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                    return "Pisces";
                else if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                    return "Aries";
                else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                    return "Taurus";
                else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                    return "Gemini";
                else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                    return "Cancer";
                else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                    return "Leo";
                else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                    return "Virgo";
                else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                    return "Libra";
                else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                    return "Scorpio";
                else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                    return "Sagittarius";
                else
                    return "Capricorn";
            }
        }

        public string ChineseSign
        {
            get
            {
                // Determine the Chinese zodiac sign based on the year of birth
                int year = dateOfBirth.Year;
                string[] chineseSigns = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep" };
                return chineseSigns[(year - 4) % 12];
            }
        }

        public bool IsBirthdayToday => dateOfBirth.Month == DateTime.Today.Month && dateOfBirth.Day == DateTime.Today.Day;

        // Helper method to calculate age
        private int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthDate.Year;
            if (now < birthDate.AddYears(age)) age--;
            return age;
        }
    }
}
