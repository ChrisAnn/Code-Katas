using System;
using System.Collections.Generic;

namespace KarateChop
{
	public class KarateChop
	{
		public static int Chop(int valueToFind, IList<int> values)
		{
			if(values.Count == 1)
			if(values[0] == valueToFind)
				return 0;
			
			return -1;
		}
	}
}

