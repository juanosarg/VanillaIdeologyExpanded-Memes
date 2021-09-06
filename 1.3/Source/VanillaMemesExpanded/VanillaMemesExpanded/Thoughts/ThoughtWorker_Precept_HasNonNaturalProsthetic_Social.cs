using System;
using Verse;
using RimWorld;
using System.Collections.Generic;

namespace VanillaMemesExpanded
{
	public class ThoughtWorker_Precept_HasNonNaturalProsthetic_Social : ThoughtWorker_Precept_Social
	{
		protected override ThoughtState ShouldHaveThought(Pawn p, Pawn otherPawn)
		{
			return CountAddedAndImplantedParts(otherPawn.health.hediffSet) > 0;
		}

		public int CountAddedAndImplantedParts(HediffSet hs)
		{
			int num = 0;
			List<Hediff> hediffs = hs.hediffs;
			for (int i = 0; i < hediffs.Count; i++)
			{
				if (hediffs[i].def.countsAsAddedPartOrImplant && !hediffs[i].def.spawnThingOnRemoved.thingCategories.Contains(ThingCategoryDef.Named("BodyPartsNatural")))
				{
					num++;
				}
			}
			return num;
		}
	}
}