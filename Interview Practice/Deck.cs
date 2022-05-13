using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Practice
{
    class Deck
    {
        List<Card> deck;

        public Deck()
        {
            deck = new List<Card>();
            InitDeck();
        }

        private void InitDeck()
        {
            String[] suits = new string[] { "Clubs","Diamonds","Hearts","Spades" };

            foreach (string suit in suits)
            {
                for (int i = 1; i <= 13; ++i)
                {
                    this.deck.Add(new Card(i,suit));
                }
            }
        }

        public override String ToString()
        {
            String result = "";
            foreach (Card c in deck)
            {
                result += c.name + " of " + c.suit + "\n";
            }
            return result;
        }
    }

    class Card
    {
        public String name;
        public String suit;

        public Card(int number, String suit)
        {
            switch (number)
            {
                case 1://As
                    this.name = "As";
                    break;
                case 11://J
                    this.name = "J";
                    break;
                case 12://Q
                    this.name = "Q";
                    break;
                case 13://K
                    this.name = "K";
                    break;
                default:
                    this.name = number+"";
                    break;
            }
            this.suit = suit;
        }
    }
}
