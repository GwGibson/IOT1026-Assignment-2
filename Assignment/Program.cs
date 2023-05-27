namespace Assignment
{
    static class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Hello World");
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Manipulate(TreasureChest.Action.Open);
            System.Console.WriteLine(chest);
        }
    }
}
