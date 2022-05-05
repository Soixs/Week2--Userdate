using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube taotelda"
            //Kui kasutaja on vanem, kui 18 siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilube taotelda"
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd saad juhilube taotelda!"

            Console.WriteLine("Palun sisesta oma sünniaasta:");

            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube taotelda.");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube taotelda.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad juhilube taotelda!");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
