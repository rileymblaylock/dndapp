using System;
using riley.domain.contracts;

namespace riley.domain.services
{
    public class DiceRollerService : IRollDice
    {
        Random random;
        public DiceRollerService()
        {
            random = new Random();
        }
        public int RollDie(int numSides)
        {
            return random.Next(1, numSides + 1);
        }
    }
}