using Lab07_Collections.Classes;
using System;
using Xunit;

namespace Lab07_TDD
{

    public class CardTests
    {
        [Fact]
        public void TestCardConstructor()
        {
            Card card = new Card() { Face = Faces.Ace, Suit = Suits.Spades };
            string[] expected = { "Ace", "Spades" };
            string[] actual = { Convert.ToString(card.Face), Convert.ToString(card.Suit) };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFaceSetterGetter()
        {
            Card card = new Card();
            card.Face = Faces.Ace;
            Assert.Equal("Ace", Convert.ToString(card.Face));
        }

        [Fact]
        public void TestSuitSetterGetter()
        {
            Card card = new Card();
            card.Suit = Suits.Spades;
            Assert.Equal("Spades", Convert.ToString(card.Suit));
        }


    }
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
        public void TestRemoveCard()
        {
            Deck<Card> deck = new Deck<Card>();
            Card test = new Card(Faces.Ace, Suits.Spades);
            deck.Add(test);
            Assert.True(deck.Remove(test));
        }

        [Fact]
        public void TestRemoveCardThatDoesNotExist()
        {
            Deck<Card> deck = new Deck<Card>();
            Card test = new Card(Faces.Ace, Suits.Spades);
            deck.Add(test);
            Card test2 = new Card(Faces.Queen, Suits.Hearts);
            Assert.False(deck.Remove(test2));
        }
    }
}
