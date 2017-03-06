using UnityEngine;
using System.Collections;

public class Uppgift2 : MonoBehaviour
{
    // Created 2 variables and gave them values.
    public float a = 1;
    public float b = 2;


    void Start()
    {
        // Here i make so it says SUCCESS in the console in unity if B is bigger than A.
        if (b > a) Debug.Log("b is larger than a");
    }

}
