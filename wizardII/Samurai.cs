namespace wizardII{
    
    public class Samurai : Human {
        public health = 200;
        counter ++;
        public void deathBlow(object potentiallyDeadDude){
            if (potentiallyDeadDude.health < 50){
                potentiallyDeadDude.health = 0;
            }
            this.attack(potentiallyDeadDude);
        }

        public void meditate(){
            this.health = 200;
        }
        public static howMany(){
            Console.WriteLine(counter);
        }
    }
}