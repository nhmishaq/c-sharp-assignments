using System;

namespace humanII
{
    class Program
    {
        static void Main(string[] args)
        {
            Human toughGuy = new Human ("Big Billy", 8, 2, 4, 100);
            Console.WriteLine("Tough guy's name is: " + toughGuy.Hname + " his strength is " + toughGuy.Hstrength + " his intelligence is " + toughGuy.Hintelligence + " his dexterity is " + toughGuy.Hdexterity + " his health is " + toughGuy.Hhealth);
            Human weakerBystander = new Human ("Jeff", 4, 5, 8, 100);
            Console.WriteLine("Tough guy's name is: " + weakerBystander.Hname + " his strength is " + weakerBystander.Hstrength + " his intelligence is " + weakerBystander.Hintelligence + " his dexterity is " + weakerBystander.Hdexterity + " his health is " + weakerBystander.Hhealth);
            toughGuy.attack(toughGuy, weakerBystander);
            Console.WriteLine("Tough guy's name is: " + weakerBystander.Hname + " his strength is " + weakerBystander.Hstrength + " his intelligence is " + weakerBystander.Hintelligence + " his dexterity is " + weakerBystander.Hdexterity + " his health is " + weakerBystander.Hhealth);

        }
    }
}
