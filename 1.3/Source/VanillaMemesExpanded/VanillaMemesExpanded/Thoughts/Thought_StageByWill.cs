using System;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class Thought_StageByWill : ThoughtWorker_Precept_Social
	{
		protected override ThoughtState ShouldHaveThought(Pawn p, Pawn otherPawn)
		{
			Precept_Role precept_role;

			if (p.Faction == otherPawn.Faction && p.Ideo == otherPawn.Ideo && p.Ideo.HasPrecept(InternalDefOf.VME_Leader_Godlike) &&
				(precept_role = p.Ideo.GetPrecept(PreceptDefOf.IdeoRole_Leader) as Precept_Role) != null && precept_role.ChosenPawnSingle() == otherPawn)
			{
				if (p.ideo.Certainty < 0.25f)
				{
					return ThoughtState.ActiveAtStage(3);
				}
				else if (p.ideo.Certainty < 0.50f)
				{
					return ThoughtState.ActiveAtStage(2);
				}
				else if (p.ideo.Certainty < 0.75f)
				{
					return ThoughtState.ActiveAtStage(1);
				}
				else
				{
					return ThoughtState.ActiveAtStage(0);
				}


			}
			else return false;

			


		}

       
    }
}
