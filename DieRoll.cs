using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class DieRoll
    {
        public int playerPosition = 0;
        Random random = new Random();
        public int RollDie()
        {
            int dieCount = random.Next(1, 7);
            return dieCount;
        }
    }
}
