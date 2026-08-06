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

    public int Find(string itemName)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            if (_items[i] != null &&
                _items[i].Name.ToLower() == itemName.ToLower())
            {
                return i;
            }
        }

        throw new System.Exception(
            $"Could not find item {itemName} in Inventory.");
    }

    // TODO: Come up with a different way of doing this that 
    //   permits you to fail to find an item, without crashing the game :)
    public int GetItemQuantity(string itemName) => 
        _items[Find(itemName)].Quantity;
    public void SetItemQuantity(string name, int val) =>
        _items[Find(name)].Set(val);
    public void AddItemQuantity(string name, int val) => 
        _items[Find(name)].Add(val);
}
