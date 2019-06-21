using riley.domain.contracts;

namespace riley.domain.services
{
    public class MockDiceRoller : IRollDice
    {
        public int RollDie(int numSides)
        {
            return 11;
        }
    }
}