using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChestManager : MonoBehaviour
{
    public static ChestManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;
    public GameObject chestInventory;

    private void Start()
    {
        chestInventory = GameObject.Find("ChestInventory");
    }
    private void OnMouseDown() {
            OpenChest();
            chestInventory.SetActive(true);
            Debug.Log("Chest Opened");
    }
    public void OpenChest()
    {
        ListItems();
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
            var itemName = obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();

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
