using UnityEngine;
using Yarn.Unity;

public class YarnCommands
{
    [YarnCommand("log")]
    public static void Log(string debugMsg)
    {
        Debug.Log(debugMsg);
    }
}
