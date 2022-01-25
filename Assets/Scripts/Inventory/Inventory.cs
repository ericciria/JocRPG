using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public event EventHandler OnItemListChanged;
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.HealingHerb, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Key, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.FinalKey, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.HealthPotion, amount = 1 });

    }

    public void AddItem(Item item)
    {
        bool itemInInventory = false;
        foreach(Item inventoryItem in itemList)
        {
            if (inventoryItem.itemType == item.itemType)
            {
                inventoryItem.amount+=item.amount;
                itemInInventory = true;
            }

        }
        if(!itemInInventory)
        {
            itemList.Add(item);
        }
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveItem(Item item)
    {
        Item itemInInventory = null;
        foreach (Item inventoryItem in itemList)
        {
            Debug.Log(inventoryItem.itemType);
            if (inventoryItem.itemType == item.itemType)
            {
                inventoryItem.amount -= item.amount;
                itemInInventory = inventoryItem;
            }

        }
        if (itemInInventory != null && itemInInventory.amount <= 0)
        {
            itemList.Remove(itemInInventory);
        }

        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool CheckItem(Item item)
    {
        Item itemInInventory = null;
        foreach (Item inventoryItem in itemList)
        {
            Debug.Log(inventoryItem.itemType);
            if (inventoryItem.itemType == item.itemType)
            {
                inventoryItem.amount -= item.amount;
                itemInInventory = inventoryItem;
            }
        }
        if (itemInInventory != null && itemInInventory.amount <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }

}
