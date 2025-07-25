using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue 3 items with different priorities and dequeue all
    // Expected Result: Return the highest priority each time
    // Defect(s) Found: Previously the last item was not considered and items were not removed.
    public void TestPriorityQueue_HighestFirst()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);

        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with the same priority
    // Expected Result: Items are returned in FIFO order
    // Defect(s) Found: None
    public void TestPriorityQueue_SamePriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("X", 5);
        pq.Enqueue("Y", 5);
        pq.Enqueue("Z", 5);

        Assert.AreEqual("X", pq.Dequeue());
        Assert.AreEqual("Y", pq.Dequeue());
        Assert.AreEqual("Z", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue on empty queue
    // Expected Result: InvalidOperationException with message
    // Defect(s) Found: None
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();

        try
        {
            pq.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}
