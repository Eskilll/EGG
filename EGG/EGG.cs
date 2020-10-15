using System;
using System.Collections.Generic;
namespace EGG
{
    public class EGG
    {
        public string name;
        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>();
        bool isAlive = false;
        Random Generator = new Random();

        

    public void Feed()
    {
        int spice = Generator.Next(1,101);
        if (spice == 100){
            System.Console.WriteLine("You fed your EGG 'GARBAGE' you should feel bad for this (it is also less hungry you damn monster)");
        }
        else{
            System.Console.WriteLine("You fed your EGG it's now less bored");
        }

        hunger -= Generator.Next(1,4); 
    }
    public void Hi()
    {
        System.Console.WriteLine("YOU: SPEAK CODE, DO MY BIDDING");
        int length = words.Count;
        int randomWord = Generator.Next(1,length);
        if (randomWord < 1){
            System.Console.WriteLine("You have not taught ", name, " any words");
        }
        else{
            System.Console.WriteLine(words[randomWord]);
            System.Console.WriteLine("Because you forced ", name, "to do as you said it's a little less bored");
            ReduceBoredom();
        }
        
    }
    public void Teach(string word)
    {
        System.Console.WriteLine("Teach the little EGG a single 'WORD'");
        words.Add(word);
        System.Console.WriteLine("You taught your EGG a word! It's now less bored, gj being a caring whatever! You managed to keep your enslaved code from getting bored to death");

        ReduceBoredom();
    }
    public void Tick()
    {
        //increase hunger and food by a random number between 1 and 3
        hunger += Generator.Next(1,4);
        boredom += Generator.Next(1,4);
        if(boredom > 10){
            //KILL
            isAlive = false;
        }
        if(hunger > 10){
            //KILL
            isAlive = false;
        }
    }
    public void PrintStats()
    {
        System.Console.WriteLine("your ", name , " is this hungry: " , hunger, " (greater number = more hungry)");
        System.Console.WriteLine("your ", name , " is this bored: " , boredom, " (greater number = more bored)");
        System.Console.WriteLine("your ", name , " is ded or no ded look here: ");
        if (isAlive == true){
            System.Console.WriteLine("the damned thing is ALIVE and maybe healthy but don't quote me on that");
        }
        else if (isAlive == false){
            System.Console.WriteLine("Yep your ", name , "is ded as shit");
        }
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    private void ReduceBoredom()
    {
                boredom -= Generator.Next(1,4); 
    }
    }
}
