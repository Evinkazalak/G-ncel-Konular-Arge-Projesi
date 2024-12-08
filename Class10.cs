using System;
using UnityEngine;


public class Class1
{
    //Renk İpuçları
    // Kırmızı ve mavi renklerde ipuçları ekleyerek çocukların rehberlik almasını  sağlarsın.




    public class ColorHint : MonoBehaviour
    {
        public SpriteRenderer shapeRenderer;

        public void HighlightShape()
        {
            shapeRenderer.color = Color.blue;  // Örneğin mavi ipucu
            Invoke("ResetColor", 1f);
        }

        void ResetColor()
        {
            shapeRenderer.color = Color.white;  // Rengi varsayılan renge döndür
        }
    }

}

