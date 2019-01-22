using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Deck<T> : IEnumerable
    {
        public T[] cards = new T[5];
        int count = 0;

        /// <summary>
        /// Add item to deck collection
        /// </summary>
        /// <param name="item">item to add</param>
        public void Add(T item)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            cards[count] = item;
            count++;
        }

        /// <summary>
        /// Remove item from deck collection
        /// </summary>
        /// <param name="item">item to remove</param>
        public void Remove(T item)
        {
            T[] temp = new T[count - 1];
            int tempcount = 0;

            foreach (T card in cards)
            {
                if (card != null)
                {
                    if (!card.Equals(item))
                    {
                        temp[tempcount] = card;
                        tempcount++;
                    }
                }
            }
            cards = temp;
            count--;
        }

        /// <summary>
        /// Get current item count in deck collection
        /// </summary>
        /// <returns>count of items</returns>
        public int Count()
        {
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
