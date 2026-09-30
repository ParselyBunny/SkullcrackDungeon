using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource SFX;
    public AudioSource Music;
    public AudioSource Ambience;

    private void Start()
    {
        PlaySFX("SFX/diceRolling");
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
}
