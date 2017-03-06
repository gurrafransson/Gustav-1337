using UnityEngine;
using System.Collections;

public class Uppgift4 : MonoBehaviour {
    public float a;
    public float b;
    public float c;
	// I create variables.
	
    void Start () 
    {
        // Here it says that a has the same value as b but 5 less.
        a = b - 5;

        // Here It's going to say "CiscoRamon" in the console in unity if C is less than B and A less than C.
        if (c < b && c > a) 
        Debug.Log("CiscoRamon");
              
	}

}
