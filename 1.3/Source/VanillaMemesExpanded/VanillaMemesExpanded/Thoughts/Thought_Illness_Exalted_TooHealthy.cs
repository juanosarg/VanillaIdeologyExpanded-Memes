using System;
using Verse;
using RimWorld;
using System.Collections.Generic;

namespace VanillaMemesExpanded
{
	public class Thought_Illness_Exalted_TooHealthy : ThoughtWorker
	{
		public const int tickInterval = 12000; //5 days


		protected override ThoughtState CurrentStateInternal(Pawn p)
		{
			if (!p.Ideo.HasPrecept(InternalDefOf.VME_Illness_Exalted))
            {
				return false;
			}

            if (p.health.hediffSet.AnyHediffMakesSickThought)
            {
				
				return false;
            }


			if (PawnCollectionClass.colonist_illness_tracker.ContainsKey(p)&&PawnCollectionClass.colonist_illness_tracker[p] > tickInterval)
			{
				return true;
			}
			return false;

		}
	}
}