namespace humanII{

    public class Human{
        public string Hname;
        public int Hstrength = 3;
        public int Hintelligence = 3;
        public int Hdexterity = 3;
        public int Hhealth = 100;

        public Human(string name, int strength, int intelligence, int dexterity, int health){
            Hname = name;
            Hstrength = strength;
            Hintelligence = intelligence;
            Hdexterity = dexterity;
            Hhealth = health;
        }
        public int attack(Human attacker, Human victim){
            if (attacker is Human && victim is Human){
                victim.Hhealth -= attacker.Hstrength*5;
            
            else {
                Console.WriteLine("You are attacking a non human!");
            }
            return victim.Hhealth;
        }
    }
}