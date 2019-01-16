using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Card
    {
        enum Suits
        {
            Hearts,
            Diamonds,
            Spades,
            Clubs
        };

        public string Face { get; set; }
        public string Suit { get; set; }

    }
}
