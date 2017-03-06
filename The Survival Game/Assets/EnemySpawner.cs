using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public Vector2 position;
    public float timer;
    private float startTimer;

    // Use this for initialization
    void Start()
    {
        startTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            position.y = Random.Range(4.5f, -4.5f);
            Instantiate(enemy, position, Quaternion.Euler(0, 0, 0));
            timer = startTimer;
        }

        //brb 1 sec!!
        timer -= Time.deltaTime;
    }
}
