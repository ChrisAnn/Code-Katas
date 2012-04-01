using System;
using System.Collections.Generic;

namespace KarateChop
{
	public class KarateChop
	{
		public static int Iterative(int valueToFind, int[] values)
		{
			int start = 0;
			int middle = 0;
			int end = values.Length;
			
			while(start != end)
			{
				middle = (start + end) / 2;
				if(values[middle] == valueToFind)
					return middle;
				if(values[middle] > valueToFind)
					end = middle;
				else
					start = middle + 1;
			}
			
			return -1;
		}
		
		public static int Recursive(int valueToFind, int[] values)
		{
			if(values.Length == 0)
				return -1;
			
			int mid = values.Length / 2;
			
			if(values[mid] == valueToFind)
				return mid;
			else if(mid == 0)
				return 0;
			
			if(values[mid] > valueToFind)
			{
				int[] half = new int[mid];
				Array.Copy(values, half, mid);
				return Recursive(valueToFind, half);
			} else
			{
				int[] half = new int[values.Length - mid];
				Console.WriteLine(mid);
				Array.Copy(values, mid, half, 0, values.Length - mid);
				return mid + Recursive(valueToFind, half);
			}
		}
	}
}

