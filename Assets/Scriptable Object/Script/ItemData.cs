using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Consumable
}

public enum ChangingParameter
{
    HP,
    Attack,
    Defence,
    CritRate
}

[System.Serializable]
public class StatChange
{
    public ChangingParameter change;
    public float value;
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]

public class ItemData : ScriptableObject
{
    [Header("Item Details")]
    public string itemName;
    public string description;
    public Sprite itemIcon;
    public ItemType itemType;
    public bool isConsumable;
    public int id;

    [Header("Stacking")]
    public bool isStackable;
    public int maxStack;

    [Header("Equipment Stats")]
    public StatChange[] equipmentStats;
}
