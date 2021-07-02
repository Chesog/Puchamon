using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Movement
{
    public abstract Pokemon Use(Pokemon caster, Pokemon objetive);
}
public sealed class placaje : Movement 
{
    public override Pokemon Use(Pokemon caster, Pokemon objetive)
    {
        objetive.Life -= (caster.Attk - objetive.Deff);
        return objetive;
    }
}
public sealed class Lanzallamas : Movement
{
    public override Pokemon Use(Pokemon caster, Pokemon objetive)
    {
        objetive.Life -= (caster.AttkEspecial - objetive.DeffEspecial);
        return objetive;
    }
}

