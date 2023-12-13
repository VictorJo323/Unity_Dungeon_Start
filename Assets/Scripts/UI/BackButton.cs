using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject buttonPanel;
    public GameObject statusPanel;
    public GameObject inventoryPanel;

    public void GoBack()
    {
        statusPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        buttonPanel.SetActive(true);
    }
}
