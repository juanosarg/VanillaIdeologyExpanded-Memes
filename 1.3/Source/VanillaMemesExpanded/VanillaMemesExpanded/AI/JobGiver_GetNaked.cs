using System;
using UnityEngine;
using Verse;
using Verse.AI;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class JobGiver_GetNaked : ThinkNode_JobGiver
	{
		protected override Job TryGiveJob(Pawn pawn)
		{
			pawn.Drawer.renderer.graphics.ClearCache();
			pawn.Drawer.renderer.graphics.apparelGraphics.Clear();
			return null;
		}

		
	}
}