public static class Arrays
{
	public static void Run()
	{
		double[] multiples = MultiplesOf(7, 5);
		Console.WriteLine("<Array>{" + string.Join(", ", multiples) + "}"); // <Array>{7, 14, 21, 28, 35}

		// List<int> data = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		// RotateListRight(data, 3);
		// Console.WriteLine("<List>{" + string.Join(", ", data) + "}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
	}
	/// <summary>
	/// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
	/// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
	/// integer greater than 0.
	/// </summary>
	/// <returns>array of doubles that are the multiples of the supplied number</returns>
	public static double[] MultiplesOf(double number, int length)
	{
		// TODO Problem 1 Start
		// Remember: Using comments in your program, write down your process for solving this problem
		// step by step before you write the code. The plan should be clear enough that it could
		// be implemented by another person.

		//My solutions
		//First I will initiate a variable that holds a new array. I will  name the variable multiplesArray
		//Next, I will start my for loop that will run as long as i is less than the length. I will start i at 0 and increment it by 1 each time the loop runs.
		//Inside the loop, I will calculate the possible multiples by multiplying i and number.
		//Then I will calculate the modulo by taking the possible multiples and finding the remainder when divided by 3.
		//If the modulo is equal to 0, then I will add the possible multiples to the multiplesArray.
		//After the loop, I will convert the multiplesArray to an array and return it

		List<double> multiplesArray = new();
		for (int i = 0; i < length; i++)
		{
			double possibleMultiple = number * (i + 1);
			double modulo = possibleMultiple % 3;
			if (modulo == 0)
			{
				multiplesArray.Add(possibleMultiple);
			}
		}

		return multiplesArray.ToArray(); // replace this return statement with your own
	}

	/// <summary>
	/// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
	/// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
	/// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
	///
	/// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
	/// </summary>
	public static void RotateListRight(List<int> data, int amount)
	{
		// TODO Problem 2 Start
		// Remember: Using comments in your program, write down your process for solving this problem
		// step by step before you write the code. The plan should be clear enough that it could
		// be implemented by another person.

		//My solution
		//First I will create a new list called rotatedList that will hold the rotated values.
		//Next, I will start a for loop that will run from 0 to the amount. Inside the loop, I will add the last element of the data list to the rotatedList and then remove it from the data list.
		//After the loop, I will add the remaining elements of the data list to the rotatedList.
		//Finally, I will clear the original data list and add the elements from the rotatedList back to the data list.
		List<int> rotatedList = new();

		for (int i = 0; i < amount; i++)
		{
			rotatedList.Add(data[data.Count - 1]);
			data.RemoveAt(data.Count - 1);
		}

		data.AddRange(rotatedList);

	}
}
