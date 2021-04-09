using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Consumable", menuName = "Item/Consumables")]
public class Consumables : Items
{
    public int heal = 0;
    private Heath heath;
    public override void Use()
    {
        GameObject player = Inventory.instance.player;
        Heath playerhealth = player.GetComponent<Heath>();
        playerhealth.Heal(heal);
        Inventory.instance.Remove(this);

    }
}
