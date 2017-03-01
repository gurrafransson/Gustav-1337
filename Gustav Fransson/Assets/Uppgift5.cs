using UnityEngine;
using System.Collections;

public class Uppgift5 : MonoBehaviour
{
    public int a = 10;
    public int b = 5;
    private int c;
    public float d = 10;
    public float e = 0;

    int Method(int a, int b)
    {
        return a + b;
        //Its a method
    }
    // Use this for initialization
    void Start()
    {
        c = Method(a, b);
        if (c < e && c > d)
        {
            Debug.Log("Cisco");
        }
        //Prints if c is bigger than d and smaller than e.
        else
        {
            Debug.Log("Cisco");
        }
        //Prints if c is biger than e or smaller than d.
    }

    // Update is called once per frame
    void Update()
    {

    }

}
