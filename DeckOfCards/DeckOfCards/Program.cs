using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //delcare new deck
            var Deck = new Deck();

            //shuffle the cards
            Deck.Shuffle();

            //deal cards
            List<Cards> ListofCards = new List<Cards>();
            ListofCards = Deck.Deal();
            Console.WriteLine("\n\nDealt Cards: ");
            Console.WriteLine();
            foreach (var item in ListofCards)
            {
                item.DealFromDeck();
            }

            //deal cards
            List<Cards> ListofCards2 = new List<Cards>();
            ListofCards2 = Deck.Deal();
            Console.WriteLine("\n\nDealt Cards: ");
            Console.WriteLine();
            foreach (var item in ListofCards2)
            {
                item.DealFromDeck();
            }

            //keep window open
            Console.ReadKey();
        }

        
    }
}
