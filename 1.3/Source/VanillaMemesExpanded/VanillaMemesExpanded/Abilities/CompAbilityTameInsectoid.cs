﻿using System;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class CompAbilityTameInsectoid : CompAbilityEffect
	{
		public new CompProperties_AbilityTameInsectoid Props
		{
			get
			{
				return (CompProperties_AbilityTameInsectoid)this.props;
			}
		}

		public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
		{
			Pawn pawnInsect = target.Thing as Pawn;

			if (pawnInsect != null && pawnInsect.RaceProps.Insect && pawnInsect.Faction != Faction.OfPlayer)
			{
				InteractionWorker_RecruitAttempt.DoRecruit(this.parent.pawn, pawnInsect, true);
				DebugActionsUtility.DustPuffFrom(pawnInsect);
			}
			else
			{
				Messages.Message("VME_AbilityNeedsInsect".Translate(), MessageTypeDefOf.RejectInput, true);
				this.parent.StartCooldown(30);
			}



			base.Apply(target, dest);

		}
	}
}
