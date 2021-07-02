using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Pokemon
{
    public Pokemon() 
    {
        Element = new List<string>();
        Moves = new List<string>();
    }
    public string Name;
    public int LVL;
    public List<string> Element;
    public int Life;
    public int Attk;
    public int AttkEspecial;
    public int Deff;
    public int DeffEspecial;
    public int Speed;
    public List<string> Moves;
    
}

