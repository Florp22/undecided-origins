﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_Pickup : Interactable
{

    public Item item;
  public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    void PickUp()
    {
        
        Debug.Log("Picking up " + item.name);
        //Add to INventory
       bool wasPickedUp =  Inventory.instance.Add(item);
        if (wasPickedUp)
        {
            Destroy(gameObject);

        }
    }
}
