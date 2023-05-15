using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChestManager : MonoBehaviour
{
    public static ChestManager Instance;

    public List<Item> Items = new List<Item>();

    public Transform ItemContent;

    public GameObject InventoryItem;

    public GameObject chestInventory;

    public void TransferItem(Item item)
    {
        // Find the item game object in the chest content
        var content = chestInventory.transform.Find("Viewport/Content");
        var itemObject = content.transform.Find(item.itemName).gameObject;

        Debug.Log(itemObject.name);
        Debug.Log(item.itemName);
        // Remove the item game object from the chest content
        Destroy(itemObject);

        // Add the item to the inventory
        InventoryManager.Instance.AddItem(item);

        // Update the chest inventory item list
        InventoryManager.Instance.ListItems();
    }

    public void Add(Item item)
    {
        Items.Add (item);
    }

    public void Remove(Item item)
    {
        Items.Remove (item);
    }

    public void OpenChest()
    {
        chestInventory.SetActive(true);
        Debug.Log("Chest Opened");
    }

    private void Awake()
    {
        Instance = this;
    }

    public void ListItems()
    {
        ClearItems();
        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            var itemName =
                obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.itemImage;
        }
    }

    public void ClearItems()
    {
        foreach (Transform child in ItemContent)
        {
            Destroy(child.gameObject);
        }
    }
}
