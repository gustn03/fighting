using System;

namespace fighting
{
    class Program
    {
        static void Main(string[] args)
        {
            int fighter1HP = 0;
            int fighter2HP = 0;

            Random Dmg = new Random();
            System.Console.WriteLine("Nu jävlar blir det vev");
            while (fighter1HP < 150 && fighter2HP < 150){
                int dmg1 = Dmg.Next(5, 25);
                int dmg2 = Dmg.Next(5, 25);
                fighter1HP = fighter1HP + dmg1;
                fighter2HP = fighter2HP + dmg2;
                System.Console.WriteLine($"Marss took {dmg1}% and is now at {fighter1HP}");
                System.Console.WriteLine($"ESAM took {dmg2}% and is now at {fighter2HP}");
                Console.ReadLine();
            }
            if (fighter1HP < 150){
                System.Console.WriteLine("Downsmash, up B, will that take it? Yes it will, and thats the game");
                System.Console.WriteLine("Who won? Marss won, ZSS is top tier just accept it stop saying she's trash");
            }
            else if (fighter2HP < 150){
                System.Console.WriteLine("ESAM mad nice, Pika busted, stupid rat needs a nerf Sakurai please");
                System.Console.WriteLine("ESAM played optimally, pretty lame honestly but i guess he won, Pika busted");
            }
            else{
                System.Console.WriteLine("EE screamed too loudly so both players SDd and we're off schedule so let's just skip the 1 stock 2 minute playoff, we all know that leo is winning EVO");
            }
            Console.ReadLine();
        }
    }
}
