public class Ninja : Human{
    Ninja.dexterity = 175;
    public void steal (object obj){
        obj.attack();
        Ninja.health += 10;
    }
    public void get_away(){
        Ninja.health -= 15;
    }
}