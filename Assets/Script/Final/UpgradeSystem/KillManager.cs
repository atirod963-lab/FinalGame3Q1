using UnityEngine;
using System.Collections.Generic;

public class KillManager : MonoBehaviour
{
    // weaponID → killCount
    private Dictionary<string, int> killDict = new Dictionary<string, int>();

    public void AddKill(string weaponID)
    {
        if (!killDict.ContainsKey(weaponID))
            killDict[weaponID] = 0;

        killDict[weaponID]++;
    }

    public int GetKills(string weaponID)
    {
        return killDict.ContainsKey(weaponID) ? killDict[weaponID] : 0;
    }

    public void ResetKills(string weaponID)
    {
        if (killDict.ContainsKey(weaponID))
            killDict[weaponID] = 0;
    }
}
