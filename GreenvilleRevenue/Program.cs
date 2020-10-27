using System;
using static System.Console;

//Name: James Shoemaker
//Date: 03/19/2020
//Program description: Week 1 GreenvilleRevenue assignment

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)

        //declare and initialize variables
        {
            int lastYearsContestants = 0;
            int thisYearsContestants = 0;

            const double EXPECTED_REVENUE = 500.00;

            //prompt user for values and capture values in variables

            Write("Enter number of contestants last year >> ");
            lastYearsContestants = Convert.ToInt32(ReadLine());

            Write("Enter number of contestants this year >> ");
            thisYearsContestants = Convert.ToInt32(ReadLine());

            WriteLine(" Last year's competition had {0} contestants, and this year's has {1} contestants", lastYearsContestants.ToString(), thisYearsContestants.ToString());

            WriteLine(" Revenue expected this year is {0}", EXPECTED_REVENUE.ToString("C"));

            if (lastYearsContestants > thisYearsContestants)
            {
                WriteLine(" It is true that last year's competition is larger than this year's. ");
            }

            if (lastYearsContestants == thisYearsContestants)
            {
                WriteLine(" There are the same amount of contestants this year as last year. ");
            }

            else
            {
                WriteLine(" This year's competition is larger. ");
            }






        }

        
          
        
    }
}
