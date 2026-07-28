using UnityEngine;
using System.Collections.Generic;

public class Inventory
{
    List<Item> _items;

    // Default constructor for the Inventory
    //   When a new Intentory object is instantiated, this
    //   code is called to initialize the data
    public Inventory()
    {
        // TODO: add default items for the inventory
        // there should be (1) SWORD, (1) ROPE, (1) LANTERN, and (10) RATIONS


        Item rope = new("ROPE", 1);
        Item lantern = new("LANTERN", 1);
        Item ration = new("RATIONS", 10);


        _items.Add(new Item("SWORD", 1));
        _items.Add(rope);
        _items.Add(lantern);
        _items.Add(ration);
    }
}
