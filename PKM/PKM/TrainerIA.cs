using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TrainerIA
{
    public TrainerIA()
    {
        currentstates = STATES.WAIT;
    }
    private enum STATES
    {
        WAIT,
        ATTK,
        DEFF,
        HEAL,
        SWAPPKM,
        ERROR
    }
    private STATES currentstates;
    public void Update()
    {
        switch (currentstates)
        {
            case STATES.WAIT:
                WAIT();
                if (PKMCANFIGHT())
                {
                    currentstates = STATES.ATTK;
                }
                else
                {
                    currentstates = STATES.DEFF;
                }
                break;
            case STATES.ATTK:
                ATTK();
                break;
            case STATES.DEFF:
                DEFF();
                break;
            case STATES.HEAL:
                HEAL();
                break;
            case STATES.SWAPPKM:
                SWAPPKM();
                break;
            default:
                Console.WriteLine("ERROR!!");
                break;
        }
    }
    private void ATTK() { }
    private void DEFF() { }
    private void HEAL() { }
    private void SWAPPKM() { }
    private void WAIT() { }
    private bool PKMCANFIGHT() 
    {
        
        
        
        
        
        
            return true;
        
       
    }
}


