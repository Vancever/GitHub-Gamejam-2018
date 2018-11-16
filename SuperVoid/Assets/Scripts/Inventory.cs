using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public float maxWeight;
    public List<Item> _items;

    public Inventory() 
    {
        _items = new List<Item>();
    }

    public float TotalWeight 
    {
        get {
            float weight = 0;

            foreach(Item item in _items)
            {
                weight += item.Weight;
            }

            return weight;
        }
    }

    public int TotalItems 
    {
        get { return _items.Count; }
    }


    //TODO:
    public void CallTitle()
    {
        throw new NotImplementedException();
    }

    public bool Empty()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}