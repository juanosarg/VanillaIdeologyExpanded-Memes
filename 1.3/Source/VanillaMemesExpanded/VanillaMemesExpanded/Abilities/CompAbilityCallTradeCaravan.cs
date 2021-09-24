using System;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class CompAbilityCallTradeCaravan : CompAbilityEffect
	{
		public new CompProperties_AbilityCallTradeCaravan Props
		{
			get
			{
				return (CompProperties_AbilityCallTradeCaravan)this.props;
			}
		}

		public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
		{

			IncidentDef IncidentDef = IncidentDefOf.TraderCaravanArrival;
			IncidentParms parms = StorytellerUtility.DefaultParmsNow(IncidentDef.category, this.parent.pawn.Map);
			IncidentDef.Worker.TryExecute(parms);



			base.Apply(target, dest);

		}
	}
}
