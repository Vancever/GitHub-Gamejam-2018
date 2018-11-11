using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Bag 
{
    private int _totalItems;
    private int _totalWeight;
    public List<Item> _items;

    public Bag() 
    {
        _totalWeight = 0;
    }

    public int TotalWeight 
    {
        get { return _totalWeight; }
        set 
        {
            _totalWeight = value;

            if (_items.Any(x => x.isCollectable)) //Grabs the list of items and lambda selects the ones collectable
            {
                //TODO:
            }
        }
    }

    public int TotalItems 
    {
        get { return _totalItems; }
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