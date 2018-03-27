using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractRoleAssign : IPlayer
{
    IPlayer player;
    public string Name
    {
        get
        {
            return GetType().ToString();
        }
    }

    public void AbstractRoleAssignPlayer()
    {
        setPlayers();
    }

    protected abstract void setPlayers();

    public void DayStart()
    {
        player.DayStart();
    }

    public Agent Vote()
    {
        return player.Vote();
    }

    public void Finish()
    {
         player.Finish();
    }


}
    
