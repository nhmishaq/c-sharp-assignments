namespace wizardII
{
    public class Ninja : Human{
        public int dexterity = 175;
        public void steal(object thisGuyGettingWrecked){
            this.attack(thisGuyGettingWrecked);
            this.health += 10;
            Console.WriteLine("Our victim's health is now down to " + thisGuyGettingWrecked.health);
            Console.WriteLine("Our ninja hero's health is now down to " + this.health);
        }
        public void getAway(){
            this.health -= 15;
            Console.WriteLine("Our ninja hero's health is now down to " + this.health);
        }
    }
}