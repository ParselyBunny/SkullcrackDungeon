using UnityEngine;
using Yarn.Unity;

public class YarnCommands
{
    [YarnCommand("log")]
    public static void Log(string debugMsg)
    {
        Debug.Log(debugMsg);
    }

    /// <summary>
    /// Returns true if application is playing in the Unity Editor.
    /// </summary>
    [YarnFunction("isEditor")]
    public static bool IsEditor()
    {
        return Application.isEditor;
    }
}
