using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Card
    {
        public string Face { get; set; }
        public Suits Suit { get; set; }

        public Card() { }

        public Card(string face, Suits suit)
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
    
}
