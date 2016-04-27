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
        Deck deck = new Deck();
        List<Card> deckNo1 = new List<Card>();
        List<Card> deckNo2 = new List<Card>();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public void DrawCards()
        {
            string result = "";
            deckNo1 = deck.GenerateCards(10);
            deckNo2 = deck.GenerateCards(52);
            foreach (var card in deckNo1)
            {
                result += card.Name + "\n";
            }
            deck1.Text = result;
        }
        public void ResetDeck(int deckNo)
        {
            switch (deckNo)
            {
                case 1:
                    deck1.Items.Clear();
                    deckNo1 = deck.GenerateCards(random.Next(1, 11));
                    break;
                case 2:
                    deck2.Items.Clear();
                    deckNo2 = deck.GenerateCards(52);
                    break;
            }
        }
        private void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber==1)
            {
                deck1.Items.Clear();
                foreach (string cardName in deckNo1.GetCardNames())
                {
                    deck1.Items.Add(cardName);
                    label1.Text = "Deck #" + DeckNumber + " (" + deckNo1.Count + " cards)";
                }
            }
            else
            {
                deck2.Items.Clear();
                foreach (string cardName in deckNo2.GetCardNames())
                {
                    deck2.Items.Add(cardName);
                    label2.Text= "Deck #" + DeckNumber + " (" + deckNo2.Count + " cards)";
                }
            }
        }

        private void resetDeck1_Click(object sender, EventArgs e)
        {

        }

        private void resetDeck2_Click(object sender, EventArgs e)
        {

        }

        private void shuffleDeck1_Click(object sender, EventArgs e)
        {

        }

        private void shuffleDeck2_Click(object sender, EventArgs e)
        {

        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {

        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {

        }
    }
}
