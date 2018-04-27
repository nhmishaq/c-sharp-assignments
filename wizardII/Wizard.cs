namespace WizardII{
    public class Wizard : Human{
        public int health = 50;
        public int intelligence = 25;

        public void heal(){
            this.health += this.intelligence * 10;
            Console.WriteLine ("This intelligent wizard's health now is: " + this.health);
        }
        public void fireball(object poorVictim){
            Random rand = new Random();
            poorVictim.health -= rand.Next(20,50);
            Console.WriteLine ("This poor victim's health now is: " + poorVictim.health);
        }
    }
    
}