using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() 
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1,
        };

        private static int GetHandValue(List<Card> Hand)
        {
            int value = Hand.Sum(x => _cardValues[x.Face]);
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            if (value > 11 || aceCount < 1)
            {
                Console.WriteLine("Total: {0}", value);
                return value;
            }
            Console.WriteLine("Total: {0}", value + 10);
            return value + 10;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int value = GetHandValue(Hand);
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetHandValue(Hand);
            if (value > 21) return true;
            else return false;
        }
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int value = GetHandValue(Hand);
            if (value > 16 && value < 22)
            {
                return true;
            }
            return false;
        }
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int playerResults = GetHandValue(PlayerHand);
            int dealerResults = GetHandValue(DealerHand);
            if (playerResults > dealerResults)
            {
                return true;
            }
            else if (dealerResults > playerResults)
            {
                return false;
            }
            else
            {
                return null;
            }
        }
    }
}
