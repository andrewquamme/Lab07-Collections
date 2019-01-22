using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Card
    {
        public Faces Face { get; set; }
        public Suits Suit { get; set; }

        public Card() { }

        public Card(Faces face, Suits suit)
        {
            Face = face;
            Suit = suit;
        }

    }

    public enum Suits
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    };

    public enum Faces
    {
        Ace = 1,
        Two,
        Three, 
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    
}
