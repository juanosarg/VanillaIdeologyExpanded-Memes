﻿using System;
using Verse;
using RimWorld;
using System.Collections.Generic;

namespace VanillaMemesExpanded
{
	public class Thought_Illness_Exalted : ThoughtWorker
	{
		protected override ThoughtState CurrentStateInternal(Pawn p)
		{
			return ((p.Ideo.HasPrecept(InternalDefOf.VME_Illness_Exalted))|| (p.Ideo.HasPrecept(InternalDefOf.VME_Illness_Preferred))) && p.health.hediffSet.AnyHediffMakesSickThought;
		}
	}
}