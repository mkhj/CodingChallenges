using System;
namespace csharp
{
	/// <summary>
	/// Write a method to decide if two strings are anagrams or not.
	/// </summary>
	public class Q1_4
	{
		public static bool IsAnagram(string word1, string word2)
		{
			var chars1 = word1.ToCharArray();
			var chars2 = word2.ToCharArray();

			Array.Sort(chars1);
			Array.Sort(chars2);

			var sortedWord1 = String.Join("", chars1);
			var sortedWord2 = String.Join("", chars2);

			return string.Compare(sortedWord1, sortedWord2, true) == 0;
		}
	}
}

