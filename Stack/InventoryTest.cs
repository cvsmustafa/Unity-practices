using UnityEngine;

public class InventoryTest : MonoBehaviour
{
    private Inventory inventory;

    void Start()
    {
        inventory = GetComponent<Inventory>();

        // �rnek ��eler olu�tur
        Item sword = new Item("Sword", 201);
        Item shield = new Item("Shield", 202);
        Item potion = new Item("Potion", 203);

        // Envantere ��eler ekle
        inventory.AddItem(sword);
        inventory.AddItem(shield);
        inventory.AddItem(potion);

        // Envanteri g�ster
        inventory.DisplayInventory();

        // En son eklenen ��eyi ��kar
        inventory.RemoveItem();
        inventory.RemoveItem();

        // Kalan envanteri g�ster
        inventory.DisplayInventory();
    }
}
