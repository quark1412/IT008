using System;

public class Thermometer
{
	private float temperature;

	public float Temperature
	{
		get { return temperature; }
		set
		{
			if (temperature != value)
			{
				temperature = value;
			}
		}
	}

	public void SimulateTemperatureChange()
	{
		Random rand = new Random();
		Temperature = rand.Next(0, 100);
	}
}

public class TemperatureDisplay
{
	public void ShowTemperature(float temperature)
	{
		Console.WriteLine("Nhiet do hien tai: {0}°C", temperature);
	}
}

class Program
{
	static void Main(string[] args)
	{
		Thermometer thermometer = new Thermometer();
		TemperatureDisplay display = new TemperatureDisplay();

		for (int i = 0; i < 5; i++)
		{
			thermometer.SimulateTemperatureChange();
			display.ShowTemperature(thermometer.Temperature);
		}
	}
}
