using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

public interface IAbility { }

public interface IThinking : IAbility
{
	void thinking_behavior() { }
}

public interface IIntelligent : IAbility
{
	void intelligent_behavior() { }
}


public class Mamal
{
	string characteristics = "";
}

public class Whale : Mamal
{
	public Whale() {}
}

public class Human : Mamal, IAbility
{
	public void thinking_behavior()
	{
		Console.WriteLine("Thinking about you <3");
	}
	public void intelligent_behavior()
	{
		Console.WriteLine("Doing homework");
	}
}

public class Bai1_6
{
	public static void Main()
	{
	}
}
