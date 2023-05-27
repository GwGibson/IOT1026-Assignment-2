using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {public void OpenLockedTest()
        {
            // Chest starts in the locked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            // Try to open the chest
            // Verify chest is still locked
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }public void OpenClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }        public void OpenOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }
    }
}
