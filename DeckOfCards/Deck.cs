using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Deck
    {
        public List<Card> deckNo1 = new List<Card>();
        public List<Card> deckNo2 = new List<Card>();

        public void PopulateDeck()
        {
            deckNo1 = GenerateCards(10);
            deckNo2 = GenerateCards(52);
        }

        private List<Card> GenerateCards(int cardCount)
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
