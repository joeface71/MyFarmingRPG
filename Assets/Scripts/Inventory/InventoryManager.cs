using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : SingletonMonobehavior<InventoryManager>
{
    private Dictionary<int, ItemDetails> itemDetailsDictionary;

    [SerializeField] private SOItemList itemList = null;

    private void Start()
    {
        // create item details dictionary
        CreateItemDetailsDictionary();
    }

    /// <summary>
    /// Populates the itemDetailsDictionary from the scriptable object items list
    /// </summary>
    private void CreateItemDetailsDictionary()
    {
        itemDetailsDictionary = new Dictionary<int, ItemDetails>();

        foreach (ItemDetails itemDetails in itemList.itemDetails)
        {
            itemDetailsDictionary.Add(itemDetails.itemCode, itemDetails);
        }
    } 
    
    public ItemDetails GetItemDetails(int itemCode)
    {
        ItemDetails itemDetails;

        if (itemDetailsDictionary.TryGetValue(itemCode, out itemDetails))
        {
            return itemDetails;
        }
        else
        {
            return null;
        }
    }

}
