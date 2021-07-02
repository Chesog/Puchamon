using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        try
        {

            bool GameOpen = true;
            Game game = Game.GetInstace();
            do
            {
                GameOpen = game.Continue();
            } while (GameOpen);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            
        }
    }
}

