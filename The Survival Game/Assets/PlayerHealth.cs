using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    public int playerHealth = 10;
    public int currentHealth;







    // Use this for initialization
    void Start()
    {
        currentHealth = 10;
    }


    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

    }
}