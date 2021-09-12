using System;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class Thought_IdeoRole_FireKeeper : ThoughtWorker_Precept_Social
	{
		protected override ThoughtState ShouldHaveThought(Pawn p, Pawn otherPawn)
		{
			Precept_Role precept_role;

			if (p.Faction == otherPawn.Faction && p.Ideo == otherPawn.Ideo && p.Ideo.HasPrecept(InternalDefOf.VME_IdeoRole_FireKeeper) &&
				(precept_role = p.Ideo.GetPrecept(InternalDefOf.VME_IdeoRole_FireKeeper) as Precept_Role) != null && precept_role.ChosenPawnSingle() == otherPawn)
			{
				
				
					return ThoughtState.ActiveAtStage(0);
				


			}
			else return false;




		}


	}
}
