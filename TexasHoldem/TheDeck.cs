using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    class TheDeck
    {
       
        public static int numberOfColor = 4;
        public static int numberOfNumber = 13;
        public static int deckSize = numberOfColor * numberOfNumber;
        public static Card[] RemainingDeck = new Card[deckSize];
        public TheDeck() {

            newDeck();
        }

        private void newDeck() {
            int k = 0;
            for (int i = 0; i < numberOfColor; i++) 
            {

                for (int j = 1; j < numberOfNumber+1; j++ )
                {
                    RemainingDeck[k] = new Card(i,j);
                    k++;
                }

            }           
        }// this creates a new deck
    }
}
