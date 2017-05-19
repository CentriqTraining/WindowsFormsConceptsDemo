using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseObjects.Entities
{
    public static class RandomGenerator
    {
        private static Random rand;
        static RandomGenerator()
        {
            rand = new Random();
        }
        public static decimal GetDecimal(decimal minValue = 1, decimal maxValue = 500)
        {
            int LowRange = (int)(minValue * 100);
            int HighRange = (int)(maxValue * 100);

            var Number = rand.Next(LowRange, HighRange);

            return Number / 100.00m;
        }
        public static int GetInt(int minValue = 1, int maxValue = 500)
            => rand.Next(minValue, maxValue);
    }
}
