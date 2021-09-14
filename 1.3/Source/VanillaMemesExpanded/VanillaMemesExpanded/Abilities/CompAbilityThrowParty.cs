using System;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class CompAbilityThrowParty : CompAbilityEffect
	{
		public new CompProperties_AbilityThrowParty Props
		{
			get
			{
				return (CompProperties_AbilityThrowParty)this.props;
			}
		}

		public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
		{
			
			if (!Find.CurrentMap.lordsStarter.TryStartRandomGathering(true))
			{
				Messages.Message("Could not find any valid gathering spot or organizer.", MessageTypeDefOf.RejectInput, false);
			}
			base.Apply(target, dest);

		}
	}
}
