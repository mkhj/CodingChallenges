using System;

namespace MSCodeChallenge
{
	/// <summary>
	/// A list of some of the potential questions you could be presented with.
	/// You have 10-15 min so solve as many as possible.
	/// You are not allow to use any libraries etc.
	/// </summary>
	public interface IQuestions
	{
		/// <summary>
		/// Findet Factorial af tallene op til og med number f.eks. Input: 5 Output: 120 
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		long Factorial(int number);

		/// <summary>
		/// Finder summen af alle lige tal op til limit.
		/// </summary>
		/// <param name="limit"></param>
		/// <returns></returns>
		int SumEven(int limit);

		/// <summary>
		/// Findet det andet højeste tal i Numbers f.eks. Input: 6,2,34,7,9 Output: 9
		/// </summary>
		/// <param name="numbers"></param>
		/// <returns></returns>
		int SecondHighst(int[] numbers);

		/// <summary>
		/// Finder antallet af omtrædener af FrequenceOf i text.
		/// </summary>
		/// <param name="text"></param>
		/// <param name="FrequenceOf"></param>
		/// <returns></returns>
		int FindFrequence(String text, char FrequenceOf);

		/// <summary>
		/// Finder gennemsnitter af tallene i numbers
		/// </summary>
		/// <param name="numbers"></param>
		/// <returns></returns>
		int FindAverage(int[] numbers);

		/// <summary>
		/// Find summen af tallene i anden op til number. F.eks. input: 5 Output: 30
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		long SumSquares(int number);

		/// <summary>
		/// Finder ud af om input er et Palimdrom, altså hvis man vender teksten om, om det er det samme som før, altså f.eks. Abba = True, og Ost = False
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		bool Palindrom(String input);

		/// <summary>
		/// Find det største tal, af a og b
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		int Largest(int a, int b);

		/// <summary>
		/// Finder volumen ud fra højden, breden, og dybten
		/// </summary>
		/// <param name="height"></param>
		/// <param name="width"></param>
		/// <param name="depth"></param>
		/// <returns></returns>
		int Volume(int height, int width, int depth);

		/// <summary>
		/// Tæl antallet af ord. f.eks. input: "Hello, World!" , output = 2
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		int WordCount(String text);
	}
}

