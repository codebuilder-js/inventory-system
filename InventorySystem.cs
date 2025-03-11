using System;
using System.Collections.Generic;

public class InventorySystem {
    private Dictionary<string, int> inventory = new Dictionary<string, int>();
    
    public void AddProduct(string productName, int quantity) {
        if(inventory.ContainsKey(productName))
            inventory[productName] += quantity;
        else
            inventory[productName] = quantity;
    }
    
    public void RemoveProduct(string productName, int quantity) {
        if(inventory.ContainsKey(productName)) {
            inventory[productName] -= quantity;
            
            if(inventory[productName] <= 0)
                inventory.Remove(productName);
        }
    }
    
    public void ShowInventory() {
        Console.WriteLine("Estoque atual:");
        
        foreach(var item in inventory) {
            Console.WriteLine($" - {item.Key}: {item.Value}");
        }
    }
}
