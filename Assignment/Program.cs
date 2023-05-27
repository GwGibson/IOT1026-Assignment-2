using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Treasure Chest
            TreasureChest chest = new TreasureChest();

            // Test default constructor and GetState method
            Console.WriteLine($"Initial State: {chest.GetState()}");

            // Test Manipulate method with different actions
            Console.WriteLine($"New State: {chest.Manipulate(TreasureChest.Action.Open)}");
            Console.WriteLine($"New State: {chest.Manipulate(TreasureChest.Action.Lock)}");
            Console.WriteLine($"New State: {chest.Manipulate(TreasureChest.Action.Unlock)}");
            Console.WriteLine($"New State: {chest.Manipulate(TreasureChest.Action.Close)}");
            Console.WriteLine($"New State: {chest.Manipulate(TreasureChest.Action.Open)}");

            // Test the constructor with parameters and ToString method//
            TreasureChest customChest = new TreasureChest(TreasureChest.Material.RichMahogany,
                                                          TreasureChest.LockType.Intermediate,
                                                          TreasureChest.LootQuality.Purple);
            Console.WriteLine(customChest.ToString());
        }
    }
}
