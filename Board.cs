using System.Collections.Generic;

public class Board
{
    private List<Card> faceUpCards;
    private Deck deck;

    public Board(Deck deck)
    {
        this.deck = deck;
        faceUpCards = new List<Card>();
    }

    public List<Card> GetFaceUpCards()
    {
        return faceUpCards;
    }

    public bool HasValidMove()
    {
        return false;
    }

    public void ReplaceCards(List<Card> selected)
    {
    }
}
