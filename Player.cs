using System.Collections.Generic;

public class Player
{
    private List<Card> selectedCards;

    public Player()
    {
        selectedCards = new List<Card>();
    }

    public void SelectCard(Card card)
    {
        if (!selectedCards.Contains(card))
        {
            selectedCards.Add(card);
        }
    }

    public void ClearSelection()
    {
        selectedCards.Clear();
    }

    public List<Card> GetSelectedCards()
    {
        return selectedCards;
    }
}
