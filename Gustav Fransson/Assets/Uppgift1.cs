using UnityEngine;
using System.Collections;

public class Uppgift1 : MonoBehaviour
{
    // Declares the values of Cisco, Cisco1, Cisco2, Cisco3, and Cisco4. 
    public int Cisco = 1;
    public int Cisco2 = 2;
    private int Cisco3 = 0;
    private int Cisco4 = 0;
   

	void Start ()
    {  
        // Here Cisco and Cisco2 changes value with each other.
        Cisco3 = Cisco;
        Cisco4 = Cisco2;
        Cisco = Cisco4;
        Cisco2 = Cisco3;
    }  
		
}
