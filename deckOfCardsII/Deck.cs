using System.Collections.Generic;

namespace deckOfCardsII
{
    public class Deck {
        public Card cards;
    
        //constructor
        public Deck(Card cards){
            List<Card> deck = new List<Card>();
            int counter = 0;
            for (int i = 0; i < 52; i++){
                while (counter < 12){
                    deck.stringVal = "ace";
                    deck.suit = "hearts";
                    deck.val = i;
                    counter++;
                }
                Console.WriteLine(deck[i]);
            }
            cards = (Deck)deck; 

        }
        // public void initializeDeck(){
        //     List<string> deck = new List<string>();
        //     for (int i = 0; i < 52; i++){
        //         deck.Add(i.ToString());
        //         Console.WriteLine(deck[i]);
        //     }


        // }
        public Card deal(Deck ourDeck){
            ourDeck.cards.RemoveAt(0);
            Card ourCard = ourDeck.cards[0];
            return ourCard;
        }
        public void reset(Deck ourDeck){
            ourDeck = cards;
        }
        public void shuffle(Deck ourDeckToShuffle){
            Random rand = new Random();
            for (int i = 0; i < ourDeckToShuffle.cards.Length; i++){
                ourDeckToShuffle.cards[i] = ourDeckToShuffle.cards[rand.Next(i, ourDeckToShuffle.cards.Length)];
            }
            for (int j = 0; j < ourDeckToShuffle.cards.Length; j++){
                Console.WriteLine(ourDeckToShuffle.cards[j]);
            }
        }
    }
    
}