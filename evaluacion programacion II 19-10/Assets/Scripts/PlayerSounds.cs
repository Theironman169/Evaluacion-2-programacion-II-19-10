
using UnityEngine;

public class Player_Sounds : MonoBehaviour
{
    [Header("Sound Settings")]
    public AudioSource sfxSource;
    public AudioClip shootSound;
    public AudioClip hurtSound;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayShootSound();
        }
    }

    public void PlayShootSound()
    {
        if (sfxSource != null && shootSound != null)
        {
            sfxSource.PlayOneShot(shootSound);
        }
    }

    public void PlayHurtSound()
    {
        if (sfxSource != null && hurtSound != null)
        {
            sfxSource.PlayOneShot(hurtSound);
        }
    }
}
