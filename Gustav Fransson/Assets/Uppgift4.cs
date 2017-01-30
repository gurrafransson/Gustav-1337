using UnityEngine;
using System.Collections;

public class Uppgift4 : MonoBehaviour {
    public float a;
    public float b;
    public float c;
	// I create variables.
	void Start () 
    {
        // First i say that a is 5 less than b.
        a = b - 5;
        // Here i say that if C is less than B and A less than C it should type "CiscoRamon" in the console in unity.
        if (c < b && c > a) 
        Debug.Log("CiscoRamon");
        
        
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
