using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent {

    private Dictionary<int, Agent> AgentMap = new Dictionary<int, Agent>();
    private int AgentIndex;

    public void setIndex(int index)
    {
        AgentIndex = index;
    }
    public int getIndex()
    {
        return AgentIndex;
    }

#if true
    /// <summary>
    /// Return the agent of index.
    /// </summary>
    /// <param name="index">agent index number.</param>
    /// <returns> agent index number.</returns>
    /// <returns> If index is negative, return null.</returns>
#endif
    public Agent getAgent(int index)
    {
        if (index < 0)
        {
            return null;
        }
        if (AgentMap.ContainsKey(index))
        {
            Agent agent = new Agent();
            agent.setIndex(index);
            AgentMap[index] = agent;
        }
        return AgentMap[index];
    }

}
