using System;
using NUnit.Framework;

namespace csharp.tests
{
	[TestFixture()]
	public class Chapter1Tester
	{
		[Test()]
		public void Run_Q1_1()
		{
			Assert.IsTrue(Q1_1.IsUnique("abcde"));

			Assert.IsFalse(Q1_1.IsUnique("hello"));

			Assert.IsFalse(Q1_1.IsUnique("helLo"));
		}

		[Test()]
		public void Run_Q1_2()
		{
			Assert.IsFalse("apple" == Q1_2.Reverse("apple"));

			Assert.IsTrue("elppa" == Q1_2.Reverse("apple"));
			               
		}

		[Test()]
		public void Run_Q1_4()
		{
			Assert.IsFalse(Q1_4.IsAnagram("hello", "llloh"));

			Assert.IsTrue(Q1_4.IsAnagram("apple", "papel"));

			Assert.IsTrue(Q1_4.IsAnagram("carrot", "tarroc"));

		}

		[Test()]
		public void Run_Q1_5()
		{
			var input = "abc d e f";

			Assert.IsTrue(Q1_5.ReplaceSpaces(input) == "abc%20d%20e%20f");
		}
	}
}

