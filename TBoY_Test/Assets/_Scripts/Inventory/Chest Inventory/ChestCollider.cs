using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollider : MonoBehaviour
{
    GameObject ChestManager;

    private GameObject Player;

    private GameObject InventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        ChestManager = GameObject.Find("ChestManager");
        InventoryManager = GameObject.Find("InventoryManager");
    }

    //check when the player collides with the chest
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            //if the player has the key, open the chest and the player's inventory
            if (
                InventoryManager
                    .GetComponent<InventoryManager>()
                    .Items[0]
                    .itemName ==
                "Key"
            )
            {
                Debug.Log("opened chest");
                InventoryManager
                    .GetComponent<InventoryManager>()
                    .OpenInventory();
                ChestManager.GetComponent<ChestManager>().OpenChest();
            }
        }
    }
}
