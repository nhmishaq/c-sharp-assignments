using System;
using System.Collections.Generic;

public class Dojoachi{
    public int fullness = 20;
    public int happiness = 20;
    public int meals = 3;
    public int energy = 50;
    
// Every time you play with or feed your dojodachi there should 
// be a 25% chance that it won't like it. Energy or meals will still decrease, 
// but happiness and fullness won't change.

    public void feed(Dojoachi buddy){
        Random rand = new Random ();
        Random twentyFive = new Random ();
        var didntLike = twentyFive.Next (1,4);
        if (didntLike != 1){
            buddy.fullness += rand.Next(5,10);
            buddy.meals -= 1;
        }
        buddy.meals -= 1;
    } 

    public void play(Dojoachi buddy){
        Random rand = new Random ();
        Random twentyFive = new Random ();
        var didntLike = twentyFive.Next (1,4);
        if (didntLike != 1){
            buddy.happiness += rand.Next(5,10);
            buddy.energy -= 5;
        }
        buddy.energy -= 5;
    }

    public void work(Dojoachi buddy){
        Random rand = new Random ();
        buddy.meals += rand.Next(1,3);
        buddy.energy -= 5;
    }

    public void sleep (Dojoachi buddy){
        buddy.energy += 15;
        buddy.fullness -= 5;
        buddy.happiness -= 5;
    }
}

