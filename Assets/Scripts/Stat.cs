public struct Stat
{
    public string Name { get; private set; }
    public int BaseValue { get; private set; }
    public int CurrentValue { get; private set; }

    public Stat(string name, int baseVal)
    {
        Name = name;
        BaseValue = baseVal;
        CurrentValue = baseVal;
    }

    public void AddCurrent(int add)
    {
        if (CurrentValue + add < 0)
        {
            CurrentValue = 0;
        }
        else
        {
            CurrentValue += add;
        }
    }

    public void SetCurrent(int val)
    {
        if (val < 0)
        {
            CurrentValue = 0;
        }
        else
        {
            CurrentValue = val;
        }
    }

    public void AddBase(int add)
    {
        int difference = add - BaseValue;

        if (BaseValue + add < 0)
        {
            BaseValue = 0;
        }
        else
        {
            BaseValue += add;
            AddCurrent(add);
        }
    }

    public void SetBase(int val)
    {
        int difference = val - BaseValue;

        if (val < 0)
        {
            BaseValue = 0;
        }
        else if (difference > 0)
        {
            BaseValue = val;
            AddCurrent(difference);
        }
        else
        {
            BaseValue = val;
        }
    }
}
