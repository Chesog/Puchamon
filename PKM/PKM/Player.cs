﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Player
{
    List<Pokemon> PokmTeam = new List<Pokemon>();
    public Player() 
    {
        Pokemon Charizard = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Charizard.PCM");
        PokmTeam.Add(Charizard);
        Pokemon Dragonite = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Dragonite.PCM");
        PokmTeam.Add(Dragonite);
        Pokemon Ninetails = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Ninetails.PCM");
        PokmTeam.Add(Ninetails);
        Pokemon Pikachu = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Pikachu.PCM");
        PokmTeam.Add(Pikachu);
        Pokemon Quilava = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Quilava.PCM");
        PokmTeam.Add(Quilava);
        Pokemon Snorlax = PokemonReader.ReadPokemonFromFile("./PlayerPkmG/Snorlax.PCM");
        PokmTeam.Add(Snorlax);
    }

}

