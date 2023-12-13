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
    public ItemSlot curSlot;

    public int index;
    public bool equipped = false;

    public void Set(ItemSlot slot)
    {
        curSlot = slot;
        icon.gameObject.SetActive(true);
        icon.sprite = slot.item.itemIcon;

        equipped = slot.isEquipped;
        equipmentMarker.SetActive(equipped);
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
