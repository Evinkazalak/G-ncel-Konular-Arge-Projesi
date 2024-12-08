using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public Class1()
    {

    }
	
	

  
//Çocuklara görsel ve sesli geri bildirim sağlamak için kullanıcı arayüzünü yönetir.




    public Text feedbackText;
    public GameObject nextLevelButton;

    public void ShowFeedback(string message, Color color)
    {
        feedbackText.text = message;
        feedbackText.color = color;
        feedbackText.gameObject.SetActive(true);

        // Birkaç saniye sonra geri bildirimi gizle
        Invoke("HideFeedback", 2f);
    }

    void HideFeedback()
    {
        feedbackText.gameObject.SetActive(false);
    }

    public void ShowNextLevelButton()
    {
        nextLevelButton.SetActive(true);
    }

    public void OnNextLevelButtonClicked()
    {
        // Yeni bir zorluk seviyesi oluştur
        nextLevelButton.SetActive(false);
        FindObjectOfType<ShapeManager>().GenerateShape();
    }
}
