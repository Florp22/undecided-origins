
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite Icon = null;

    public float reqRank;
    public float recRank;

    public bool isStr;
    public bool isEnd;
    public bool isIntel;
    public bool isWis;
    public bool isDex;

    

    public bool isDefaultItem = false;

    public virtual void Use()
    {
        //Use Item
        //Stuff happens
        Debug.Log("Using " + name);
    }
}
