using System;

namespace Userdate
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust; 
            //programm kuvab kasutaja vanust konsoolis; 

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            Console.WriteLine($"Oled {userAge} aastat vana.");

        }
    }
}
