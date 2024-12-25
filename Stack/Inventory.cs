using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Stack<Item> itemStack = new Stack<Item>();

    public void AddItem(Item item)
    {
        itemStack.Push(item);
        Debug.Log($"Item added: {item.itemName}");
    }

    public void RemoveItem()
    {
        if (itemStack.Count > 0)
        {
            Item removedItem = itemStack.Pop();
            Debug.Log($"Item removed: {removedItem.itemName}");
        }
        else
        {
            Debug.Log("Inventory is empty!");
        }
    }
    public void DisplayInventory()
    {
        Debug.Log("Current Inventory:");
        foreach (var item in itemStack)
        {
            Debug.Log($"- {item.itemName} (ID: {item.itemID})");
        }
    }
    public List<Item> GetItemList()
    {
        // itemStack içeriðini bir listeye dönüþtürerek döndür
        return new List<Item>(itemStack);
    }
}
