using System;
using System.Collections.Generic;

public class Deck
{
    private List<Card> cards;
    private static readonly string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

    public Deck()
    {
        cards = new List<Card>();
        foreach (string suit in suits)
        {
            for (int rank = 1; rank <= 13; rank++)
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    public void Shuffle()
    {
        Random rng = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }
    }

    public Card DrawCard()
    {
        if (IsEmpty()) return null;
        Card top = cards[0];
        cards.RemoveAt(0);
        return top;
    }

    public bool IsEmpty()
    {
        return cards.Count == 0;
    }
}
