using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour
{
    public ItemSlotUI itemSlotUI;

    public void ToggleEquip()
    {
        if (itemSlotUI.curSlot == null || itemSlotUI.curSlot.item == null)
        {
            return;
        }

        foreach(var slot in Inventory.instance.slots)
        {
            if(slot.item!=null && slot != itemSlotUI.curSlot && slot.item.itemType==itemSlotUI.curSlot.item.itemType)
            {
                slot.isEquipped = false;
            }
        }
        itemSlotUI.curSlot.isEquipped = !itemSlotUI.curSlot.isEquipped;
        Inventory.instance.UpdateUI();
    }
}
