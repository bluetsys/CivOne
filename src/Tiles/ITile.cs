// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

using System.Collections.Generic;
using System.Drawing;
using CivOne.Enums;
using CivOne.Units;

namespace CivOne.Tiles
{
	public interface ITile : ICivilopedia
	{
		int X { get; }
		int Y { get; }
		Terrain Type { get; }
		bool Special { get; }
		byte ContinentId { get; set; }
		byte LandValue { get; set; }
		byte LandScore { get; }
		byte Movement { get; }
		byte Defense { get; }
		sbyte Food { get; }
		sbyte Shield { get; }
		sbyte Trade { get; }	
		sbyte IrrigationFoodBonus { get; }
		byte IrrigationCost { get; }
		sbyte MiningShieldBonus { get; }
		byte MiningCost { get; }
		byte Borders { get; }
		bool Road { get; set; }
		bool RailRoad { get; set; }
		bool Irrigation { get; set; }
		bool Fortress { get; set; }
		bool Mine { get; set; }
		bool Hut { get; set; }
		byte Visited { get; }
		void Visit(byte owner);
		bool IsOcean { get; }
		City City { get; }
		IUnit[] Units { get; }
		ITile this[int relativeX, int relativeY] { get; }
	}
}