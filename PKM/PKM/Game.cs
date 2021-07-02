using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Game
{

    private static Game Instance;
     enum ContinueOption {Yes , NO }
    public static Game GetInstace()
    {
        if (Instance == null)
        {
            Instance = new Game();
        }
        return Instance;
    }
    private Game()
    {
        Gameplay gameplay = new Gameplay();
        Pokemon Charmander = PokemonReader.ReadPokemonFromFile("Charmander.PCM");
        
    }
    public bool Continue() 
    {
        Console.WriteLine("Desea Continuar?");
        Console.WriteLine("0 = Yes - 1 = No");
        int imput = Convert.ToInt32(Console.ReadLine());
        ContinueOption continueOption;
        continueOption = (ContinueOption)imput;
        switch (continueOption)
        {
            case ContinueOption.Yes:
                return true;
            case ContinueOption.NO:
                return false;
            default:
                return true;
        }
        
    }
}

