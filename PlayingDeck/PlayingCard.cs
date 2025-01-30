using System;
using System.Collections.Generic;

public class PlayingCard
{
    public string Suit;
    public string Value;
 
    public PlayingCard(string suit, string value)
    {
        Suit = suit;
        Value = value;
    }

    public PlayingCard()
    {
        Suit = "Joker";
        Value = "Joker";
    }
    public void PrintCard()
    {
        Console.WriteLine(Value + " of " + Suit);
    }
}

public class Deck
{
    public List<PlayingCard> Cards;

    public Deck()
    {
        Cards = new List<PlayingCard>();
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] values = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        foreach (string suit in suits)
        {
            foreach (string value in values)
            {
                Cards.Add(new PlayingCard(suit, value));
            }
        }

        Cards.Add(new PlayingCard());
    }

    public PlayingCard Draw()
    {
        PlayingCard topCard = Cards[0];
        Cards.RemoveAt(0);
        return topCard;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Deck deck = new Deck();

        PlayingCard card = deck.Draw();
        card.PrintCard();
    }
}
