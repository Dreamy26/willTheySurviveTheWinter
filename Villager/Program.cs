using System;

namespace MockAssessment3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Town town = new Town();
            town.Harvest();
            town.SurviveTheWinter();

            Console.WriteLine("Hello World!");
        }
    }
}
