using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ItemDatabase", menuName = "Inventory/ItemDatabase")]
public class ItemDatabase : ScriptableObject
{
    public List<ItemData> items = new List<ItemData>();
    public ItemData FindItemById(int id)
    {
        return items.Find(item => item.id== id);
    }

    public void AddItemToDatabase(ItemData newItem)
    {
        if(!items.Contains(newItem))
        {
            items.Add(newItem);
        }
    }
}
