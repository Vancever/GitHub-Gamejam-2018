using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> _items;
    public Canvas hudCanvas;

    public Inventory() 
    {
        _items = new List<GameObject>();
    }

    public void collectItem(GameObject item)
    {
        _items.Add(item);
        hudCanvas.GetComponent<InventoryRenderer>().UpdateInventory(_items);
    }
}