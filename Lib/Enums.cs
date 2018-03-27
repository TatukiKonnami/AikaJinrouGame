using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Roles
{
	UNKNOWN,
    HUNTER,
    FOX,
    //共有者
    FREEMASON,
    //霊能
    PSYCHIC,
    MADMAN,
    //占い
    SEER,
    CAT,
    VILLAGER,
    WEREWOLF
}

public enum Team
{
    UNKNOWN,
    VILLAGER,
    WEREWOLF,
    FOX
}

public enum Species
{
    UNKNOWN,
    HUMAN,
    WEREWOLF,
    FOX
}


 public static class Role 
{
    private static Dictionary<Roles, Team> TeamMap = new Dictionary<Roles, Team>()
    {
        { Roles.UNKNOWN, Team.UNKNOWN },
        { Roles.FOX, Team.FOX },
        { Roles.VILLAGER, Team.VILLAGER },
        { Roles.FREEMASON, Team.VILLAGER },
        { Roles.SEER, Team.VILLAGER },
        { Roles.PSYCHIC, Team.VILLAGER },
        { Roles.HUNTER, Team.VILLAGER },
        { Roles.CAT, Team.VILLAGER },
        { Roles.WEREWOLF, Team.WEREWOLF },
        { Roles.MADMAN, Team.WEREWOLF }
    };

    private static Dictionary<Roles, Species> SpeciesMap = new Dictionary<Roles, Species>()
    {
        { Roles.UNKNOWN, Species.UNKNOWN },
        { Roles.FOX, Species.FOX },
        { Roles.VILLAGER, Species.HUMAN },
        { Roles.FREEMASON, Species.HUMAN },
        { Roles.SEER, Species.HUMAN },
        { Roles.PSYCHIC, Species.HUMAN },
        { Roles.HUNTER, Species.HUMAN },
        { Roles.CAT, Species.HUMAN },
        { Roles.WEREWOLF, Species.WEREWOLF },
        { Roles.MADMAN, Species.HUMAN }
    };

    public static Team getTeam(this Roles roles)
    {
        return TeamMap[roles];
    }

    public static  Species getSpecies(this Roles roles)
    {
        return SpeciesMap[roles];
    }


    
}