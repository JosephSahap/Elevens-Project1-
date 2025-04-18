public class Card
{
    public string Suit { get; }
    public int Rank { get; }

    public Card(string suit, int rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public bool IsFaceCard()
    {
        return Rank == 11 || Rank == 12 || Rank == 13;
    }

    public override string ToString()
    {
        string rankStr = Rank switch
        {
            1 => "A",
            11 => "J",
            12 => "Q",
            13 => "K",
            _ => Rank.ToString()
        };
        return rankStr + " of " + Suit;
    }
}
