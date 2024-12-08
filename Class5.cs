using System;
using UnityEngine;

public class Class1
{
   // Kod(Animasyonu Tetikleme) :*



public class ShapeAnimator : MonoBehaviour
{
    public Animator shapeAnimator;

    public void PlaySuccessAnimation()
    {
        shapeAnimator.SetTrigger("Success");
    }
}
public Class1()
	{
	}
}
