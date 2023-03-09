using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1)
                return "Spades";
            if (value == 2)
                return "Hearts";
            if (value == 2)
                return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            // If it's a 1, return "Ace".
            if (value == 1)
                return "Ace";
            // If it's a 1, return "Jack".
            if (value == 11)
                return "Jack";
            // If it's a 1, return "Queen".
            if (value == 12)
                return "Queen";
            // If it's a 1, return "King".
            if (value == 13)
                return "King";
            // If we haven't returned yet, return the number converted to a string.
            return value.ToString();
        }
    }
}
