using System;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class Thought_Power_Exalted : ThoughtWorker_Precept
	{

		


		protected override ThoughtState ShouldHaveThought(Pawn p)
		{
			Precept_Role precept_role;
			return p.Ideo.HasPrecept(InternalDefOf.VME_Power_Exalted) &&
				(precept_role = p.Ideo.GetPrecept(PreceptDefOf.IdeoRole_Leader) as Precept_Role) != null && precept_role.ChosenPawnSingle() == p;

		}

	}
}

