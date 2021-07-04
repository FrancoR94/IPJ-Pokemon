using System;
using System.Collections.Generic;
using System.Text;


class Trainer
{
    public Trainer()
    {
        string name;
    }
}

class Player : Trainer
{
    public Player()
    {

    }
}

class Enemy : Trainer
{
   
    public enum STATES
    {
        BEGINTURN,
        ATTACK,
        DRINKPOTION,
        SWITCHPOKEMON,
        RESTORESTATE,
    }

    private STATES currentState;
    public Enemy()
    {
        currentState = STATES.BEGINTURN;
    }

    public void Update()
    {
        switch (currentState)
        {
            case STATES.BEGINTURN:
                if (CanAttack())
                {
                    currentState = STATES.ATTACK;
                }
                else if(!NormalState())
                {
                    currentState = STATES.RESTORESTATE;
                }
                else if (LowLife())
                {
                    currentState = STATES.DRINKPOTION;
                }
                else
                {
                    currentState = STATES.SWITCHPOKEMON;
                }
                break;
            case STATES.ATTACK:
                Attack();
                currentState = STATES.BEGINTURN;
                break;
            case STATES.DRINKPOTION:
                DrinkPotion();
                currentState = STATES.BEGINTURN;
                break;
            case STATES.SWITCHPOKEMON:
                SwitchPokemon();
                currentState = STATES.BEGINTURN;
                break;
            case STATES.RESTORESTATE:
                RestoreState();
                currentState = STATES.BEGINTURN;
                break;
            default:
                break;
        }
    }
    private void Attack()
    {
        //ATAQUE
        
    }
    public void DrinkPotion()
    {
        //TOMA POCIÓN
        
    }
    public void SwitchPokemon()
    {
        // QUE CAMBIE EL POKEMON
        
    }
    public void RestoreState()
    {
        // QUE TOME UN RESTAURADOR
        
    }
    private bool CanAttack()
    {
        //Chequear vida, estado y nivel, si da ok retorna true.
        return true;
    }
    private bool NormalState()
    {
        //Chequear el estado del pokemon, si da ok retorna true.
        return true;
    }
    private bool LowLife()
    {
        //Chequear la vida, si es mayor a un valor X retorna true.
        return true;
    }
}

