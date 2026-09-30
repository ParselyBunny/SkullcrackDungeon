using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public Image Die1;
    public Image Die2;
    public Sprite[] DieFacesActive;
    public Sprite[] DieFacesInactive;

    private Storyteller _storyteller;

    private void Awake()
    {
        _storyteller = FindAnyObjectByType<Storyteller>();

        if (_storyteller != null)
        {
            _storyteller.DiceRolled.AddListener(RollDice);
        }
    }

    private void RollDice()
    {
        int die1 = Utility.D6();
        int die2 = Utility.D6();

        Debug.Log($"Rolled dice: die 1: {die1}, die 2: {die2}");

        SetDie1Face(die1);
        SetDie2Face(die2);
    }

    private void SetDie1Face(int faceValue, bool isActive = false)
    {
        switch (isActive)
        {
            case true:
                Die1.sprite = DieFacesActive[faceValue - 1];
                break;
            case false:
                Die1.sprite = DieFacesInactive[faceValue - 1];
                break;
        }
    }

    private void SetDie2Face(int faceValue, bool isActive = false)
    {
        switch (isActive)
        {
            case true:
                Die2.sprite = DieFacesActive[faceValue - 1];
                break;
            case false:
                Die2.sprite = DieFacesInactive[faceValue - 1];
                break;
        }
    }
}
