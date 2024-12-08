using System;
using UnityEngine;

public class Class1
{
// Dinamik Zorluk Artırımı*
//Zorluk seviyelerini kontrol etmek için seviyelere göre prefab şekiller ile oluşturulur.

public class DifficultyManager : MonoBehaviour
{
    public ShapeLoader shapeLoader;  // Şekilleri yükleyen sınıf
    public int currentLevel = 1;

    public void AdjustDifficulty()
    {
        if (currentLevel <= 3)
        {
            shapeLoader.LoadRandomShape();  // Basit şekiller
        }
        else if (currentLevel <= 5)
        {
            // Daha karmaşık şekiller için yeni prefab'ler ekleyin
            shapeLoader.LoadRandomShape();
        }
        else
        {
            // Çokgenler veya desenler
            shapeLoader.LoadRandomShape();
        }
    }

    public void LevelUp()
    {
        currentLevel++;
        AdjustDifficulty();
    }
}
public Class1()
	{
	}
}
