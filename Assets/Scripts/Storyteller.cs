using UnityEngine;
using UnityEngine.Events;

public class Storyteller : MonoBehaviour
{
    public UnityEvent DiceRolled;

    private void Start()
    {
        DiceRolled.Invoke();
    }
}
