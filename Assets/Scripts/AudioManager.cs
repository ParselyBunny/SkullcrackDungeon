using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource SFX;
    public AudioSource Music;
    public AudioSource Ambience;

    private Storyteller _storyteller;

    private void Start()
    {
        _storyteller = FindAnyObjectByType<Storyteller>();

        if (_storyteller != null)
        {
            _storyteller.DiceRolled.AddListener(PlayDiceRoll);
        }
    }

    public void PlaySFX(string path)
    {
        AudioClip clip = Resources.Load<AudioClip>(path);

        if (clip != null)
        {
            SFX.PlayOneShot(clip);
        }
        else
        {
            Debug.LogError($"Could not play sound at {path}. \n" +
                $"Did you use forward slashes and leave out " +
                $"the file extension?");
        }
    }

    private void PlayDiceRoll()
    {
        PlaySFX("SFX/diceRolling");
    }
}
