using System;
using UnityEngine;

public class Class1
{
    //Animator’da bir *Trigger* ekleyin ve* Success* olarak adlandırın.Bu, doğru eşleşme durumunda animasyonu oynatır.
    


//### Ses Efektleri
//Ses efektlerini eklemek için:
//. *AudioClip* ekle  (ör.alkış sesi)

public class AudioFeedback : MonoBehaviour
{
    public AudioClip successSound;
    public AudioClip levelChangeSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySuccessSound()
    {
        audioSource.clip = successSound;
        audioSource.Play();
    }

    public void PlayLevelChangeSound()
    {
        audioSource.clip = levelChangeSound;
        audioSource.Play();
    }
}
public Class1()
	{
	}
}
