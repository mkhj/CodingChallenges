using System;
namespace csharp
{
	public class Q1_2
	{
		public static string Reverse(string word)
		{
			var chars = word.ToCharArray();
			Array.Reverse(chars);
			return string.Join("", chars);
		}
	}
}

