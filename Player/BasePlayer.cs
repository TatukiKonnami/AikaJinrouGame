using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BasePlayer : Agent {

    private Agent Me { get; set; }
    private int Day { get; set; }
    private List<Agent> AliveOthers { get; set; }
    private List<Agent> ExecutedAgents { get; set; }
    private List<Agent> KilledAgents { get; set; }

    private Agent voteCandidateAgent;
    Agent voteAgent;

    Dictionary<Agent, Roles> comingOutMap = new Dictionary<Agent, Roles>();

    public virtual string Name
    {
        get
        {
            return GetType().ToString();
        }
    }

    public virtual Agent vote()
    {
        chooseVoteCandidate();
        return voteCandidateAgent;
    }

    // choose vote agent
    protected virtual void chooseVoteCandidate()
    {
        
    }

    // call end game 
    public virtual void Finish()
    {
    }

    public void AddExecutedAgent(Agent executedAgent)
    {
        if (executedAgent != null)
        {
            AliveOthers.Remove(executedAgent);
            ExecutedAgents.Add(executedAgent);
        }
    }

    public void AddKilledAgent(Agent killedAgent)
    {
        if (killedAgent != null)
        {
            AliveOthers.Remove(killedAgent);
            KilledAgents.Add(killedAgent);
        }
    }

    private bool Killed(Agent agent)
    {
        return KilledAgents.Contains(agent);
    }

    private void SetCORole(Agent agent, Roles role)
    {
        comingOutMap[agent] = role;
    }

    private Roles GetCORole(Agent agent)
    {
        if (comingOutMap.ContainsKey(agent))
        {
            return comingOutMap[agent];
        }
        return Roles.UNKNOWN;
    }

    private bool IsCO(Agent agent)
    {
        return comingOutMap.ContainsKey(agent);
    }

    private bool IsCO(Roles role)
    {
        return comingOutMap.ContainsValue(role);
    }
}
