using System;
using System.Security.Cryptography.X509Certificates;
using oop_2023_ca1_71205.Models;
using oop_2023_ca1_71205.ClientGeneration;

abstract class CarParkValue
{
	protected float hourGarage;
	protected float fixedValue;
	protected float additionalFeelGarage1;
	protected float additionalFeelGarage2;
	protected float additionalFeelGarage3;

	public CarParkValue()
	{
		hourGarage = 0f;
		fixedValue = 2f;
		additionalFeelGarage1 = 0f;
		additionalFeelGarage2 = 0f;
		additionalFeelGarage3 = 0f;
	}

	public float getHourGarage(float hourGarage)
	{
		return hourGarage;
	}
}

class CarPark : CarParkValue
{
	public CarPark()
	{
		additionalFeelGarage1 = 0.50f;
		additionalFeelGarage2 = 0.60f;
		additionalFeelGarage3 = 0.75f;
	}

	public float garage1(float hourGarage)
	{
		float valueTotal = 0f;

		if (hourGarage <= 3) 
		{
			valueTotal = fixedValue;
		} 
		else if (hourGarage > 3) 
		{
			valueTotal = fixedValue + (additionalFeelGarage1 * (hourGarage - 3));
		}

		return valueTotal;
	}

	public float garage2(float hourGarage)
	{
		float valueTotal = 0f;

		if (hourGarage <= 3)
		{
			valueTotal = fixedValue;
		}
		else if (hourGarage > 3)
		{
			valueTotal = fixedValue + (additionalFeelGarage2 * (hourGarage - 3));
		}

		return valueTotal;
	}

	public float garage3(float hourGarage)
	{
		float valueTotal = 0f;

		if (hourGarage <= 3)
		{
			valueTotal = fixedValue;
		}
		else if (hourGarage > 3)
		{
			valueTotal = fixedValue + (additionalFeelGarage3 * (hourGarage - 3));
		}

		return valueTotal;
	}

}

class EachPark
{
	public static void Main()
	{
		float hours, c1, c2, c3, c4;

		CarPark client1 = new CarPark();
		CarPark client2 = new CarPark();
		CarPark client3 = new CarPark();

		hours = client1.getHourGarage(6);
		c1 = client1.garage1(hours);
		Console.WriteLine($"Garage 1 - Cliente 1: {c1}");
		Console.WriteLine("=============================================");

		hours = client1.getHourGarage(6);
		c2 = client1.garage1(hours);
		Console.WriteLine($"Garage 1 - Cliente 2: {c2}");
		Console.WriteLine("=============================================");

		hours = client1.getHourGarage(6);
		c3 = client1.garage1(hours);
		Console.WriteLine($"Garage 1 - Cliente 3: {c3}");
		Console.WriteLine("=============================================");

		hours = client1.getHourGarage(6);
		c4 = client1.garage1(hours);
		Console.WriteLine($"Garage 1 - Cliente 4: {c4}");
		Console.WriteLine("=============================================");

		hours = client2.getHourGarage(6);
		c2 = client2.garage2(hours);
		Console.WriteLine($"Garage 2 - Cliente 2: {c2}");
		Console.WriteLine("=============================================");

		hours = client3.getHourGarage(6);
		c3 = client3.garage3(hours);
		Console.WriteLine($"Garage 3 - Cliente 3: {c3}");
		Console.WriteLine("=============================================");


		foreach (var user in ClientGeneration.Clients())
		{
			Console.WriteLine(user.ToString());
		}


	}
}