using System;
using System.Collections.Generic;

namespace MockAssessment3
{
    public class Town
    {
        public List<Villager> Villagers { get; set; } = new List<Villager>();

        public Town()
        {
            Villagers.Add(new Farmer());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
        }

        public int Harvest()
        {
            int total = 0;
            foreach (var Villager in Villagers)
            {
                total += Villager.Farm();
                
            }
            
            return total;
        }
        public int CalcFoodConsumption()
        {
            int hungerTotal = 0;
            foreach (var Villager in Villagers)
            {
                hungerTotal += Villager.Hunger;
            }
            
            return hungerTotal;
        }
        public bool SurviveTheWinter()
        {

            //bool survive = Harvest() >= CalcFoodConsumption() ? true : false;
            //return survive;
            //Can condense even further
            //return Harvest() >= CalcFoodConsumption() ? true : false;

            int crops = Harvest();
            int foodEat = CalcFoodConsumption();

            if (foodEat <= crops)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
