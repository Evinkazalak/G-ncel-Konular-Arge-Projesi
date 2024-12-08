using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class ShapeManager : MonoBehaviour
{

    public Class1()
    {

    }


    public GameObject halfShapePrefab;  // Şeklin yarısı (örneğin, kare yarısı)
    public GameObject fullShapePrefab; // Şeklin tamamlanmış hali
    public AudioClip successClip;      // Doğru eşleştirme sesi
    public AudioClip tryAgainClip;     // Yanlış eşleştirme sesi

    private GameObject currentHalfShape;
    private GameObject currentFullShape;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GenerateShape();
    }

    void GenerateShape()
    {
        // Şeklin yarısını oluştur ve AR düzlemine yerleştir
        Vector3 position = new Vector3(0, 0, 1.5f); // Kamera önünde bir yer
        currentHalfShape = Instantiate(halfShapePrefab, position, Quaternion.identity);
        // Tamamlanmış şekli oluştur ve görünmez yap
        currentFullShape = Instantiate(fullShapePrefab, position + Vector3.right * 1.5f, Quaternion.identity);
        currentFullShape.SetActive(false);
    }

    public void CheckCompletion(GameObject userInputShape)
    {
        if (userInputShape.name == fullShapePrefab.name) // Kullanıcının seçimi doğru mu?
        {
            ShowCompleteShape();
            PlaySuccessSound();
        }
        else
        {
            PlayTryAgainSound();
        }
    }

    void ShowCompleteShape()
    {
        currentHalfShape.SetActive(false);
        currentFullShape.SetActive(true);
    }

    void PlaySuccessSound()
    {
        audioSource.clip = successClip;
        audioSource.Play();
    }
    void PlayTryAgainSound()
    {
        audioSource.clip = tryAgainClip;
        audioSource.Play();
    }

}