using UnityEngine;

public class Item
{
    public string Name { get; private set; }
    public int Quantity
    {
        get => _quantity;
        private set
        {
            if (value >= 0)
            {
                _quantity = value;
            }
            else
            {
                _quantity = 0;
            }
        }
    }

    private int _quantity;

    public Item(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public void Add(int val) => Quantity += val;
    public void Set(int val) => Quantity = val;
}
