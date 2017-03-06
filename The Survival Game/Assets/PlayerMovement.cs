using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 0.1f;
    Rigidbody2D rg;
    Transform firePos;
    // Use this for initialization
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A)) //&& transform.position.x >= -25)
        {
            rg.AddForce(new Vector2(-1000, 0));
            //Vector3 position = this.transform.position;
            //position.x -= speed;
            //this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.D))  //&& transform.position.x <= 25)
        {
            rg.AddForce(new Vector2(1000, 0));
           // Vector3 position = this.transform.position;
            //position.x += speed;1
            //this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.W)) //&& transform.position.y <= 4.1)
        {
            rg.AddForce(new Vector2(0, 1000));
            //Vector3 position = this.transform.position;
            //position.y += speed;
            //this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= -4.1)
        {
            rg.AddForce(new Vector2(0, -1000));
            //Vector3 position = this.transform.position;
            //position.y -= speed;
            //this.transform.position = position;


        }

        if(!Input.GetKey(KeyCode.A)) 
        {
            rg.velocity = new Vector2(0, 0);      
        }

        if (!Input.GetKey(KeyCode.D))
        {
            rg.velocity = new Vector2(0, 0);
        }
    }

}
