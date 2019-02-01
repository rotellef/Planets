using Newtonsoft.Json;
using Planets.Domain;
using System.IO;
using System.Collections.Generic;

namespace Planets
{
	public class ShipUtils
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		public static readonly string Interceptor = "Interceptor";
		public static readonly string Dagger = "Dagger";
		public static readonly string Torpedo = "Torpedo";
		public static readonly string WarFrigate = "War Frigate";
		public static readonly string Destroyer = "Destroyer";
		public static readonly string WarCruiser = "War Cruiser";
		public static readonly string Battleship = "Battleship";
		public static readonly string CargoShip = "CargoShip";
		public static readonly string AstroPod = "Astro Pod";
		public static readonly string Phantom = "Phantom";
		public static readonly string Spider = "Spider";
		public static readonly string Ghost = "Ghost";
		public static readonly string Tarantula = "Tarantula";
		public static readonly string LaserTurret = "Laser Turrent";
		public static readonly string EmpTurret = "EMP Turrent";
		public static readonly string PlasmaTurret = "Plasma Turrent";
		public static readonly string IonTurret = "Ion Turrent";


		private static Dictionary<string, Ship> _ships;
		public static Dictionary<string, Ship> ShipStats
		{
			get => _ships = _ships ?? ParseShips();
		}

		private static Dictionary<string, Ship> ParseShips()
		{


			string fileName = "shipList.json";
			var list = JsonConvert.DeserializeObject<List<Ship>>(File.ReadAllText(fileName));
			var dict = new Dictionary<string, Ship>();
			foreach (var ship in list)
			{
				dict.Add(ship.Name, ship);
			}
			return dict;
		}
	}
}