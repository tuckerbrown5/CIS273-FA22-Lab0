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
			return false;
		}

        public Card GetFirstPlayableCard(Card card)
		{
			return new Card();
		}

        public Color MostCommonColor()
		{
			return Color.Blue;
		}


    }
}

