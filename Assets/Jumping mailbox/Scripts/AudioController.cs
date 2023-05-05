using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] List<AudioClip> clips;
    [SerializeField] AudioSource audioSource;

    public void PlaySound_1()
    {
        audioSource.Stop();
        audioSource.clip = clips[0];
        audioSource.Play();
    }
    
    public void PlaySound_2()
    {
        audioSource.Stop();
        audioSource.clip = clips[1];
        audioSource.Play();
    }
    
    public void PlaySound_3()
    {
        audioSource.Stop();
        audioSource.clip = clips[2];
        audioSource.Play();
    }
    
    public void PlaySound_4()
    {
        audioSource.Stop();
        audioSource.clip = clips[3];
        audioSource.Play();
    }
 public void PlaySound_5()
    {
        audioSource.Stop();
        audioSource.clip = clips[4];
        audioSource.Play();
    }
 public void PlaySound_6()
    {
        audioSource.Stop();
        audioSource.clip = clips[5];
        audioSource.Play();
    }
 public void PlaySound_7()
    {
        audioSource.Stop();
        audioSource.clip = clips[6];
        audioSource.Play();
    }
}