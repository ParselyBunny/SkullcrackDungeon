using UnityEngine;

public static class Dice
{
    public static int D6()
    {
        return Random.Range(1, 7);
    }

    public static int[] D6(int numOfDice)
    {
        int[] result = new int[numOfDice];

        for (int i = 0; i < numOfDice; i++)
        {
            result[i] = Random.Range(1, 7);
        }

        return result;
    }

    public static int Sum(int[] dice)
    {
        int result = 0;

        foreach(int d in dice)
        {
            result += d;
        }

        return result;
    }
}
