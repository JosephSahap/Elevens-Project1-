using System.Collections.Generic;

public class Game
{
    private Deck deck;
    private Board board;
    private Player player;
    private bool isGameOver;

    public Game()
    {
        deck = new Deck();
        deck.Shuffle();
        board = new Board(deck);
        player = new Player();
        isGameOver = false;
    }

    public bool CheckMove(List<Card> selected)
    {
        if (selected.Count == 2)
        {
            return selected[0].Rank + selected[1].Rank == 11;
        }

        if (selected.Count == 3)
        {
            bool hasJ = false, hasQ = false, hasK = false;
            foreach (var card in selected)
            {
                if (card.Rank == 11) hasJ = true;
                else if (card.Rank == 12) hasQ = true;
                else if (card.Rank == 13) hasK = true;
            }
            return hasJ && hasQ && hasK;
        }

        return false;
    }

    public void PlayMove(List<Card> selected)
    {
        if (CheckMove(selected))
        {
            board.ReplaceCards(selected);
            player.ClearSelection();
        }
    }

    public bool IsWin()
    {
        return deck.IsEmpty() && board.GetFaceUpCards().Count == 0;
    }

    public bool IsLoss()
    {
        return !board.HasValidMove();
    }

    public void Restart()
    {
        deck = new Deck();
        deck.Shuffle();
        board = new Board(deck);
        player = new Player();
        isGameOver = false;
    }
}
