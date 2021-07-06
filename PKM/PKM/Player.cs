using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Player
{
    Pokemon[] PokmTeam = new Pokemon [6];
    public Player() 
    {
        Pokemon Charizard = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Charizard.PCM");
        Pokemon Dragonite = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Dragonite.PCM");
        Pokemon Ninetails = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Ninetails.PCM");
        Pokemon Pikachu = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Pikachu.PCM");
        Pokemon Quilava = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Quilava.PCM");
        Pokemon Snorlax = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Snorlax.PCM");

        PokmTeam{ Charizard}
    }

}

