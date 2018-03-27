using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayer {

	string Name { get; }

    //call new day start 
    void DayStart();

    //return this agent want to execute agent
    Agent Vote();

    // call game end
    void Finish();
}
