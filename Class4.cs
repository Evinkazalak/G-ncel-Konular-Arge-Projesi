using System;
using UnityEngine;


public class Class1
{
   // Şekil Seçici Kod(Random Shape Loader) :*


public class ShapeLoader : MonoBehaviour
{
    public GameObject[] halfShapes;  // Kırmızı ve mavi yarım şekiller
    public Transform spawnPoint;

    public void LoadRandomShape()
    {
        int randomIndex = Random.Range(0, halfShapes.Length);
        Instantiate(halfShapes[randomIndex], spawnPoint.position, Quaternion.identity);
    }
}
public Class1()
	{
	}
}
