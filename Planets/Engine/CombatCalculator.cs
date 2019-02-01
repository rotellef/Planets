using Planets.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.Engine
{
	public class CombatCalculator
	{
		public static CombatResult DoCombat(Fleet fleetA, Fleet fleetB)
		{
			foreach (var shipsA in fleetA.Ships)
			{
				foreach (var shipsB in fleetB.Ships)
				{
					DoShipsCombat(shipsA, shipsB);
				}
			}
			return new CombatResult();
		}

		private static void DoShipsCombat(Ships shipsA, Ships shipsB)
		{
			if(shipsA.Ship.Class == ShipClass.FI)
			{

			}
		}
	}
}
