using System;
using Lab07_Collections.Classes;

namespace Lab07_Collections
{
    class Program
    {
    static void Main(string[] args)
        {
            Deck<Card> deck = new Deck<Card>
            {
                new Card() {Face="Ace", Suit=Suits.Spades },
                new Card() {Face="Queen", Suit=Suits.Hearts},
                new Card() {Face="Jack", Suit=Suits.Clubs}
            };

            deck.Add(new Card("2", Suits.Diamonds));
            deck.Add(new Card("3", Suits.Spades));
            deck.Add(new Card("4", Suits.Hearts));
            deck.Add(new Card("5", Suits.Clubs));
            deck.Add(new Card("5", Suits.Diamonds));
            deck.Add(new Card("4", Suits.Spades));
            deck.Add(new Card("3", Suits.Hearts));
            deck.Add(new Card("2", Suits.Clubs));

            Console.Write("Cards in Deck:");
            foreach (Card card in deck)
            {
                Console.Write($"[{card.Face} of {card.Suit}]");
            }
            Console.WriteLine();
            Deal(deck);
            Console.ReadLine();
        }

        public static void Deal(Deck<Card> deck)
        {
            Console.WriteLine("(Dealing Cards...)");
            Deck<Card> player1 = new Deck<Card>();
            Deck<Card> player2 = new Deck<Card>();

            int counter = 0;

            foreach (Card item in deck)
            {
                if  (counter % 2 == 0)
                {
                    player1.Add(item);
                }
                else
                {
                    player2.Add(item);
                }
                counter++;
            }

            Console.Write("Player 1 Hand: ");
            foreach (Card card in player1)
            {
                Console.Write($"[{card.Face} of {card.Suit}]");
            }
            Console.WriteLine();
            Console.Write("Player 2 Hand: ");
            foreach (Card card in player2)
            {
                Console.Write($"[{card.Face} of {card.Suit}]");
            }

        }
    }
}

/*Take cards out of deck and put into player decks
 * Print decks
 */ 
