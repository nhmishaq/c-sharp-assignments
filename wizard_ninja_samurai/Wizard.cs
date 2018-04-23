public class Wizard : Human{
    Wizard.health = 50;
    Wizard.intelligence = 25;
}
public void heal(Wizard){
    Wizard.health = Wizard.intelligence * 10;
}
public void fireball(object obj){
    Random rand = new Random();
    obj.health -= rand.Next(25,50);
}