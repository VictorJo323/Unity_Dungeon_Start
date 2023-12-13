using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemSlot
{
    public ItemData item;
    public bool isEquipped;
}
public class Inventory : MonoBehaviour
{
    public ItemSlotUI[] uiSlot;
    public ItemSlot[] slots;

    public GameObject inventoryWindow;
    public GameObject confirmWindow;

    [Header("Selected Item")]
    private ItemSlot selectedItem;
    private int selectedItemIdx;

    public TextMeshProUGUI selectedItemName;
    public TextMeshProUGUI selectedItemDescription;
    public TextMeshProUGUI selectedItemStatNames;
    public TextMeshProUGUI selectedItemStatValues;

    

}
