using Verse;
using RimWorld;

namespace VanillaMemesExpanded
{
	public class HediffComp_Infections : HediffComp
	{

        public override void CompPostMake()
        {
            Pawn pawn = this.parent.pawn;
            if (pawn.ideo != null && !pawn.ideo.Ideo.HasPrecept(InternalDefOf.VME_OrganUse_PostMortem))
            {
                base.Pawn.health.AddHediff(HediffDefOf.WoundInfection, this.parent.Part, null, null);
                base.Pawn.health.AddHediff(HediffDefOf.WoundInfection, this.parent.Part, null, null);
            }
            base.CompPostMake();
        }

      

    }
}
