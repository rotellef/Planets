using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.Domain
{
	public class Ships
	{
		public Ship Ship { get; set; }
		public int Count { get; set; }
	}
	public class Ship
	{
		public string Name { get; set; }
		[JsonConverter(typeof(StringEnumConverter))]
		public ShipClass Class { get; set; }
		[JsonConverter(typeof(StringEnumConverter))]
		public ShipClass TargetPrimary { get; set; }
		[JsonConverter(typeof(StringEnumConverter))]
		public ShipClass TargetSecondary { get; set; }
		public int Init { get; set; }
		public int Agility { get; set; }
		public int Weaponspeed { get; set; }
		public int Guns { get; set; }
		public int Power { get; set; }
		public int Armour { get; set; }
		public int Resistance { get; set; }
		public int Metal { get; set; }
		public int Crystal { get; set; }
		public int Fuel { get; set; }
		public int ETA { get; set; }

		[JsonConverter(typeof(StringEnumConverter))]
		public ShipType Type { get; set; }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			Ship other = obj as Ship;
			return Name == other.Name && Class == other.Class;
		}

		public override string ToString() =>
			$"{Name}, {Class}, {TargetPrimary}, {TargetSecondary}, {Init}, {Type}";
	}
	public enum ShipType { Classic, Special, Cloaked, EMP, PDS }
	public enum ShipClass { FI,	CO,	FR,	DE,	CR,	BS,	NA }
}
