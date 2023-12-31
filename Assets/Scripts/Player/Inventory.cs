using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ItemSlot
{
    public ItemData item;
    public bool isEquipped;
}
public class Inventory : MonoBehaviour
{
    public ItemSlotUI[] uiSlot;
    public ItemSlot[] slots;
    public ItemDatabase itemDatabase;

    public GameObject inventoryWindow;
    public GameObject confirmWindow;

    [Header("Selected Item")]
    private ItemSlot selectedItem;
    private int selectedItemIdx;

    public TextMeshProUGUI selectedItemName;
    public TextMeshProUGUI selectedItemDescription;
    public TextMeshProUGUI selectedItemStatNames;
    public TextMeshProUGUI selectedItemStatValues;

    public static Inventory instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        slots = new ItemSlot[uiSlot.Length];

        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = new ItemSlot();
            uiSlot[i].index = i;
            uiSlot[i].Clear();
        }

        InitialInventorySetup();
    }

    private void InitialInventorySetup()
    {
        AddItemToInventory(itemDatabase.FindItemById(5));
        AddItemToInventory(itemDatabase.FindItemById(4));
        AddItemToInventory(itemDatabase.FindItemById(2));
        AddItemToInventory(itemDatabase.FindItemById(1));
    }

    private void AddItemToInventory(ItemData itemData)
    {
        ItemSlot emptySlot = GetEmptySlot();
        if (emptySlot != null)
        {
            emptySlot.item = itemData;
            UpdateUI();
        }
    }

    void AddItemToSlot(ItemData itemData, int slotIndex)
    {
        if (slotIndex >= 0 && slotIndex < slots.Length)
        {
            slots[slotIndex].item = itemData;
            UpdateUISlot(slotIndex);
        }
    }

    public void UpdateUISlot(int slotIndex)
    {
        if(slots[slotIndex].item != null)
        {
            uiSlot[slotIndex].Set(slots[slotIndex]);
        }
        else
        {
            uiSlot[slotIndex].Clear();
        }
    }

    public void SelectItem(int index)
    {
        if (slots[index].item == null)
        {
            return;
        }

        selectedItem = slots[index];
        selectedItemIdx = index;

        selectedItemName.text = selectedItem.item.itemName;
        selectedItemDescription.text = selectedItem.item.description;

        selectedItemStatNames.text = string.Empty;
        selectedItemStatValues.text = string.Empty;
    }
    public void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item != null)
            {
                uiSlot[i].Set(slots[i]);
            }
            else
            {
                uiSlot[i].Clear();
            }
        }
    }
    ItemSlot GetEmptySlot()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                return slots[i];
            }
        }
        return null;
    }
}

