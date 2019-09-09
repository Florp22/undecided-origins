using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class statManager : MonoBehaviour
{



    public float totalPoints;
    public float startingPoints = 10;


    public float str = 1;
    public float end = 1;
    public float intel = 1;
    public float wis = 1;
    public float dex = 1;


    public float strRank;
    public float endRank;
    public float intelRank;
    public float wisRank;
    public float dexRank;
   
    // Start is called before the first frame update
    void Start()
    {
        totalPoints = startingPoints;
        loadStats();

    }


    // Update is called once per frame



    public void plusStr()
    {
        if(totalPoints > 0)
        {
            if (str >= 1 && str < 15)
            {
                str += 1;
                totalPoints -= 1;
        }
        }
       
    }
    public void minusStr()
    {

        if (str > 1 && str <= 15)
        {
            str -= 1;
            totalPoints += 1;

        }
    }
    public void plusEnd()
    {
        if (totalPoints > 0)
        {
            if (end >= 1 && end < 15)
            {
                end += 1;
                totalPoints -= 1;
            }
        }

    }
    public void minusEnd()
    {

        if (end > 1 && end <= 15)
        {
            end -= 1;
            totalPoints += 1;

        }
    }

    public void plusInt()
    {
        if (totalPoints > 0)
        {
            if (intel >= 1 && intel < 15)
            {
                intel += 1;
                totalPoints -= 1;
            }
        }

    }
    public void minusInt()
    {

        if (intel > 1 && intel <= 15)
        {
            intel -= 1;
            totalPoints += 1;

        }
    }
    public void plusWis()
    {
        if (totalPoints > 0)
        {
            if (wis >= 1 && wis < 15)
            {
                wis += 1;
                totalPoints -= 1;
            }
        }

    }
    public void minusWis()
    {

        if (wis > 1 && wis <= 15)
        {
            wis -= 1;
            totalPoints += 1;

        }
    }
    public void plusDex()
    {
        if (totalPoints > 0)
        {
            if (dex >= 1 && dex < 15)
            {
                dex += 1;
                totalPoints -= 1;
            }
        }

    }
    public void minusDex()
    {

        if (dex > 1 && dex <= 15)
        {
            dex -= 1;
            totalPoints += 1;

        }
    }

    public void saveStats()
    {
        strRankCheck();
        endRankCheck();
        intelRankCheck();
        wisRankCheck();
        dexRankCheck();
        creationSaveSystem.saveCreation(this);    
    }
    public void loadStats()
    {
        creationData data = creationSaveSystem.LoadCreation();
        str = data.str;
        end = data.end;
        intel = data.intel;
        wis = data.wis;
        dex = data.dex;
        strRank = data.strRank;
        endRank = data.endRank;
        intelRank = data.intelRank;
        wisRank = data.wisRank;
        dexRank = data.dexRank;
        totalPoints = data.totalPoints;
    }


    void strRankCheck()
    {
        if (str >= 1 && str <= 6)
        {
            strRank = 1;
        }
        if (str >= 6 && str <= 11 )
        {
            strRank = 2;
        }
        if (str >= 11 && str <= 15)
        {
            strRank = 3;
        }

    }
    void endRankCheck()
    {
        if (end >= 1 && end <= 6)
        {
            endRank = 1;
        }
        if (end >= 6 && end <= 11)
        {
            endRank = 2;
        }
        if (end >= 11 && end <= 15)
        {
            endRank = 3;
        }

    }
    void intelRankCheck()
    {
        if (intel >= 1 && intel < 11)
        {
            intelRank = 1;
        }
        if (intel >= 11 && intel < 20)
        {
            intelRank = 2;
        }
        if (intel >= 21 && intel < 30)
        {
            intelRank = 3;
        }

    }
    void wisRankCheck()
    {
        if (wis >= 1 && wis < 11)
        {
            wisRank = 1;
        }
        if (wis >= 11 && wis < 20)
        {
            wisRank = 2;
        }
        if (wis >= 21 && wis < 30)
        {
            wisRank = 3;
        }

    }
    void dexRankCheck()
    {
        if (dex >= 1 && dex < 11)
        {
            dexRank = 1;
        }
        if (dex >= 11 && dex < 20)
        {
            dexRank = 2;
        }
        if (dex >= 21 && dex < 30)
        {
            dexRank = 3;
        }

    }
}
