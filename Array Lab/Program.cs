using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Lab Starter Code
            String[] deck = new string[52];
            PopDeck(ref deck);
            PrintDeck(deck);

            deck = FullShuffle(Shuffle(deck));
            Console.WriteLine("\nPrinting shuffled deck...\n");
            PrintDeck(deck);

            Console.ReadLine();
        }

        //Establishes deck with 52 unique 'cards'
        public static void PopDeck(ref String[] deck)
        {
            int count = 0;

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 13; i++)
                {
                    switch (i)
                    {
                        case 0: deck[count] = "Ace of "; break;
                        case 10: deck[count] = "Jack of "; break;
                        case 11: deck[count] = "Queen of "; break;
                        case 12: deck[count] = "King of "; break;

                        default: deck[count] = i + " of "; break;
                    }

                    switch (j)
                    {
                        case 0: deck[count] += "Spades"; break;
                        case 1: deck[count] += "Diamonds"; break;
                        case 2: deck[count] += "Hearts"; break;
                        case 3: deck[count] += "Clubs"; break;
                    }
                    count++;
                }
            }
        }

        //prints each value in deck
        public static void PrintDeck(String[] deck)
        {
            for (int i = 0; i < 52; i++)
                Console.WriteLine(deck[i]);
        }
        
        // Splits deck in half and binary shuffles the 'cards' and returns shuffled deck
        public static String[] Shuffle(String[] deck)
        {
            String[] shuffled = new string[52];


            Random rand = new Random();
            int rng = 0;

            for(int i = 0; i < 26; i++)
            {
                rng = rand.Next(0, 2);

                if(rng == 0)
                {
                    shuffled[i * 2] = deck[i];
                    shuffled[(i * 2) + 1] = deck[i + 26];
                }

                if(rng == 1)
                {
                    shuffled[i * 2] = deck[i + 26];
                    shuffled[(i * 2) + 1] = deck[i];
                }
            }
            return shuffled;
        }

        //Calls Shuffle function 7 times for an extremely random shuffle and returns shuffled deck
        public static String[] FullShuffle(String[] tDeck)
        {
            Console.WriteLine("\nShuffling deck 7 times...\n");

            for(int i = 0; i < 7; i++)
            {
                tDeck = Shuffle(tDeck);
            }
            return tDeck;
        }
    }
}
