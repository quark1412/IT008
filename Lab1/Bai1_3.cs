using System;
using System.Collections.Generic;

public class Bai1_3
{
	public static void Main()
	{
		List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 1, 10, 2523 };
		List<double> doubleList = new List<double>() { 1.4, 232.2, 45.23, 51.8, 15.029 };
		List<string> stringList = new List<string>() { "itn s", "k20akr", "29t2k", "ald20", "2okda" };

		Console.Write("1. Phan tu lon nhat: \n- Day so nguyen: {0}\n- Day so thuc: {1}\n Day chuoi: {2}\n", FindMaxElement(intList), FindMaxElement(doubleList), FindMaxElement(stringList));
		Console.Write("2. Phan tu nho nhat: \n- Day so nguyen: {0}\n- Day so thuc: {1}\n Day chuoi: {2}\n", FindMinElement(intList), FindMinElement(doubleList), FindMinElement(stringList));

	}

	public static T FindMaxElement<T>(List<T> list) where T : IComparable<T>
	{
		if (list.Count == 0)
		{
			throw new Exception("Danh sach rong!");
		}

		T max = list[0];

		foreach (T element in list)
		{
			if (element.CompareTo(max) > 0)
			{
				max = element;
			}
		}

		return max;
	}

	public static T FindMinElement<T>(List<T> list) where T : IComparable<T>
	{
		if (list.Count == 0)
		{
			throw new Exception("Empty list!");
		}

		T min = list[0];

		foreach (T element in list)
		{
			if (element.CompareTo(min) < 0)
			{
				min = element;
			}
		}

		return min;
	}
}
