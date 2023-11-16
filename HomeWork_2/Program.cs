using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* დაწერეთ კონსოლს აპლიკაცია სადაც მომხარებელს ექნება საშუალება შეიტანოს მთელი რიცხვი ,
             * პროგრამამ უნდა გაარკვიოს ეს რიცხვი ლუწია თუ კენტი და იმის მიხედვით
             * დაბეჭდოს შესაბამისი შეტყობინება .*/

            Console.WriteLine("enter number");
            int userinput = int.Parse(Console.ReadLine());
            if (userinput >= 0)
            {
                if (userinput % 2 == 0)
                {
                    Console.WriteLine($"entered number {userinput} is even ");
                }
                else if (userinput % 2 == 1)
                {
                    Console.WriteLine($"entered number {userinput} is odd");
                }
            }
            else
            {
                Console.WriteLine("something goes wrong try again:");
            }


            //------------------------------------------------------------------------------------------------
            /* დაწერეთ კონსოლ აპლიკაცია სადაც მომხმარებელს ექნება საშუალება შეიტანოს სამი რიცხვი მორიგეობით,
             * პროგრამა კი დაუბეჭდავს შემოტანილი პარამეტრების გათვალისწინებით შესაძლებელია თუ არა ეს სამი რიცხვი
             * იყოს სამკუთხედის გვერდები */

            Console.WriteLine("Enter first number");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int C = int.Parse(Console.ReadLine());
            if (A > 0 & B > 0 & C > 0)
            {
                if (A + B > C & A + C > B & B + C > A)
                {
                    Console.WriteLine("This should be a triangle !");
                }
                else
                {
                    Console.WriteLine("It cannot be a triangle");
                }
            }
            else
            {
                Console.WriteLine("Something goes wrong try again");
            }


            //--------------------------------------------------------------------------------------
            /*დაწერეთ კონსოლ აპლიკაცია სადაც მომხარებელს ექნება საშუალება შეიტანოს რიცხვი ,
             ხოლო პროგრამა დაბეჭდავს მის კვადრატულ ხარისხს */


            Console.WriteLine("Enter Number : ");
            double Number = int.Parse(Console.ReadLine());
            if (Number > 1)
            {
                double power = Math.Pow(Number, 2);
                Console.WriteLine($"The pow of the entered number is {power}");
            }
            else
            {
                Console.WriteLine("Enter a number greater than 1");
            }


            //-----------------------------------------------------------------------------------------
            /*დაწერეთ კონსოლ აპლიკაცია სადაც მომხარებელი შეიტანს დაბადების წელს
             * და ეტყვის /ჩინური კალენდრის მიხედვით რის წელშია დაბდებული*/


            Console.WriteLine("enter your birthday year :");
            int year = int.Parse(Console.ReadLine());
            int startDate = 1900;
            int Chinese = (year - startDate) % 12;
            switch (Chinese)
            {
                case 0:
                    Console.WriteLine($"{year} was Rat year");
                    break;
                case 1:
                    Console.WriteLine($"{year} was Ox year");
                    break;
                case 2:
                    Console.WriteLine($"{year} was Tiger year");
                    break;
                case 3:
                    Console.WriteLine($"{year} was Rabbit year");
                    break;
                case 4:
                    Console.WriteLine($"{year} was Dragon year");
                    break;
                case 5:
                    Console.WriteLine($"{year} was Snake year");
                    break;
                case 6:
                    Console.WriteLine($"{year} was Horse year");
                    break;
                case 7:
                    Console.WriteLine($"{year} was Goat year");
                    break;
                case 8:
                    Console.WriteLine($"{year} was Monkey year");
                    break;
                case 9:
                    Console.WriteLine($"{year} was Rooster year");
                    break;
                case 10:
                    Console.WriteLine($"{year} was Dog year");
                    break;
                case 11:
                    Console.WriteLine($"{year} was Pig year");
                    break;
                default:
                    Console.WriteLine("Invalid year , try again");
                    break;
            }

            //-------------------------------------------------------------------------------------------
            /*დაწერეთ კონსოლ აპლიკაცია სადაც გადავცემთ დაბადების დღეს და თვეს და გვიბრუნებს ჩვენ ზოდიაქოს*/


            Console.WriteLine("Enter your day of birth: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your month of birth: ");
            string month = Console.ReadLine().ToLower();

            if ((month == "march" && day >= 21) || (month == "april" && day <= 19))
                Console.WriteLine($"{day}  {month} is Aries");

            else if ((month == "april" && day >= 20) || (month == "may" && day <= 20))
                Console.WriteLine($"{day}  {month} is Taurus");
            else if ((month == "may" && day >= 21) || (month == "june" && day <= 20))
                Console.WriteLine($"{day}  {month} is Gemini");
            else if ((month == "june" && day >= 21) || (month == "july" && day <= 22))
                Console.WriteLine($"{day}  {month} is Cancer");
            else if ((month == "july" && day >= 23) || (month == "august" && day <= 22))
                Console.WriteLine($"{day}  {month} is Leo");
            else if ((month == "august" && day >= 23) || (month == "september" && day <= 22))
                Console.WriteLine($"{day}  {month} is Virgo");
            else if ((month == "september" && day >= 23) || (month == "october" && day <= 22))
                Console.WriteLine($"{day}  {month} is Libra");
            else if ((month == "october" && day >= 23) || (month == "november" && day <= 21))
                Console.WriteLine($"{day}  {month} is Scorpio");
            else if ((month == "november" && day >= 22) || (month == "december" && day <= 21))
                Console.WriteLine($"{day}  {month} is Sagittarius");
            else if ((month == "december" && day >= 22) || (month == "january" && day <= 19))
                Console.WriteLine($"{day}  {month} is Capricorn");
            else if ((month == "january" && day >= 20) || (month == "february" && day <= 18))
                Console.WriteLine($"{day}  {month} is Aquarius");
            else if ((month == "february" && day >= 19 || (month == "march" && day <= 20)))
                Console.WriteLine($"{day}  {month} is Pisces");
            else
            {
                Console.WriteLine("Something goes wrong try again");
            }


        }
    }



}
