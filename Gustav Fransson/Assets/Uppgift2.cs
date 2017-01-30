using UnityEngine;
using System.Collections;

public class Uppgift2 : MonoBehaviour {
    public float a;
    public float b;
    // I create 2 varibles.
 
	void Start () 
    {
    // I give the varibles 2 different values.
	a = 1;
    b = 2; 

    // Here i make so it says SUCCESS in the console in unity if B is bigger than A.
    if (b > a) Debug.Log("SUCCESS");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
