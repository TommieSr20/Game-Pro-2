using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += Vector3.up * speed; 
           // Debug.Log("W Pressed");
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left * speed;
            //Debug.Log("A Pressed");
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += Vector3.down * speed;
            //Debug.Log("S Pressed");
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed;
            //Debug.Log("D Pressed");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(player);
        }
    }


}
