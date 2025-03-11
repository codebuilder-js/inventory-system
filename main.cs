using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        InventorySystem inventory = new InventorySystem();
        
        inventory.AddProduct("Hidrômetro", 10);
        inventory.AddProduct("Sensor de Água", 5);
        inventory.ShowInventory();
        inventory.RemoveProduct("Hidrômetro", 7);
        inventory.ShowInventory();
    }
}
