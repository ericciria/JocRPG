using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public enum ItemType
    {
        HealingHerb,
        Key,
        FinalKey,
        HealthPotion,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.HealingHerb:  return ItemAssets.Instance.healingHerbSprite;
            case ItemType.Key:          return ItemAssets.Instance.keySprite;
            case ItemType.FinalKey:     return ItemAssets.Instance.finalKeySprite;
            case ItemType.HealthPotion: return ItemAssets.Instance.healingHerbSprite;
        }
    }
    
    
}
