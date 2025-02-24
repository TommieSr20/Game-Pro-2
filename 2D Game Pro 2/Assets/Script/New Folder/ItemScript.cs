using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    public string Key;

    public PlayerMovDictInv myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerMovDictInv>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggeEnter2D(Collider2D collision)
    {
                myPl
                Destroy(gameObject);
    }
}
