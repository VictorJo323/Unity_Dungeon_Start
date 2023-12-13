using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlotUI : MonoBehaviour
{
    public Button button;
    public Image icon;
    public GameObject equipmentMarker;
    private ItemSlot curSlot;

    public int index;
    public bool equipped = false;

    public void Set(ItemSlot slot)
    {
        curSlot = slot;
        icon.gameObject.SetActive(true);
        icon.sprite = slot.item.itemIcon;
        if(equipped)
        {
            equipmentMarker.SetActive(true);
        }
        else
        {
            equipmentMarker.SetActive(false);
        }
    }

    public void Clear()
    {
        curSlot = null;
        icon.gameObject.SetActive(false);
        equipmentMarker.SetActive(false);
    }

    public void OnButtonClick()
    {
        Inventory.instance.SelectItem(index);
    }
}
