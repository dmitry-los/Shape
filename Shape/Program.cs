using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthdate = new DateTime(1994, 4, 5);
            Console.WriteLine(birthdate);
            // Save today's date.
            var now = DateTime.UtcNow;
            // Calculate the age.
            var age = now.Year - birthdate.Year;
            // Do stuff with it.
            if (birthdate.AddYears(age) > now)
                age--;

            Console.WriteLine(age);
            Console.ReadKey();
        }
    }
}
