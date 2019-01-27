using System;
using Lab07_Collections.Classes;

namespace Lab07_Collections
{
    class Program
    {
    static void Main(string[] args)
        {
            Deck<Card> dealer = new Deck<Card>
            {
                new Card() {Face=Faces.Ace, Suit=Suits.Spades },
                new Card() {Face=Faces.Queen, Suit=Suits.Hearts},
                new Card() {Face=Faces.Jack, Suit=Suits.Clubs}
            };

            dealer.Add(new Card(Faces.Two, Suits.Diamonds));
            dealer.Add(new Card(Faces.Three, Suits.Spades));
            dealer.Add(new Card(Faces.Four, Suits.Hearts));
            dealer.Add(new Card(Faces.Five, Suits.Clubs));
            dealer.Add(new Card(Faces.Five, Suits.Diamonds));

            PrintCards("Cards in Deck: ", dealer);
            Card test = new Card(Faces.Two, Suits.Diamonds);
            dealer.Remove(test);
            PrintCards("Cards in Deck: ", dealer);
            Deal(dealer);
            Console.ReadLine();
        }

        /// <summary>
        /// Print cards in deck to console
        /// </summary>
        /// <param name="deckInfo">Info for deck being printed</param>
        /// <param name="deck">card deck</param>
        static void PrintCards(string deckInfo, Deck<Card> deck)
        {
            Console.WriteLine(deckInfo);
            foreach (Card card in deck)
            {
                Console.WriteLine($"[{card.Face} of {card.Suit}]");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Deal cards from dealer deck to player decks
        /// Deals evenly to two players
        /// </summary>
        /// <param name="deck">Deck to be dealt</param>
        public static void Deal(Deck<Card> deck)
        {
            Console.WriteLine("(Dealing Cards...)\n");
            Deck<Card> player1 = new Deck<Card>();
            Deck<Card> player2 = new Deck<Card>();

            int count = deck.Count();

            if(count %2 == 0)
            {
                //deck is even
                for (int i = count-1; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        player1.Add(deck.cards[i]);
                    }
                    else
                    {
                        player2.Add(deck.cards[i]);
                    }
                    deck.Remove(deck.cards[i]);
                }
            }
            else
            {
                //deck is odd
                for (int i = count - 1; i > 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        player1.Add(deck.cards[i]);
                    }
                    else
                    {
                        player2.Add(deck.cards[i]);
                    }
                    deck.Remove(deck.cards[i]);
                }
            }

            PrintCards("Player 1 Hand: ", player1);
            PrintCards("Player 2 Hand: ", player2);
            PrintCards("Dealer Hand: ", deck);
        }
    }
}