using System;
namespace Uno
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }


        public Player()
        {
            Name = "";
            Hand = new List<Card>();
        }

        public bool HasPlayableCard(Card card)
        {
            foreach (var handCard in Hand)
            {
                if (Card.PlaysOn(handCard, card))
                {
                    return true;
                }
            }

            return false;

        }


        public Card GetFirstPlayableCard(Card card)
        {
            foreach (var handCard in Hand)
            {
                if (Card.PlaysOn(handCard, card))
                {
                    return handCard;
                }
            }
            return null;
        }

        public Color MostCommonColor()
        {
            int redCounter = 0;
            int yellowCounter = 0;
            int blueCounter = 0;
            int greenCounter = 0;
            int wildCounter = 0;



            foreach (var Card in Hand)
            {
                if (Card.Color == Color.Red)
                {
                    redCounter = redCounter + 1;
                }
                else if (Card.Color == Color.Yellow)
                {
                    yellowCounter = yellowCounter + 1;
                }
                else if (Card.Color == Color.Blue)
                {
                    blueCounter = blueCounter + 1;
                }
                else if (Card.Color == Color.Green)
                {
                    greenCounter = greenCounter + 1;
                }
                else
                {
                    wildCounter = wildCounter + 1;
                }
            }

            int[] newArray = new int[5] { redCounter, yellowCounter, blueCounter, greenCounter, wildCounter };

            int x = newArray.Max();
            if (x == newArray[0])
            {
                return Color.Red;
            }
            else if (x == newArray[1])
            {
                return Color.Yellow;
            }
            else if (x == newArray[2])
            {
                return Color.Blue;
            }
            else if (x == newArray[3])
            {
                return Color.Green;
            }
            else
            {
                return Color.Wild;
            }

        }
    }
}
