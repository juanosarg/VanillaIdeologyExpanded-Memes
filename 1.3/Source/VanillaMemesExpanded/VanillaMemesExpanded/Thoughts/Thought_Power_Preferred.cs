using System;
using Verse;
using RimWorld;
using System.Collections.Generic;


namespace VanillaMemesExpanded
{
	public class Thought_Power_Preferred : ThoughtWorker
	{




		protected override ThoughtState CurrentStateInternal(Pawn p)
		{
			bool hasPrecept = p.Ideo.HasPrecept(InternalDefOf.VME_Power_Preferred);
            if (!hasPrecept)
            {
				return false;
            }
			bool positionOfPower = false;
			foreach (Precept_Role role in p.Ideo.RolesListForReading)
            {
				foreach (Pawn pawn in role.ChosenPawns())
				{
					if (pawn == p)
					{
						positionOfPower = true;
					}


				}
					

            }
            if (positionOfPower)
            {
				return true;
            } else return false;
		}

	}
}