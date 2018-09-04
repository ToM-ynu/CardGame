using System;
using System.Collections.Generic;
using System.Text;

namespace Game_CUI
{
    class Deck
    {
        Queue<Card> cards;

        internal Deck()
        {
            cards = new Queue<Card>();
        }
        internal Card Draw()
        {
            if (cards.Count > 0)
                return cards.Dequeue();
            else
                throw new InvalidOperationException();
        }

    }
}
