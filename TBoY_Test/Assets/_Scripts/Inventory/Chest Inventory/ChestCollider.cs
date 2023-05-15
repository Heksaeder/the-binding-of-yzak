using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollider : MonoBehaviour
{
    GameObject ChestManager;
    private GameObject Player;
    private GameObject InventoryManager;

     GameObject Inventory;
    // Start is called before the first frame update
    void Start()
    {

        Player = GameObject.Find("Personnage");
        ChestManager = GameObject.Find("ChestManager");
        InventoryManager = GameObject.Find("InventoryManager");
    }

//check when the player collides with the chest
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            ChestManager.GetComponent<ChestManager>().OpenChest();
            InventoryManager.GetComponent<InventoryManager>().OpenInventory();
            Debug.Log(InventoryManager.GetComponent<InventoryManager>());
        }
    }
}
