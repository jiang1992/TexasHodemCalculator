using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    class Card
    {

        int color;
        int number; 
        public Card(int color, int number) {
            this.color = color;
            this.number = number;         
        }
        public int getColor() { 
            
            if(this.color == 0){

                Console.WriteLine("Clubs");
            }
            else if (this.color == 1)
            {
                Console.WriteLine("Spades");
            }
            else if (this.color == 2)
            {
                Console.WriteLine("Diamonds");
            }
            else if (this.color == 3)
            {
                Console.WriteLine("Hearts");
            }
            else { }
            return this.color;
        }

        public int getNumber()
        {            
            return this.number;
        }
    }
}
