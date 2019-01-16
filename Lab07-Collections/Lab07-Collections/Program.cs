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
                new Card() {Face="Ace", Suit="Spades"},
                new Card() {Face="Queen", Suit="Hearts"}
            };
            foreach (Card card in deck)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }
            Deal(deck);
        }

        public static void Deal(Deck<Card> deck)
        {
            

        }
    }
}
