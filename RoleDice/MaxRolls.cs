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
            int totalDice = Convert.ToInt32(Console.ReadLine());
            int maxValue = totalDice * NUM_SIDES;
            int totalAttempts = 1;
            while (true)
            {
                int rolledValue = this.GetNextNumber(totalDice);
                if (rolledValue == maxValue) break;
                Console.WriteLine("Rolled " + rolledValue);
                totalAttempts++;
            }

            Console.WriteLine(string.Format("Rolled {0} after {1} attempts", maxValue, totalAttempts));
            Console.ReadLine();
        }

        private int GetNextNumber(int totalDice)
        {
            int totalValue = 0;

            for (int i = 0; i < totalDice; i++)
            {
                totalValue += RandomInstance.Next(0, NUM_SIDES + 1);
            }

            return totalValue;
        }

        private Random RandomInstance = new Random();
    }
}
