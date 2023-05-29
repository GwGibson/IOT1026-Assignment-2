using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a treasure chest
            TreasureChest chest = new TreasureChest();

            // Test default constructor and GetState method
            Console.WriteLine($"Initial State: {chest.GetState()}");

            // Test Manipulate method with different actions
            // Test Manipulate method with different actions
            Console.WriteLine($"New State: {chest.Manipulate(TreasureChest.Action.Open)}");
            Console.WriteLine($"New State: {chest.Manipulate(TreasureChest.Action.Lock)}");
            Console.WriteLine($"New State: {chest.Manipulate(TreasureChest.Action.Unlock)}");
            Console.WriteLine($"New State: {chest.Manipulate(TreasureChest.Action.Close)}");
            Console.WriteLine($"New State: {chest.Manipulate(TreasureChest.Action.Open)}");

            // Test parameterized constructor and ToString method
            TreasureChest customChest = new TreasureChest(
                                                         TreasureChest.Material.Silver,
                                                         TreasureChest.LockType.Advanced,
                                                         TreasureChest.LootQuality.Rare);
            Console.WriteLine(customChest.ToString());
        }
    }
}
