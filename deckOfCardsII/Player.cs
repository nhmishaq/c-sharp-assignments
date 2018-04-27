namespace deckOfCardsII
{
    public class Player{
        public string name;
        public List<Card> hand;
        //  = new List<Card>;

        public Card draw(Deck fromTheDeck){
            Card card = fromTheDeck.deal(fromTheDeck);
            hand = card;
            return card;
        }
        public Card discard(int discardThisIndex){
            Card thisGuyGetsReturned;
            if (hand.Length <= discardThisIndex && discardThisIndex > 0){
                thisGuyGetsReturned = hand[thisGuyGetsReturned];
                hand.RemoveAt(discardThisIndex);
                return thisGuyGetsReturned;
            }
            else {
                return;
            }
        }
    }
    
}