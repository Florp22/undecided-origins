using UnityEngine;
using TMPro;
public class creationUIManager : MonoBehaviour
{
    public statManager playerStats;

    public TextMeshProUGUI StrText;
    public TextMeshProUGUI EndText;
    public TextMeshProUGUI IntText;
    public TextMeshProUGUI WisText;
    public TextMeshProUGUI DexText;
    public TextMeshProUGUI TotalPointsText;
    public TextMeshProUGUI PointsLeftText;
    public TextMeshProUGUI strRankText;
    public TextMeshProUGUI endRankText;
    public TextMeshProUGUI intRankText;
    public TextMeshProUGUI wisRankText;
    public TextMeshProUGUI dexRankText;


    void Update()
    {
        //Updating Creation UI:
        TotalPointsText.text = "Total Points: " + playerStats.startingPoints;
        PointsLeftText.text = "Points Left: " + playerStats.totalPoints;


        StrText.text = "Strength: " + playerStats.str;
        EndText.text = "Endurance: " + playerStats.end;
        IntText.text = "Intelligence:" + playerStats.intel;
        WisText.text = "Wisdom:" + playerStats.wis;
        DexText.text = "Dexterity: " + playerStats.dex;

        strRankText.text = "Str Rk. " + playerStats.strRank;
        endRankText.text = "End Rk. " + playerStats.endRank;
        intRankText.text = "Int Rk. " + playerStats.intelRank;
        wisRankText.text = "Wis Rk. " + playerStats.wisRank;
        dexRankText.text = "Dex Rk. " + playerStats.dexRank;

    }
}
