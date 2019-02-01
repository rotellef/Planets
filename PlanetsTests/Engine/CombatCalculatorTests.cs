using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planets.Domain;
using Planets.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.Engine.Tests
{
	[TestClass()]
	public class CombatCalculatorTests
	{
		[TestMethod()]
		public void DoCombatTest()
		{
			var result = CombatCalculator.DoCombat(
				new Fleet() { Ships = new List<Ships>() { new Ships() { Ship = ShipUtils.ShipStats[ShipUtils.Interceptor], Count = 10 } } },
				new Fleet() { Ships = new List<Ships>() { new Ships() { Ship = ShipUtils.ShipStats[ShipUtils.Interceptor], Count = 10 } } }
			);

		}
	}
}