using UnityEditor;
using UnityEngine;

public static class SoundManager
{
 public static void PlaySound()
    {
        GameObject gameObject = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameManager.Instance.sfx_wing);
    }
    public static void PlaySound1()
    {
        GameObject gameObject = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameManager.Instance.sfx_point);
    }
}
