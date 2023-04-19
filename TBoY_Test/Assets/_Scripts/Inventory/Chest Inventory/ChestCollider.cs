using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollider : MonoBehaviour
{
    private GameObject Chest;
    GameObject ChestManager;
    private GameObject Player;
    private GameObject InventoryManager;

    private GameObject Inventory;
    // Start is called before the first frame update
    void Start()
    {
        Chest = GameObject.Find("Chest");
        Player = GameObject.Find("Personnage");
        ChestManager = GameObject.Find("ChestManager");
        InventoryManager = GameObject.Find("InventoryManager");
        Inventory = GameObject.Find("Inventory");
    }

//check when the player collides with the chest
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            ChestManager.GetComponent<ChestManager>().OpenChest();
            InventoryManager.GetComponent<InventoryManager>().OpenInventory();
        }
    }
}
