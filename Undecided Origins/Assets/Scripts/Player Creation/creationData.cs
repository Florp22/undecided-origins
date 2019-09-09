using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class creationData 
{
    public float str;
    public float end;
    public float intel;
    public float wis;
    public float dex;


    public float totalPoints;
    

    public float strRank;
    public float endRank;
    public float intelRank;
    public float wisRank;
    public float dexRank;
    public creationData(statManager createStats)
    {
        str = createStats.str;
        end = createStats.end;
        intel = createStats.intel;
        wis = createStats.wis;
        dex = createStats.dex;
        totalPoints = createStats.totalPoints;
        strRank = createStats.strRank;
        endRank = createStats.endRank;
        intelRank = createStats.intelRank;
        wisRank = createStats.wisRank;
        dexRank = createStats.dexRank;
    }
}
