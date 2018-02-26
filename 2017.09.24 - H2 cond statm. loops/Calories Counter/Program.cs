using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            string ingredient = string.Empty;
            int totalCaloriesAmount = 0;

            for (int i = 0; i < numberOfIngredients; i++)
            {
                ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese")
                    totalCaloriesAmount = totalCaloriesAmount + 500;
                if (ingredient == "salami")
                    totalCaloriesAmount += 600;
                if (ingredient == "pepper")
                    totalCaloriesAmount += 50;
                if (ingredient == "tomato sauce")
                    totalCaloriesAmount += 150;
            }
            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
