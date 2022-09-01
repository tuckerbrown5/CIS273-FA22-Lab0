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

		public Card(CardType type, Color color, int? number=null)
		{
			Type = type;
			Color = color;
			Number = number;
		}

		// Does card1 play on card2
		public static bool PlaysOn(Card card1, Card card2)
		{
			if(card2.Color == Color.Wild)
			{
				return false;
			}

			return true;

		}


		public override string ToString()
		{
			// Blue 4
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
				// Draw 2, Skip, Reverse
				return $"{Color} {Type}";
			}
		}

	}
}

