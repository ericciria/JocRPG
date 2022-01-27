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

        //AddItem(new Item { itemType = Item.ItemType.HealingHerb, amount = 1 });
        //AddItem(new Item { itemType = Item.ItemType.Key, amount = 1 });
        //AddItem(new Item { itemType = Item.ItemType.FinalKey, amount = 1 });
        //AddItem(new Item { itemType = Item.ItemType.HealthPotion, amount = 1 });

    }

    public void AddItem(Item item)
    {
        bool itemInInventory = false;
        foreach(Item inventoryItem in itemList)
        {
            if (inventoryItem.itemType == item.itemType)
            {
                //Debug.Log(item.amount);
                //Debug.Log(inventoryItem.amount);
                inventoryItem.amount+=item.amount;
                itemInInventory = true;
                //Debug.Log(inventoryItem.amount);
            }
        }
        if(!itemInInventory)
        {
            itemList.Add(item);
        }
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
        Debug.Log("-----------");
        foreach (Item inventoryItem in itemList)
        {
            Debug.Log(inventoryItem.amount);
        }
    }

    public void RemoveItem(Item item)
    {
        Debug.Log("-----------");
        foreach (Item inventoryItem in itemList)
        {
            Debug.Log(inventoryItem.amount);
        }
        //Debug.Log("AAAAAAAAAAAAAAAAAAAAA");
        //Debug.Log(item.amount);
        Item itemInInventory = null;
        foreach (Item inventoryItem in itemList)
        {
            //Debug.Log(inventoryItem.itemType);
            //Debug.Log(inventoryItem.amount);
            //Debug.Log(inventoryItem.itemType);
            if (inventoryItem.itemType == item.itemType)
            {
                //Debug.Log(inventoryItem.amount);
                //Debug.Log(item.amount);
                inventoryItem.amount -= item.amount;
                itemInInventory = inventoryItem;
                //Debug.Log(inventoryItem.amount);
            }

        }
        if (itemInInventory != null && itemInInventory.amount <= 0)
        {
            itemList.Remove(itemInInventory);
        }
        Debug.Log("-----------");
        foreach (Item inventoryItem in itemList)
        {
            Debug.Log(inventoryItem.amount);
        }

        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool CheckItem(Item item)
    {
        Item itemInInventory = null;
        foreach (Item inventoryItem in itemList)
        {
            //Debug.Log(inventoryItem.itemType);
            if (inventoryItem.itemType == item.itemType)
            {
                itemInInventory = inventoryItem;
            }
        }
        if (itemInInventory != null && itemInInventory.amount >= 0)
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
