using System;
namespace Uno
{
    public enum CardType
    {
        Number,
        Wild,
        Draw2,
        WildDraw4,
        Skip,
        Reverse
    }

    public enum Color
    {
        Red, Yellow, Blue, Green, Wild
    }

    public class Card
    {
        public CardType Type { get; set; }
        public Color Color { get; set; }
        public int? Number { get; set; }

        public Card()
        {
        }

        public Card(CardType type, Color color, int? number = null)
        {
            Type = type;
            Color = color;
            Number = number;
        }

        public static bool PlaysOn(Card card1, Card card2)
        {
            if (card2.Type == CardType.Wild)
            {
                return true;
            }
            if (card2.Type == CardType.WildDraw4)
            {
                return true;
            }
            if (card1.Type == CardType.Wild)
            {
                return true;
            }
            if (card1.Type == CardType.WildDraw4)
            {
                return true;
            }
            if (card2.Color == card1.Color) { return true; }
            if ((card1.Type != CardType.Skip) &&
                (card1.Type != CardType.Reverse) &&
                (card1.Type != CardType.Draw2) &&
                (card2.Type != CardType.Skip) &&
                (card2.Type != CardType.Reverse) &&
                (card2.Type != CardType.Draw2))
            {
                if (card2.Number == card1.Number)
                { return true; }
            }
            if (card2.Type == card1.Type)
            {
                if (card2.Type != CardType.Number) { return true; }

            }

            return false;

        }


        public override string ToString()
        {
            if (Type == CardType.Number)
            {
                return $"{Color} {Number}";
            }
            else if (Type == CardType.Wild)
            {
                return "Wild";
            }
            else if (Type == CardType.WildDraw4)
            {
                return Type.ToString();
            }
            else
            {
                return $"{Color} {Type}";
            }
        }

    }
}
