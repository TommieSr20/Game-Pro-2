using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public static CharacterController Instance;

    public GameObject player;
    public float speed = 0.5f;


    public List<string> myInventory;

    // Start is called before the first frame update
    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
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

        if(myInventory.Count >=)
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
      
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Entered trigger");
        }
    }

        public void addItem(string item)
    {
        myInventory.Add(item);
    }



}
