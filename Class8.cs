using System;
using UnityEngine;
using UnityEngine.UI;


public class Class1
{
// Eğitsel Geri Bildirimlerle Görsel/İşitsel Destek*
// Kod (Doğru/Yanlış Cevapların Geri Bildirimi):
    

public class FeedbackManager : MonoBehaviour
{
    public Text feedbackText;

    public void ShowFeedback(bool isCorrect)
    {
        if (isCorrect)
        {
            feedbackText.text = "Tebrikler! Bu bir kare oldu!";
            feedbackText.color = Color.green;
        }
        else
        {
            feedbackText.text = "Tekrar deneyin!";
            feedbackText.color = Color.red;
        }

        Invoke("ClearFeedback", 2f);  // 2 saniye sonra geri bildirimi temizle
    }

    void ClearFeedback()
    {
        feedbackText.text = "";
    }
}
public Class1()
	{
	}
}
