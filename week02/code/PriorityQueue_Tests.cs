using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
	[TestMethod]
	// Scenario: Dequeueing items with highest priorities and should return them at the back of the queue no matter their priority value is
	// Expected Result: sonya, sonya, sonya
	// Defect(s) Found: 
	public void TestPriorityQueue_1()
	{

		var sophie = new PriorityItem("Sophie", 1);
		var lance = new PriorityItem("Lance", 10);
		var sonya = new PriorityItem("Sonya", 31);

		var priorityQueue = new PriorityQueue();

		priorityQueue.Enqueue(sophie.Value, sophie.Priority);
		priorityQueue.Enqueue(lance.Value, lance.Priority);
		priorityQueue.Enqueue(sonya.Value, sonya.Priority);

		PriorityItem[] expectedResult = [sonya, sonya, sonya];

		int i = 0;
		while (i < expectedResult.Length)
		{
			var removed = priorityQueue.Dequeue();

			Assert.AreEqual(expectedResult[i].Value, removed);
			i++;
		}

		// Assert.Fail("Implement the test case and then remove this.");
	}

	[TestMethod]
	// Scenario: Dequeueing items with the same priority and should return at the back of the queue no matter their priority value is
	// Expected Result: sophie, lance, sophie, lance
	// Defect(s) Found:
	public void TestPriorityQueue_2()
	{

		var sophie = new PriorityItem("Sophie", 10);
		var lance = new PriorityItem("Lance", 10);
		var sonya = new PriorityItem("Sonya", 9);

		var priorityQueue = new PriorityQueue();

		priorityQueue.Enqueue(sophie.Value, sophie.Priority);
		priorityQueue.Enqueue(lance.Value, lance.Priority);
		priorityQueue.Enqueue(sonya.Value, sonya.Priority);

		PriorityItem[] expectedResult = [sophie, lance, sophie, lance];

		int i = 0;
		while (i < expectedResult.Length)
		{
			var removed = priorityQueue.Dequeue();

			Assert.AreEqual(expectedResult[i].Value, removed);
			i++;
		}

		// Assert.Fail("Implement the test case and then remove this.");
	}

	// Add more test cases as needed below.
}