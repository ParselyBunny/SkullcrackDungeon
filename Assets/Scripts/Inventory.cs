using UnityEngine;
using System.Collections.Generic;

public class Inventory
{
    List<Item> _items = new();

    public Inventory()
    {
        _items.Add(new Item("SWORD", 1));
        _items.Add(new Item("ROPE", 1));
        _items.Add(new Item("LANTERN", 1));
        _items.Add(new Item("RATIONS", 10));
    }
}
