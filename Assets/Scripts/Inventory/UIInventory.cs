using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform itemContainer;
    private Transform itemTemplate;

    public void Awake()
    {
        itemContainer = transform.Find("ItemContainer");
        itemTemplate = itemContainer.Find("ItemSlot");
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventory();
    }
    private void RefreshInventory()
    {
        
        int x = 0;
        float cellSize = 50f;

        foreach (Item item in inventory.GetItemList())
        {
            
            RectTransform itemSlotRectTransform = Instantiate(itemTemplate, itemContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * cellSize, 0);

            Image image = itemSlotRectTransform.Find("Image").GetComponent<Image>();
            image.sprite = item.GetSprite();
            

            x++;
        }
    }
}
