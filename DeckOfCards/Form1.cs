using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfCards
{
    public partial class Form1 : Form
    {
        Deck deckNo1;
        Deck deckNo2;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }
        //public void PopulateDeck()
        //{
        //    deckNo1 = GenerateCards(10);
        //    deckNo2 = GenerateCards(52);
        //}
        //public void PopulateDeck(int deckNumber)
        //{
        //    if (deckNumber == 1)
        //        deckNo1 = GenerateCards(10);
        //    else if (deckNumber == 2)
        //        deckNo2 = GenerateCards(52);
        //}
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
        private void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                int numberOfCards = random.Next(1, 11);
                deckNo1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    deckNo1.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
                }
                deckNo1.Sort();
            }
            else if (deckNumber == 2)
                deckNo2 = new Deck();
        }
        private void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                deck1.Items.Clear();
                foreach (string cardName in deckNo1.GetCardNames())
                    deck1.Items.Add(cardName);
                label1.Text = "Deck #1 (" + deckNo1.Count + " cards)";
            }
            else if (deckNumber == 2)
            {
                deck2.Items.Clear();
                foreach (string cardName in deckNo2.GetCardNames())
                    deck2.Items.Add(cardName);
                label2.Text = "Deck #2 (" + deckNo2.Count + " cards)";
            }
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deckNo1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deckNo2.Shuffle();
            RedrawDeck(2);
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (deck1.SelectedIndex>=0)
            {
                deckNo2.Add(deckNo1.Deal(deck1.SelectedIndex));
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (deck2.SelectedIndex>=0)
            {
                deckNo1.Add(deckNo2.Deal(deck2.SelectedIndex));
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }
    }
}
