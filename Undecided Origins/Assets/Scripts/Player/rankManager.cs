using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rankManager : MonoBehaviour
{
    public statManager playerStats;
    

    // Start is called before the first frame update
    void Start()
    {
        playerStats.loadStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
