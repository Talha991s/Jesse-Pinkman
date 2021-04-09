using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject player;
    public GameObject inventoryPanel;


    public List<Items> list = new List<Items>();

    void updatePanelSlots()
    {
        int index = 0;
        foreach(Transform child in inventoryPanel.transform)
        {
            //update slot[index] name and icon...
            InventorySlotController slot = child.GetComponent<InventorySlotController>();
            if(index < list.Count)
            {
                slot.item = list[index];
            }
            else
            {
                slot.item = null;
            }
            slot.updateInfo();
            index++;
        }
    }

    private void Start()
    {
        updatePanelSlots();
    }
}
