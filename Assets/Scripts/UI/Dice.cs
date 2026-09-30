using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public Image Die1;
    public Image Die2;
    public Sprite[] DieFacesActive;
    public Sprite[] DieFacesInactive;

    private void Start()
    {
        SetDie1Face(3, true);
        SetDie2Face(5);
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
