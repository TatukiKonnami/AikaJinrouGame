using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameInfo  {

    // the list of agents.
    public List<Agent> AgentList { get; private set; } = new List<Agent>();

    //the agent is receive  Agent.
    private Agent _agent;
    private int agent = -1;
    public Agent ReceiveAgent
    {
        get
        {
            return _agent;
        }
        set
        {
            _agent = value;
            agent = value == null ? -1 : value.getIndex();
        }
    }


    // the agent is executed last light.
    private Agent _executedAgent;
    private int executedAgent = -1;
    public Agent ExecutedAgent
    {
        get
        {
            return _executedAgent;
        }
        set
        {
            _executedAgent = value;
            executedAgent = value == null ? -1 : value.getIndex();
        }
    }

    // the latest executed agent.
    private Agent _lastExecutedAgent;
    private int lastExecutetedAgent = -1;
    public Agent LastedExecutedAgent
    {
        get
        {
            return _lastExecutedAgent;
        }
        set
        {
            _lastExecutedAgent = value;
            lastExecutetedAgent = value == null ? -1 : value.getIndex();
        }
    }


    // the status all agent.
    private Dictionary<int, string> statusMap = new Dictionary<int, string>();
    private Dictionary<Agent, Status> _statusMap = new Dictionary<Agent, Status>();
    public Dictionary<Agent, Status> StatusMap
    {
        get
        {
            return _statusMap;
        }
        set
        {
            _statusMap = value ?? new Dictionary<Agent, Status>();
            statusMap = _statusMap.ToDictionary(p => p.Key.getIndex(), p => p.Value.ToString());
            AgentList = _statusMap.Keys.ToList();
        }
    }

}
