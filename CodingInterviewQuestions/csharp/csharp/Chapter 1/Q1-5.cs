using System;
using System.Text;

namespace csharp
{
	/// <summary>
	/// Write a method to replace all spaces in a string with ‘%20’.
	/// </summary>
	public class Q1_5
	{
		public static string ReplaceSpaces(string input)
		{
			var builder = new StringBuilder();

			for (var i = 0; i < input.Length; i++)
			{
				if (input[i] != ' ')
				{
					builder.Append(input[i]);
				}
				else
				{
					builder.Append("%20");
				}
			}

			return builder.ToString();
		}
	}
}

