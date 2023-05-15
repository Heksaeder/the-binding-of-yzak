using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public List<Item> Items = new List<Item>();

    private GameObject Inventory;

    public Transform ItemContent;

    public GameObject InventoryItem;

    private void Awake()
    {
        Inventory = GameObject.Find("Inventory");
        Instance = this;
    }

    // Update is called once per frame
    public void TransferItem(Item item)
    {
        Items.Add (item);
        ChestManager.Instance.Remove (item);
    }

    public void AddItem(Item item)
    {
        Items.Add (item);
    }

    public void RemoveItem(Item item)
    {
        Items.Remove (item);
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

    public void OpenInventory()
    {
        ListItems();
        Inventory.SetActive(true);
    }

    public void ClearItems()
    {
        foreach (Transform child in ItemContent)
        {
            Destroy(child.gameObject);
        }
    }
}
