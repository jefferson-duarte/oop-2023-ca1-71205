using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_2023_ca1_71205.Models;

namespace oop_2023_ca1_71205.ClientGeneration
{
	public static class ClientGeneration
	{
		public static List<Client> Clients()
		{
			List<Client> client = new();

			CarPark carPark = new CarPark();

			for (int i = 0; i < 24; i++)
			{
				var user = new Client();
				user.Name = Faker.Name.FullName(Faker.NameFormats.WithPrefix);
				user.CustomerID = Faker.Identification.UKNationalInsuranceNumber();
				client.Add(user);
			}

			return client;
		}
	}
}
