using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Potion,
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]

public class ItemData : ScriptableObject
{
    [Header("Item Details")]
    public string itemName;
    public Sprite itemIcon;
    public ItemType itemType;

    public int itemValue;
    public bool isStackable;
    public int maxStack;
}
