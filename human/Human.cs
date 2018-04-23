public class Human{
    public string name;
    public int strength = 3;
    public int intelligence = 3;
    public int dextirity = 3;
    public int health = 100;

}
public class Human (string name, int strength, int intelligence, int dextirity, int health){
    name = name;
    strength = strength;
    intelligence = intelligence;
    dextirity = dextirity;
    health = health;
}
public void attack(Human victim){
    victim.health -= (5 * strength);
}