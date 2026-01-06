using System.Collections.Generic;
using UnityEngine;

public class CrownCheck : MonoBehaviour
{
    [SerializeField] PlayerInventory playerInventory;
    private CrownAcquiredSound crownAcquiredSound;
    void Awake()
    {
        crownAcquiredSound = GetComponent<CrownAcquiredSound>();
    }

    void OnEnable()
    {
        PlayerInventory.OnAnyItemAdded += InventoryCheck;
    }

    void OnDisable()
    {
        PlayerInventory.OnAnyItemAdded -= InventoryCheck;
    }

    public void InventoryCheck(PlayerInventory _)
    {
        List<Interactive> inventoryList = playerInventory.Inventory;
        bool crownInInventory = false;

        foreach(Interactive interactive in inventoryList)
        {
            if(interactive.inventoryName == "Crown")
            {
                crownInInventory = true;
                break;
            }
        }

        if(crownInInventory)
        {
            crownAcquiredSound.PlayCrownAcquiredSound();
            Interactive interactive = GetComponent<Interactive>();
            interactive.FulfillRequirements();
            interactive.TriggerIndirect();
        }
        else
        {
            return;
        }
    }
}
