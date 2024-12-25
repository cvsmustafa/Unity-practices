using UnityEngine;

public class InventoryTest : MonoBehaviour
{
    private Inventory inventory;

    void Start()
    {
        inventory = GetComponent<Inventory>();

        // Örnek öðeler oluþtur
        Item sword = new Item("Sword", 201);
        Item shield = new Item("Shield", 202);
        Item potion = new Item("Potion", 203);

        // Envantere öðeler ekle
        inventory.AddItem(sword);
        inventory.AddItem(shield);
        inventory.AddItem(potion);

        // Envanteri göster
        inventory.DisplayInventory();

        // En son eklenen öðeyi çýkar
        inventory.RemoveItem();
        inventory.RemoveItem();

        // Kalan envanteri göster
        inventory.DisplayInventory();
    }
}
