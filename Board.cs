using System.Collections.Generic;

public class Board
{
    private List<Card> faceUpCards;
    private Deck deck;

    public Board(Deck deck)
    {
        this.deck = deck;
        faceUpCards = new List<Card>();
        for (int i = 0; i < 9; i++)
        {
            Card drawn = deck.DrawCard();
            if (drawn != null)
            {
                faceUpCards.Add(drawn);
            }
        }
    }

    public List<Card> GetFaceUpCards()
    {
        return faceUpCards;
    }

    public void ReplaceCards(List<Card> selected)
    {
        foreach (Card card in selected)
        {
            int index = faceUpCards.IndexOf(card);
            if (index != -1)
            {
                Card newCard = deck.DrawCard();
                if (newCard != null)
                {
                    faceUpCards[index] = newCard;
                }
                else
                {
                    faceUpCards.RemoveAt(index);
                }
            }
        }
    }

    public bool HasValidMove()
    {
        for (int i = 0; i < faceUpCards.Count; i++)
        {
            for (int j = i + 1; j < faceUpCards.Count; j++)
            {
                if (faceUpCards[i].Rank + faceUpCards[j].Rank == 11)
                {
                    return true;
                }
            }
        }

        for (int i = 0; i < faceUpCards.Count; i++)
        {
            for (int j = i + 1; j < faceUpCards.Count; j++)
            {
                for (int k = j + 1; k < faceUpCards.Count; k++)
                {
                    bool hasJ = false, hasQ = false, hasK = false;
                    int[] ranks = { faceUpCards[i].Rank, faceUpCards[j].Rank, faceUpCards[k].Rank };
                    foreach (int rank in ranks)
                    {
                        if (rank == 11) hasJ = true;
                        else if (rank == 12) hasQ = true;
                        else if (rank == 13) hasK = true;
                    }
                    if (hasJ && hasQ && hasK)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}