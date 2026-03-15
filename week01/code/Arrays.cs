public static class Arrays
{
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
		//Inside the loop, I will calculate the possible multiples by multiplying i + 1 and number.
		//Then I will assign it to the multiples variable. I will then add the multiples variable to the multiplesArray at index i.
		//After the loop, I will return the multiplesArray.

		double[] multiplesArray = new double[length];
		for (int i = 0; i < length; i++)
		{
			double multiples = number * (i + 1);
			multiplesArray[i] = multiples;

		}

		return multiplesArray;
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
		//Next, I will start a for loop that will run from 0 to the amount.
		//Inside the loop, I will check if i is equal to the amount. If it is, I will take the part of the data array that starts from the index of data.Count - amount and has a length of the givenamount and add it to the firstArray list. I will also take the part of the data array that starts from index 0 and has a length of data.Count - amount and add it to the secondArray list.
		//After the loop, I will add the remaining elements of the data list to the rotatedList.
		//Finally, I will clear the original data list and add the elements from the rotatedList back to the data list.
		List<int> rotatedList = new();
		List<int> firstArray = new();
		List<int> secondArray = new();

		for (int i = 0; i <= amount; i++)
		{
			if (i == amount)
			{
				firstArray.AddRange(data.GetRange(data.Count - amount, amount));
				secondArray.AddRange(data.GetRange(0, data.Count - amount));
			}
		}

		rotatedList.AddRange(firstArray);
		rotatedList.AddRange(secondArray);

		data.Clear();
		data.AddRange(rotatedList);

	}
}
