using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreationManager : MonoBehaviour
{

    public TextMeshProUGUI StrText;
    public TextMeshProUGUI EndText;
    public TextMeshProUGUI IntText;
    public TextMeshProUGUI WisText;
    public TextMeshProUGUI DexText;
    public TextMeshProUGUI TotalPointsText;
    public TextMeshProUGUI PointsLeftText;

    private float totalPoints;
    private float startingPoints = 10;


    private float strBase = 1;
    private float endBase = 1;
    private float intBase = 1;
    private float wisBase = 1;
    private float dexBase = 1;
   
    // Start is called before the first frame update
    void Start()
    {
        totalPoints = startingPoints;
    }

    // Update is called once per frame
    void Update()
    {
        //Updating Creation UI:
        TotalPointsText.text = "Total Points: " + startingPoints;
        PointsLeftText.text = "Points Left: " + totalPoints;
        StrText.text = "Strength: " + strBase;
        EndText.text = "Endurance: " + endBase;
        IntText.text = "Intelligence:" + intBase;
        WisText.text = "Wisdom:" + wisBase;
        DexText.text = "Dexterity: " + dexBase;
    }


    public void plusStr()
    {
        if(totalPoints > 0)
        {
            if (strBase >= 1 && strBase < 15)
            {
                strBase += 1;
                totalPoints -= 1;
        }
        }
       
    }
    public void minusStr()
    {

        if (strBase > 1 && strBase <= 15)
        {
            strBase -= 1;
            totalPoints += 1;

        }
    }
    public void plusEnd()
    {
        if (totalPoints > 0)
        {
            if (endBase >= 1 && endBase < 15)
            {
                endBase += 1;
                totalPoints -= 1;
            }
        }

    }
    public void minusEnd()
    {

        if (endBase > 1 && endBase <= 15)
        {
            endBase -= 1;
            totalPoints += 1;

        }
    }

    public void plusInt()
    {
        if (totalPoints > 0)
        {
            if (intBase >= 1 && intBase < 15)
            {
                intBase += 1;
                totalPoints -= 1;
            }
        }

    }
    public void minusInt()
    {

        if (intBase > 1 && intBase <= 15)
        {
            intBase -= 1;
            totalPoints += 1;

        }
    }
    public void plusWis()
    {
        if (totalPoints > 0)
        {
            if (wisBase >= 1 && wisBase < 15)
            {
                wisBase += 1;
                totalPoints -= 1;
            }
        }

    }
    public void minusWis()
    {

        if (wisBase > 1 && wisBase <= 15)
        {
            wisBase -= 1;
            totalPoints += 1;

        }
    }
    public void plusDex()
    {
        if (totalPoints > 0)
        {
            if (dexBase >= 1 && dexBase < 15)
            {
                dexBase += 1;
                totalPoints -= 1;
            }
        }

    }
    public void minusDex()
    {

        if (dexBase > 1 && dexBase <= 15)
        {
            dexBase -= 1;
            totalPoints += 1;

        }
    }

}
