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
            Deck forPoker = new Deck();
            //shuffle the cards
            forPoker.Shuffle();
            //deal cards
            List<Cards> ListofCards = new List<Cards>();
            ListofCards = forPoker.Deal(5);
            Console.WriteLine("Dealt Cards: ");
            foreach (var item in ListofCards)
            {
                item.DealFromDeck();
            }

            Console.WriteLine("\n\nRemaining Cards in the Deck");
            forPoker.PrintDeck();


            //Console.WriteLine(string.Join("\n", ListofCards.OrderBy(x=>x)));



            Console.ReadKey();
        }

        
    }
}
