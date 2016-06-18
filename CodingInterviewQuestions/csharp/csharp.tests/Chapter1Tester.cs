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
	}
}

