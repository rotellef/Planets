using Newtonsoft.Json;
using Planets.Domain;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Planets
{
	internal class ShipUtils
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		private static Dictionary<string, Ship> _ships;
		public static Dictionary<string, Ship> ShipStats
		{
			get => _ships = _ships ?? ParseShips();
		}

		private static Dictionary<string, Ship> ParseShips()
		{


			string fileName = "shipList.json";
			var list = JsonConvert.DeserializeObject<List<Ship>>(System.IO.File.ReadAllText(fileName));
			var dict = new Dictionary<string, Ship>();
			foreach (var ship in list)
			{
				dict.Add(ship.Name, ship);
			}
			return dict;
		}
	}
}