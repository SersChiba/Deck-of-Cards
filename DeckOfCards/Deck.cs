using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Deck
    {
        private int deckSize { get; }
        public Deck()
        {
            deckSize = deckSize;
        }
        //public List<Card> PopulateDeck(int deckSize)
        //{
        //    return GenerateCards(deckSize);
        //   // deckNo2 = GenerateCards(52);
        //}
        public string GetCardNames()
        {
            foreach(var card in )
            return 
        }

        public List<Card> GenerateCards(int cardCount)
        {
            Random random = new Random();
            List<Card> generatedDeck = new List<Card>();
            for (int i = 0; i < cardCount; i++)
            {
                generatedDeck.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            }
            return generatedDeck;
        }        
    }
}
