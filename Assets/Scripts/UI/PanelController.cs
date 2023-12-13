using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public GameObject buttonPanel;
    public GameObject statusPanel;
    public GameObject inventoryPanel;

    public void PopupStatusPanel()
    {
        buttonPanel.SetActive(false);
        statusPanel.SetActive(true);
    }

    public void PopupInventoryPanel()
    {
        buttonPanel.SetActive(false);
        inventoryPanel.SetActive(true);
    }
}
