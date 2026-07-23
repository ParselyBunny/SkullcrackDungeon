using UnityEngine;

public class Item
{
    public string Name { get; private set; }
    public int Quantity
    {
        get => _quantity;
        private set
        {
            if (value < 0)
            {
                _quantity = value;
            }
        }
    }

    private int _quantity;

    public Item(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}
