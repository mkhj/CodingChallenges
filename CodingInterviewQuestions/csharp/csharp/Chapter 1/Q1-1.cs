using System;
using System.Collections;

namespace csharp
{
	public class Q1_1
	{
		public static bool IsUnique(string word)
		{
			word = word.ToLower();

			var chars = new Hashtable();

			for (var i = 0; i < word.Length; i++)
			{
				if (chars.ContainsKey(word[i]))
				{
					return false;
				}

				chars.Add(word[i], true);
			}

			return true;
		}


	}
}

