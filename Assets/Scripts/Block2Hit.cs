using UnityEngine;

public class Block2Hit : MonoBehaviour
{
    public AudioClip breakSound;
    private AudioSource audioSource;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Call the SoundManager to play the sound
            if (SoundManager.Instance != null && breakSound != null)
            {
                Debug.Log("Playing sound...");
                SoundManager.Instance.PlayBlockBreakSound(transform.position); // Use the position of the block
            }
            else
            {
                Debug.LogError("SoundManager is missing or breakSound is not assigned!");
            }

            // Destroy the block after playing sound
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // No need to get an AudioSource in this script now
        if (breakSound == null)
        {
            Debug.LogError("Break sound is not assigned!");
        }
    }
}
