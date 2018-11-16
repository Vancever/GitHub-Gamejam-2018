using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Inventory 
{
    private int _totalItems;
    private int _totalWeight;
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
        }
    }

    public int TotalItems 
    {
        get { return _items.length; }
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