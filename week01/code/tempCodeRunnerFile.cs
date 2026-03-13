public static double[] MultiplesOf(double number, int length)
	{
		// TODO Problem 1 Start
		// Remember: Using comments in your program, write down your process for solving this problem
		// step by step before you write the code. The plan should be clear enough that it could
		// be implemented by another person.
		//First I will initiate a variable that holds a new array. I will  name the variable multiplesArray
		//Next, I will start my For

		List<double> newArray = new();

		for (int i = 0; i < length; i++)
		{
			double possibleMultiples = i * number;
			double modulo = possibleMultiples % 3;

			if (modulo == 0) newArray.Add(possibleMultiples);
		}
		;

		double[] array = newArray.ToArray();

		return array; // replace this return statement with your own
	}