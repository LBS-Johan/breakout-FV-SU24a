using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioClip blockBreakSound;   // Sound for block break
    private AudioSource audioSource;    // Optional, if you want to use PlayOneShot or other methods.

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>(); // Set up AudioSource if you want to play sounds via it
    }

    // This method plays the block break sound at a given position.
    public void PlayBlockBreakSound(Vector3 position)
    {
        AudioSource.PlayClipAtPoint(blockBreakSound, position); // Plays sound at position
    }
}
