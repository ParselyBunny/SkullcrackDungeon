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
        Item sword = new(SWORD, 1);  // Ugh, why isn't it working??? :'(
        _items.Add("sword");
    }
}
