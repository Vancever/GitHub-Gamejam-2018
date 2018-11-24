using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> _items;

    public Inventory() 
    {
        _items = new List<Item>();
    }

    public void collectItem(Item item)
    {

    }
}