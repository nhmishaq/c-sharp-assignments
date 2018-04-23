public class Card {
    public string stringVal;
    public string suit;
    public int val;
}

public class Deck{
    public Card cards;
    public Card (stringVal, suit, val){
        for (int i = 0; i < 52; i++){
            cards.stringVal = i;
        }
    }
    public void deal(){
        return cards[0];
    }
    public void reset(Card cards){
        for (int i = 0; i < 52; i++){
            cards.stringVal = i;
        }
    }
    public void shuffle(Deck cards){
        Random rand = new Random();
        for (int i = 0; i < 52; i++){`
            cards.stringVal = rand.Next(1,52);
        }
    }
}
public class Player {
    public string name;
    public List<Card> hand;

   public void draw(Deck cards){
       Random rand = new Random();
       return Player.hand<rand.Next(1,52)>; 
   }
   public void discard(Card remove){
       if (hand.Contains(remove)){
           return null;
       } else {
           hand.Remove(remove);
           return remove;
       }
   }  
}