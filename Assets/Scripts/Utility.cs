using UnityEngine;

public static class Utility
{
    public static int D6()
    {
        return Random.Range(1, 7);
    }

    /// <summary>
    /// Rolls some arbitrary number of dice and returns an array 
    /// containing the results.
    /// </summary>
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
