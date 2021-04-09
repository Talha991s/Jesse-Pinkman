using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlotController : MonoBehaviour
{
    public Items item;
    private void Start()
    {
        updateInfo();
    }
    public void updateInfo()
    {
        TMP_Text displayText = transform.Find("Text").GetComponent<TMP_Text>();
        Image displayImage = transform.Find("Image").GetComponent<Image>();
        if(item)
        {
            displayText.text = item.itemName;
            displayImage.sprite = item.icon;
            displayImage.color = Color.white;
        }
        else
        {
            displayText.text = "";
            displayImage.sprite = null;
            displayImage.color = Color.clear;
        }
    }

    public void Use()
    {
        if(item)
        {
            Debug.Log("You Clicked" + item.itemName);
        }
    }
}
