// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

using CivOne.Enums;

namespace CivOne.Advances
{
	internal class SuperConductor : BaseAdvance
	{
		public SuperConductor() : base(5, 2, 2, Advance.Plastics, Advance.MassProduction)
		{
			Name = "SuperConductor";
			Type = Advance.SuperConductor;
		}
	}
}