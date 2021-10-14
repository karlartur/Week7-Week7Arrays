using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajale hommikusöögi menüüd
            //programm palub kasutajal teha valikut
            //programm kuvab kasutaja valikut konsoolis

            string[] menu = { "omlett", "pannkookid", "keedumuna", "neljaviljapuder", "singivõileib" };
            Console.WriteLine($"Meie menüüs on {menu.Length} valikkut.");
            //menu[4] = "juustuvõileib";
            //menu[3] = "kearapuder";

            Console.WriteLine("Tänases menüüs:");

            for(int i = 0; i < menu.Length; i++)
            {
               if (menu[i] == "neljaviljapuder")
               {
                    menu[i] = "kearapuder";
               }
               else if (menu[i] == "singivõileib")
               {
                    menu[i] = "juustuvõileib";
               }
                Console.WriteLine(menu[i]);
            }
            
            Console.WriteLine("Tee oma valik(sisesta numbrid 1-5):");
            int userChoice = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine($"Olete valinud: {menu[userChoice]}");

            /*foreach (string menuelement in menu)
             {
               
                Console.WriteLine(menuelement);
             }*/
          

        }
    }
}
