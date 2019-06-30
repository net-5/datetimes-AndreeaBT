using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace DateTimeHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayDateTime();
            AddNYears();
            HumanFriendlyDate();
            FiveMillisecondAdded();
            TimeInMilliseconds();
            AddSixMonths();
            FirstAndLastSecond();
            TwoDateDifferenceInSeconds();
            CalculateAge();
            NumberOfDaysBetweenTwoDates();
            ThirtyDaysBeforeAndAfterDate();
            YesterdayTodayTomorow();
            PrintNextFiveDays();
            GetDaysBetweenTwoDates();
            SundaysOfaSpecifiedYear();
        }

        public static void DisplayDateTime()
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            int numberOfWeek = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(currentDate, CalendarWeekRule.FirstDay, DayOfWeek.Tuesday);
            if (currentDate.Year % 4 == 0)
            {
                Console.WriteLine($" The year {currentDate.Year} is a leap year.");
            } else if (currentDate.Year % 4 != 0)
            {
                Console.WriteLine($"The year {currentDate.Year} is not a leap year.");
            }

            Console.WriteLine($"The date and time today is {currentDate}");
            Console.WriteLine($"We are in the year {currentDate.Year}");
            Console.WriteLine($"The current month is {currentDate.Month}");
            Console.WriteLine($"The current week of year : {numberOfWeek}");
            Console.WriteLine($"Today is {currentDate.DayOfWeek}");
            Console.WriteLine($"The day's number from this year is : {currentDate.DayOfYear}");
            Console.WriteLine($"Today is {currentDate.DayOfWeek}");
            
        }
        public static void AddNYears()
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            Console.WriteLine($"The date in 6 years will be {currentDate.AddYears(6)}");

        }
        public static void HumanFriendlyDate()
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            Console.WriteLine($"The year is {currentDate.Year}, the month is {currentDate.Month}, the day is {currentDate.Day} and the time is {currentDate.TimeOfDay}");

        }
        public static void FiveMillisecondAdded()
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            Console.WriteLine($"The current time {currentDate} with 5 milliseconds added is : {currentDate.AddMilliseconds(5)}");
        }
        public static void TimeInMilliseconds()
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            Console.WriteLine($"The current time in milliseconds is {currentDate.Ticks}");
        }
        public static void AddSixMonths()
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            Console.WriteLine($"The date in 6 months will be {currentDate.AddMonths(6)}");
        }
        public static void FirstAndLastSecond()
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime timeMin = currentDateTime.Date;
            DateTime timeMax = currentDateTime.Date.AddDays(1).AddTicks(-1);
            Console.WriteLine($"The start of the day : {timeMin} and the end of the day: {timeMax}");
        }
        public static void TwoDateDifferenceInSeconds()
        {
            DateTime First = new DateTime(2000, 01, 01);
            DateTime Second = new DateTime(2019, 06, 28);
            TimeSpan Result = Second.Subtract(First);
            Console.WriteLine($"The difference between two dates in milliseconds is : { Result.Ticks}");
        }


        public static void CalculateAge()
        {
            DateTime First = new DateTime(1990,03,24);
            DateTime Second = new DateTime(2019,06,29);
            int Age = Second.Year - First.Year;
            Console.Write($"My age is : {Age} years.");
        }

       
        public static void NumberOfDaysBetweenTwoDates()
        {
            DateTime First = new DateTime(2019, 06, 26);
            DateTime Second = new DateTime(2019, 06, 29);
            TimeSpan Days = Second.Subtract(First);

            Console.WriteLine($"\nNumber of days between {First} and {Second} are {Days.TotalDays} days.");
        }
        public static void ThirtyDaysBeforeAndAfterDate()
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            Console.WriteLine($"The date with 30 days before the current date is : {currentDate.AddDays(-30)}" +
                $" and the date with 30 days after the current date is: { currentDate.AddDays(30)}");

        }

        public static void YesterdayTodayTomorow()
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            Console.WriteLine($"Yesterday : {currentDate.AddDays(-1)}, Today : {currentDate}, Tomorrow : {currentDate.AddDays(1)}");
           
        }
        public static void PrintNextFiveDays()
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            Console.WriteLine($"The dates of the next five days are : {currentDate.DayOfWeek}, " +
                $"{currentDate.AddDays(1).DayOfWeek}, {currentDate.AddDays(2).DayOfWeek}, {currentDate.AddDays(3).DayOfWeek}," +
                $" {currentDate.AddDays(4).DayOfWeek}");

        }
        
        public static void GetDaysBetweenTwoDates()
        {

            DateTime FirstDate = new DateTime(2019, 06, 20);
            DateTime SecondDate = new DateTime(2019, 06, 29);
            TimeSpan Days = SecondDate.Subtract(FirstDate);
            Console.WriteLine($"The number of days between {FirstDate}({FirstDate.DayOfWeek}) and {SecondDate}({SecondDate.DayOfWeek}) are {Days.TotalDays} days.");
        }

        public static void SundaysOfaSpecifiedYear()
        {
            var start = new DateTime(DateTime.UtcNow.Year, 1, 1);
            var end = start.AddYears(1);
            Console.WriteLine("The dates for all the sundays from this year are : ");
            while (start < end)
            {
                if (start.DayOfWeek == DayOfWeek.Sunday)
                {
                   
                    Console.WriteLine(start);
                    start = start.AddDays(7);
                }
                else
                    start = start.AddDays(1);
            }
            
        }


        
                    
            
    } 
}
