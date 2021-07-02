using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



public static class PokemonReader
{
    public static Pokemon ReadPokemonFromFile(string path)
    {
        Pokemon p = new Pokemon();
        string[] lines;
        try
        {
            lines = File.ReadAllLines(path);
           
        }
        catch (Exception E)
        {
            Console.WriteLine(E.Message);
            throw;
        }
        p.Name = lines[0];
        p.LVL = Convert.ToInt32(lines[1]);
        p.Element.Add(lines[2]);
        p.Life = Convert.ToInt32(lines[3]);
        p.Attk = Convert.ToInt32(lines[4]);
        p.AttkEspecial = Convert.ToInt32(lines[5]);
        p.Deff = Convert.ToInt32(lines[6]);
        p.DeffEspecial = Convert.ToInt32(lines[7]);
        p.Speed = Convert.ToInt32(lines[8]);
        p.Moves.Add(lines[9]);
        p.Moves.Add(lines[10]);
        p.Moves.Add(lines[11]);
        p.Moves.Add(lines[12]);
        return p;
    }
}

