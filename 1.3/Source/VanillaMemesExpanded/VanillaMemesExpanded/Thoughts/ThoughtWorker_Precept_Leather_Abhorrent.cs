using System;
using Verse;
using RimWorld;
using System.Collections.Generic;

namespace VanillaMemesExpanded
{
	public class ThoughtWorker_Precept_Leather_Abhorrent : ThoughtWorker_Precept
	{
		protected override ThoughtState ShouldHaveThought(Pawn p)
		{
			bool flag = false;
			List<Apparel> wornApparel = p.apparel.WornApparel;
			for (int i = 0; i < wornApparel.Count; i++)
			{
				if (wornApparel[i].Stuff?.defName.Contains("Leather")==true)
				{
					flag = true;
				}
			}

			if (flag)
			{

				return ThoughtState.ActiveAtStage(0);
			}
			else return false;






		}
	}
}