using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemNameList : MonoBehaviour
{

    public string itemName;

    public CharacterMovement myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggeEnter2D(Collider2D collision)
    {
        myPlayer.addItem(itemName);
        Destroy(gameObject);
    }
}
