// C# program to implement
// the above appraoch
using System;
using System.Collections.Generic;

class GFG_getMinimumMoves
{

	// Function to return minimum
	// number of moves required

	public static int getMinimumMoves(int n, int k,
							int d, int[] a)
	{
		int MAX = 100000;

		// Stores the number of moves
		// required to obtain respective
		// values from the given array
		List<int>[] v = new List<int>[MAX];
		for (int i = 0; i < v.Length; i++)
			v[i] = new List<int>();

		// Traverse the array
		for (int i = 0; i < n; i++)
		{
			int cnt = 0;

			// Insert 0 into V[a[i]] as
			// it is the initial state
			v[a[i]].Add(0);

			while (a[i] > 0)
			{
				a[i] /= d;
				cnt++;

				// Insert the moves required
				// to obtain current a[i]
				v[a[i]].Add(cnt);
			}
		}

		int ans = int.MaxValue;

		// Traverse v[] to obtain
		// minimum count of moves
		for (int i = 0; i < MAX; i++)
		{

			// Check if there are at least
			// K equal elements for v[i]
			if (v[i].Count >= k)
			{
				int move = 0;

				v[i].Sort();

				// Add the sum of minimum K moves
				for (int j = 0; j < k; j++)
				{
					move += v[i][j];
				}

				// Update answer
				ans = Math.Min(ans, move);
			}
		}

		// Return the final answer
		return ans;
	}

	// Driver Code
	
}


