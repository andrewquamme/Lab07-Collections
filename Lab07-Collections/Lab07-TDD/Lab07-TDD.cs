using Lab07_Collections.Classes;
using System;
using Xunit;

namespace Lab07_TDD
{
    public class DeckTests
    {
        [Fact]
        public void TestAddCard()
        {
            Deck<Card> deck = new Deck<Card>
            {
                new Card() {Face=Faces.Ace, Suit=Suits.Spades }
            };
            Assert.Equal(1, deck.Count());
        }

        [Fact]
        public void TestCardSetter()
        {
            Card card = new Card() { Face = Faces.Ace, Suit = Suits.Spades };
            string[] expected = { "Ace", "Spades" };
            string[] actual = { Convert.ToString(card.Face), Convert.ToString(card.Suit) };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRemoveCard()
        {
            Deck<Card> deck = new Deck<Card>
            {
                new Card() {Face=Faces.Ace, Suit=Suits.Spades },
                new Card() {Face=Faces.Queen, Suit=Suits.Hearts},
                new Card() {Face=Faces.Jack, Suit=Suits.Clubs}
            };
            deck.Remove(deck.cards[1]);
            Assert.Equal(2, deck.Count());
        }
    }
}
