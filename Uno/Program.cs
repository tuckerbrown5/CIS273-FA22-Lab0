using Uno;

Card redSkip = new Card();

redSkip.Color = Color.Red;
redSkip.Type = CardType.Skip;


Card blue10 = new Card(CardType.Number, Color.Blue, 10);
Card yellowSkip = new Card(CardType.Skip, Color.Yellow);
Card wild = new Card(CardType.Wild, Color.Wild);
Card wildDraw4 = new Card(CardType.WildDraw4, Color.Wild);
Card greenReverse = new Card(CardType.Reverse, Color.Green);
Card redDraw2 = new Card(CardType.Draw2, Color.Red);

Console.WriteLine(blue10);
Console.WriteLine(yellowSkip);
Console.WriteLine(wild);
Console.WriteLine(wildDraw4);
Console.WriteLine(greenReverse);
Console.WriteLine(redDraw2);
