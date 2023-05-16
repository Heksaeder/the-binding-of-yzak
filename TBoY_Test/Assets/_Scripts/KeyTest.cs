using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyTest : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Player;
    private GameObject Door;
    private GameObject Inventory;

    void Start()
    {
        Door = GameObject.Find("Door");
        Inventory = GameObject.Find("InventoryManager");
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            if (Inventory.GetComponent<InventoryManager>().Items.Contains(InventoryManager.GetItem("Bomb")))
            {
            Debug.Log("opened door");
            //changes scenes 
            SceneManager.LoadScene("01_Menu");
            }
            else
            {
                Debug.Log("Il vous manque votre PC");
            }
        }
    }
}
