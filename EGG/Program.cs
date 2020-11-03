using System;

namespace EGG
{
    class Program
    {
        static void Main(string[] args)
        {
            EGG EGG = new EGG();
            System.Console.WriteLine("Name Your EGG!");
            EGG.name = System.Console.ReadLine();
            string inpt = ""; 
            bool live = true;
            while(live == true){
                System.Console.WriteLine("Feed,Hi,Teach,Stats");
                inpt = System.Console.ReadLine();
                if(inpt == "Feed"){
                    EGG.Feed();
                    inpt = "";
                }
                else if(inpt == "Hi"){
                    EGG.Hi();
                    inpt = "";
                }
                else if(inpt == "Teach"){

                    inpt = "";
                }
                else if(inpt == "Stats"){
                    EGG.PrintStats();
                    inpt = "";
                }
                else{
                    System.Console.WriteLine("Sorry didn't quite catch that try something else!");
                }

                EGG.Tick();

                live = EGG.GetAlive();

            }


        }
    }
}
