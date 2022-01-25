using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGround : MonoBehaviour
{
    private Item item;
    private SpriteRenderer spriteRenderrer;
    [SerializeField] Item.ItemType tipus;

    private void Start()
    {
        spriteRenderrer = GetComponent<SpriteRenderer>();
        item = new Item {itemType = tipus, amount = 1 };
    }

    public void setItem(Item item)
    {
        this.item = item;
        spriteRenderrer.sprite = item.GetSprite();
    }

    public Item GetItem()
    {
        return item;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
