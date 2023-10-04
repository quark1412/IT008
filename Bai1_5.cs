using System;
using System.IO;

public class Bai1_5
{
	public static void Main()
	{
		string path = Console.ReadLine();
		
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFileSystemEntries(path);

			foreach (string file in files)
			{
				Console.WriteLine(file);
			}
		}
		else
		{
			Console.WriteLine("Duong dan khong ton tai!");
		}
	}
}