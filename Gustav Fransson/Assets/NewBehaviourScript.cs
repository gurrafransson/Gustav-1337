using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public int Cisco = 1;
    public int Cisco2 = 2;
    private int Cisco3 = 0;
    private int Cisco4 = 0;
    // Above here´give the ints values.

	void Start () 
    {
        Cisco3 = Cisco;
        Cisco4 = Cisco2;
        Cisco = Cisco4;
        Cisco2 = Cisco3;
	}   // Here I make Cisco and Cisco2 to get opposite values.
	
	// Update is called once per frame
	void Update () {
	
	}
}
