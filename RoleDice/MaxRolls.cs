using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleDice
{
    public class MaxRolls
    {
        private const int NUM_SIDES = 6;
        
        /// <summary>
        /// Returns probability of getting maximum number for the given number of dice
        /// </summary>
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Enter number of dice or press -1 to exit!!");
                int totalDice = Convert.ToInt32(Console.ReadLine());
                int maxValue = 0;
                do
                {
                    Console.WriteLine("Enter the valid number you want to try : ");
                    maxValue = Convert.ToInt32(Console.ReadLine());
                } while (maxValue < totalDice || maxValue > totalDice * NUM_SIDES);

                if (totalDice < 0) break;
                int totalAttempts = 1;
                while (true)
                {
                    int rolledValue = this.GetNextNumber(totalDice);
                    if (rolledValue == maxValue) break;
                    Console.WriteLine("Rolled " + rolledValue);
                    totalAttempts++;
                }

                Console.WriteLine(string.Format("Rolled {0} after {1} attempts", maxValue, totalAttempts));
            }
        }

        private int GetNextNumber(int totalDice)
        {
            int totalValue = 0;

            for (int i = 0; i < totalDice; i++)
            {
                totalValue += RandomInstance.Next(1, NUM_SIDES + 1);
            }

            return totalValue;
        }

        private Random RandomInstance = new Random();
    }
}
