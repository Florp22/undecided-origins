
using UnityEngine;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    Item item;
    public Image icon;
    public Button removeButton;
    public statManager playerStats;
    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.Icon;
        icon.enabled = true;
        removeButton.interactable = true;
    }
    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    public void onRemoveButton()
    {
        Inventory.instance.Remove(item); 
    }

    public void UseItem()
    {
        if(item != null)
        {
            if(item.isreqRank)
            {
                RankCheck();
            } else
            {
                item.Use();

            }
        }
    }

    public void RankCheck()
    {
        if (item.isStr) { 
            if (playerStats.strRank >= item.reqRank)
            {
                item.Use();
            } else

            {
                Debug.Log("Not High Enough Rank!");
            }
    }
        if (item.isEnd)
        {
            if (playerStats.endRank >= item.reqRank)
            {
                item.Use();
            }
            else
            {
                Debug.Log("Not High Enough Rank!");
            }
        }
        if (item.isIntel)
        {
           if (playerStats.intelRank >= item.reqRank)
            {
                item.Use();
            }
            else
            {
                Debug.Log("Not High Enough Rank!");
            }
        }
        if (item.isWis)
        {
            if (playerStats.wisRank >= item.reqRank)
            {
                item.Use();
            }
            else
            {
                Debug.Log("Not High Enough Rank!");
            }
        }
        if (item.isDex)
        {
            if (playerStats.dexRank >= item.reqRank)
            {
                item.Use();
            }
            else
            {
                Debug.Log("Not High Enough Rank!");
            }
        }
    }
}
